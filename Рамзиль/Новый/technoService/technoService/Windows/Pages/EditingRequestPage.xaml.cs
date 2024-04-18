using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using technoService;
using technoServise.Model;

namespace demo_test_time.Windows.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditingRequestPage.xaml
    /// </summary>
    public partial class EditingRequestPage : Page
    {
        public EditingRequestPage()
        {
            InitializeComponent();
            init();
        }
        List<StaffsTable> performers = new List<StaffsTable>();
        void init()
        {
            statusComboBox.ItemsSource = App.context.StatusTables.Select(s=>s.StatusName).ToList();
            prioritetComboBox.ItemsSource = new string[] { "Низкое", "Среднее", "Высокое" };
            if (Global.requests.RequestStatus != null)
            {
                statusComboBox.SelectedItem = Global.requests.RequestStatus.StatusName;
            }
            prioritetComboBox.SelectedItem = Global.requests.RequestPriority;

            var sutuffs = App.context.StaffsTables.Where(w => w.StaffRoleId == 2).ToList();
            performers = App.context.PerformersTables.Where(w => w.RequestId == Global.requests.IdRequest).Select(s=>s.Stuff).ToList();
            List<StuffComboBox> stuffComboBoxes = sutuffs.Select(s =>
            {
                bool isSelected = performers.Any(a => a.IdStaff == s.IdStaff);
                return new StuffComboBox { StuffId = s.IdStaff, StuffName = s.StaffName, isSelected = isSelected };
            }).ToList();
            stuffComboBox.ItemsSource = stuffComboBoxes;
            descriptionTextBox.Text = Global.requests.RequestsDescription;
            commentTextBox.Text = Global.requests.RequestComment;

        }
        class StuffComboBox
        {
            public int StuffId { get; set; }
            public string StuffName { get; set;}
            public bool isSelected { get; set; }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            var stuffComoList = stuffComboBox.Items.Cast<StuffComboBox>().ToList();
            foreach (var stuffP in performers) {
                if(!stuffComoList.Any(a=>a.StuffId== stuffP.IdStaff && a.isSelected==true)){
                    App.context.PerformersTables.Remove(new PerformersTable{StuffId=stuffP.IdStaff,RequestId=Global.requests.IdRequest});
                }
            }
            foreach (var stuffC in stuffComoList) {
                if (stuffC.isSelected)
                {
                    if (performers.Any(a => a.IdStaff == stuffC.StuffId) || App.context.PerformersTables.Any(s => s.StuffId == stuffC.StuffId))
                    {
                        MessageBox.Show($"Сотрудник {stuffC.StuffName} закреплен за другой задачей");
                        return;
                    }
                    else
                    {
                      
                        App.context.PerformersTables.Add(new PerformersTable { StuffId=stuffC.StuffId,RequestId=Global.requests.IdRequest});
                    }
                }
            }
            if (prioritetComboBox.SelectedIndex !=-1){
                Global.requests.RequestPriority = prioritetComboBox.Text;
            }
            if(statusComboBox.SelectedIndex != -1)
            {
                Global.requests.RequestStatusId = statusComboBox.SelectedIndex + 1;

            }
            if (!String.IsNullOrEmpty(descriptionTextBox.Text))
            {
                Global.requests.RequestsDescription = descriptionTextBox.Text;
            }
            if (!String.IsNullOrEmpty(commentTextBox.Text))
            {
                Global.requests.RequestComment= commentTextBox.Text; 
            }
            App.context.SaveChanges();
            MessageBox.Show("Успешно сохранено");

        }
    }
}

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
using System.Windows.Shapes;
using remont_demo.Model;
using remont_demo.Pages;

namespace remont_demo.Dialogs
{
    /// <summary>
    /// Логика взаимодействия для EditRequestDialog.xaml
    /// </summary>
    public partial class EditRequestDialog : Window
    {
        List<StaffsTable> performersStuffs= new List<StaffsTable>();
        public EditRequestDialog()
        {
            InitializeComponent();
            if (Global.stuff.StaffRoleId == 2)
            {
                stuffComboBox.Visibility = Visibility.Collapsed;
            }
            else if(Global.stuff.StaffRoleId == 1)
            {
                PriorityComboBox.Visibility = Visibility.Collapsed;
            }
            statusComboBox.ItemsSource = App.Context.StatusTables.Select(s => s.StatusName).ToList();
            PriorityComboBox.ItemsSource = new String[] { "Низкое", "Среднее", "Высокое" };
            PriorityComboBox.SelectedItem = Global.request.RequestPriority;
            var requestId= Global.request.RequestStatusId;
            if (requestId != null)
            {
                statusComboBox.SelectedIndex = requestId.Value-1;
            }
            descriptionTextBox.Text = Global.request.RequestsDescription;
            performersStuffs = App.Context.PerformersTables.Where(p => p.RequestId == Global.request.IdRequest).Select(s=>s.Stuff).ToList();
            var stuffs = App.Context.StaffsTables.Where(w => w.StaffRoleId == 2).ToList();
            List<stuffCheck> stuffCombo= stuffs.Select(s =>
            {
                bool isSelected = performersStuffs.Any(s2 => s2.IdStaff == s.IdStaff);
                return new stuffCheck { StuffName = s.StaffName, IsSelectd = isSelected,StuffId= s.IdStaff };
            }).ToList();
            stuffComboBox.ItemsSource = stuffCombo;
        }
        class stuffCheck
        {
            public string StuffName { get; set; } = null!;
            public bool IsSelectd { get; set; }
            public int StuffId { get; set; }
        }


        private void saveButtonRequest_Click(object sender, RoutedEventArgs e)
        {

            var stuffCombo = stuffComboBox.Items.Cast<stuffCheck>().ToList();
            foreach(var p in performersStuffs)
            {
                if (!stuffCombo.Any(a => a.StuffName == p.StaffName && a.IsSelectd==true))
                {
                    App.Context.PerformersTables.Remove(new PerformersTable { StuffId=p.IdStaff,RequestId=Global.request.IdRequest});
                }
            }
            foreach(var stuff in stuffCombo)
            {
                if (stuff.IsSelectd)
                {
                    if (!performersStuffs.Any(a => a.IdStaff == stuff.StuffId))
                    {
                        if(App.Context.PerformersTables.Any(a=>a.StuffId== stuff.StuffId))
                        {
                            MessageBox.Show($"Сотрудник {stuff.StuffName} закреплен за другой задачей"); 
                        }
                        else
                        {
                           App.Context.PerformersTables.Add(new PerformersTable { StuffId = stuff.StuffId, RequestId = Global.request.IdRequest });
                        }
                    }
                }
            }
            if (statusComboBox.SelectedIndex != -1)
            {
                Global.request.RequestStatusId= statusComboBox.SelectedIndex+1;
            }
            if(!string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                Global.request.RequestsDescription = descriptionTextBox.Text;
            }
            if (PriorityComboBox.SelectedIndex != -1)
            {
                Global.request.RequestPriority = PriorityComboBox.SelectedItem.ToString();
            }
            App.Context.SaveChanges();
            RequestWindow requestWindow = new RequestWindow();
            requestWindow.Show();
            this.Close();

        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            RequestWindow requestWindow = new RequestWindow();
            requestWindow.Show();
            this.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using remont_demo.Dialogs;
using remont_demo.Model;
using static System.Net.Mime.MediaTypeNames;

namespace remont_demo.Pages
{
    /// <summary>
    /// Логика взаимодействия для Requests.xaml
    /// </summary>
    public partial class RequestWindow : Window
    {
        public RequestWindow()
        {
            InitializeComponent();
            userFioLabel.Content = $"{Global.stuff.StaffName} {Global.stuff.StaffSurname}";
            userRoleLabel.Content = $"{Global.stuff.StaffRole.RoleName}";
            showRequest();
            if (Global.stuff.StaffRoleId == 2)
            {
                addRequestButton.Visibility = Visibility.Collapsed;
            }

        }

        private void breakButton_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }
        void showRequest() {
            var req = App.Context.RequestsTables.ToList();
            if (!String.IsNullOrEmpty(serchTextBox.Text))
            {
                req = req.Where(s => s.IdRequest==Convert.ToUInt32(serchTextBox.Text)).ToList();
            }
            if (Global.stuff.StaffRoleId == 2)
            {
                req = req.Where(s => App.Context.PerformersTables.Any(r => r.RequestId == s.IdRequest && r.StuffId==Global.stuff.IdStaff)).ToList();
            }
                list.ItemsSource = req;
        }


        private void serchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            showRequest();
        }

        private void addRequestButton_Click(object sender, RoutedEventArgs e)
        {
            RequestAddDialogs requestAddDialogs=new RequestAddDialogs();
            requestAddDialogs.Show();
            this.Close();
        }
        private void serchTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null)
            {
                var item = (RequestsTable)list.SelectedItem;
                Global.request = item;
                EditRequestDialog editDialog = new EditRequestDialog();
                editDialog.Show();
                this.Close();
            }
        }
    }
}

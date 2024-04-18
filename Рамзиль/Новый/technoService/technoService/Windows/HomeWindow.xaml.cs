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
using demo_test_time.Windows.Pages;
using technoServise.Model ;
using technoServise.Dialogs;
using ООО_Техносервис.Windows;
namespace technoServise.Windows
{
    /// <summary>
    /// Логика взаимодействия для HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
            init();
        }
        void init()
        {
            homeFrame.Navigate(new RequestsViewPage());
            FioStuffLabel.Content = Global.staff.StaffName + " " + Global.staff.StaffSurname;
            if (Global.staff.StaffRoleId != 2)
            {
                addReuest.Visibility=Visibility.Visible;
            }
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            var page = homeFrame.Content as Page;
            if(page.Title== "RequestsViewPage")
            {
                AuthWindow auth = new AuthWindow();
                auth.Show();
                this.Close();
            }
            else
            {
                homeFrame.GoBack();
            }
        }

        private void addReuest_Click(object sender, RoutedEventArgs e)
        {
            RequestAddDialogs requestAddDialogs = new RequestAddDialogs();
            requestAddDialogs.ShowDialog();
            this.Close();
        }

        private void QrCodeButton_Click(object sender, RoutedEventArgs e)
        {
            QRCodeWindow qRCodeWindow= new QRCodeWindow();
            qRCodeWindow.Show();
        }
    }
}

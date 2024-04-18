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
    /// Логика взаимодействия для RequestsViewPage.xaml
    /// </summary>
    public partial class RequestsViewPage : Page
    {
        public RequestsViewPage()
        {
            InitializeComponent();
            LisViewShow();
        }
        void LisViewShow()
        {
            var req=App.context.RequestsTables.ToList();
            if (!String.IsNullOrEmpty(searchTextBox.Text))
            {
                req=req.Where(w=>w.IdRequest.ToString()==searchTextBox.Text).ToList();
            }
            if (Global.staff.StaffRoleId == 2)
            {
                req = req.Where(w => App.context.PerformersTables.Any(a => a.RequestId == w.IdRequest && a.StuffId == Global.staff.IdStaff)).ToList();
            }
            listView.ItemsSource = req;
        }

        private void searchTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            LisViewShow();
        }

        private void editingConextButton_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                var request=(RequestsTable)listView.SelectedItem;
                if (request != null)
                {
                    Global.requests = request;
                    this.NavigationService.Navigate(new Uri("Windows/Pages/EditingRequestPage.xaml", UriKind.Relative));
                }
            }
        }
    }
}

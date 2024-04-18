using technoServise;
using technoServise.Model;
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
using technoService;
namespace technoServise.Dialogs
{
    /// <summary>
    /// Логика взаимодействия для ClientAddDialogs.xaml
    /// </summary>
    public partial class ClientAddDialogs : Window
    {
        public ClientAddDialogs()
        {
            InitializeComponent();
        }

        private void addClientButton_Click(object sender, RoutedEventArgs e)
        {
            ClientsTable clients = new ClientsTable
            {
                ClientName = nameTextBox.Text,
                ClientSurname = surnameTextBox.Text,
                ClientPhone = phoneTextBox.Text
            };
            App.context.ClientsTables.Add(clients);
            App.context.SaveChanges();
            RequestAddDialogs requestAddDialogs=new RequestAddDialogs();
            requestAddDialogs.Show();
            this.Close();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            RequestAddDialogs requestAddDialogs = new RequestAddDialogs();
            requestAddDialogs.Show();
            this.Close();
        }
    }
}

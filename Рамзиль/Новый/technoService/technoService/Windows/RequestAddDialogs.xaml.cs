
using technoServise.Model;
using technoServise.Windows;
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
    /// Логика взаимодействия для RequestAddDialogs.xaml
    /// </summary>
    public partial class RequestAddDialogs : Window
    {
        public RequestAddDialogs()
        {
            InitializeComponent();
            typeFayltComboBox.ItemsSource= App.context.TypeFaultTables.Select(s => s.TypeFaultName).ToList();
            clientsComboBox.ItemsSource=App.context.ClientsTables.Select(s=>s.ClientName).ToList();
        }

        private void addClient_Click(object sender, RoutedEventArgs e)
        {
            ClientAddDialogs clientAddDialogs= new ClientAddDialogs();
            clientAddDialogs.ShowDialog();
            this.Close();
        }

        private void buttonAddRequest_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(equipmentTextBox.Text) 
                || string.IsNullOrWhiteSpace(descriptionTextBox.Text)
                || clientsComboBox.SelectedIndex==-1
                || clientsComboBox.SelectedIndex==-1)
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            RequestsTable request = new RequestsTable
            {
                RequestClietnId=clientsComboBox.SelectedIndex+1,
                RequestCreateDate=DateTime.Now,
                RequestTypeFaultId=typeFayltComboBox.SelectedIndex+1,
                ReuestEquipment=equipmentTextBox.Text,
                RequestsDescription=descriptionTextBox.Text
    
            };
            App.context.RequestsTables.Add(request);
            App.context.SaveChanges();
            HomeWindow home = new HomeWindow();
            home.Show();
            this.Close();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow home = new HomeWindow();
            home.Show();
            this.Close();
        }
    }
}

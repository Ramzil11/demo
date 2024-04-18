using remont_demo.Model;
using remont_demo.Pages;
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

namespace remont_demo.Dialogs
{
    /// <summary>
    /// Логика взаимодействия для RequestAddDialogs.xaml
    /// </summary>
    public partial class RequestAddDialogs : Window
    {
        public RequestAddDialogs()
        {
            InitializeComponent();
            typeFayltComboBox.ItemsSource= App.Context.TypeFaultTables.Select(s => s.TypeFaultName).ToList();
            clientsComboBox.ItemsSource=App.Context.ClientsTables.Select(s=>s.ClientName).ToList();
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
            App.Context.RequestsTables.Add(request);
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

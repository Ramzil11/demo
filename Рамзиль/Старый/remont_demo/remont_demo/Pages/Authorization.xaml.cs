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
using remont_demo.Pages;
using remont_demo.Model;
namespace remont_demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var passrod = checkBoxPwd.IsChecked.Value ? pwdTextBox.Text : pwdPasswordBox.Password;
            var result = App.Context.StaffsTables.ToList().FirstOrDefault(s => s.StaffPassword == passrod && s.StuffLogin == loginTexBox.Text);
            if (result != null)
            {
                Global.stuff = result;
                RequestWindow requestWindow = new RequestWindow();
                //product.UserFio.Content = $"{result.UserSurname} {result.UserName} {result.UserPatronymic}";
                requestWindow.Show();
                this.Close();
                MessageBox.Show("Вы успешно авторизовались");
            }
            else
            {
                MessageBox.Show("Вы ввели не верный логин или пароль");
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox.IsChecked.Value)
            {
                pwdTextBox.Text = pwdPasswordBox.Password; // скопируем в TextBox из PasswordBox
                pwdTextBox.Visibility = Visibility.Visible; // TextBox - отобразить
                pwdPasswordBox.Visibility = Visibility.Hidden; // PasswordBox - скрыть
            }
            else
            {
                pwdPasswordBox.Password = pwdTextBox.Text; // скопируем в PasswordBox из TextBox 
                pwdTextBox.Visibility = Visibility.Hidden; // TextBox - скрыть
                pwdPasswordBox.Visibility = Visibility.Visible; // PasswordBox - отобразить
            }
        }
    }
}

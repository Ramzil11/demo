using System.Text;
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
using technoServise.Windows;
namespace technoServise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }


        private void checkBox_Click(object sender, RoutedEventArgs e)
        {
            var check = sender as CheckBox;
            if (check.IsChecked.Value)
            {
                passwordTextBox.Text = passwordBox.Password;
                passwordTextBox.Visibility = Visibility.Visible;
                passwordBox.Visibility = Visibility.Hidden;
            }
            else
            {
                passwordBox.Password=passwordTextBox.Text;
                passwordTextBox.Visibility = Visibility.Hidden;
                passwordBox.Visibility = Visibility.Visible;
            }
        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            var password = checkBox.IsChecked.Value ? passwordTextBox.Text : passwordBox.Password;
            var result = App.context.StaffsTables.ToList().FirstOrDefault(s => s.StuffLogin == loginTextBox.Text && s.StaffPassword == password);
            if (result!=null)
            {
                Global.staff=result;
                HomeWindow home = new HomeWindow();
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль!");
            }
        }
    }
}
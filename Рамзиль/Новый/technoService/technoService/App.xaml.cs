using technoServise.Model;
using System.Configuration;
using System.Data;
using System.Windows;

namespace technoService
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Remontv2Context context { get; } = new Remontv2Context();
    }

}

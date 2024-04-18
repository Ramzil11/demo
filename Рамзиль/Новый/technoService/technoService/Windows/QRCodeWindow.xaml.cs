using System;
using System.Collections.Generic;
using System.IO;
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
using System.Drawing;
using MessagingToolkit.QRCode.Codec;
using System.Text.Encodings.Web;

namespace ООО_Техносервис.Windows
{
    /// <summary>
    /// Логика взаимодействия для QRCodeWindow.xaml
    /// </summary>
    public partial class QRCodeWindow : Window
    {
        public QRCodeWindow()
        {
            InitializeComponent();
            GenerateAndDisplayQRCode("https://docs.google.com/forms/d/e/1FAIpQLSdhZcExx6LSIXxk0ub55mSu-WIh23WYdGG9HY5EZhLDo7P8eA/viewform?usp=sf_link");
        }

        private void GenerateAndDisplayQRCode(string content)
        {
            QRCodeEncoder encoder = new QRCodeEncoder(); //создаем объект класса QRCodeEncoder
            Bitmap bmp = encoder.Encode(content);
            qrCodeImageView.Source = ConvertBitmapToBitmapImage(bmp); // qrCodeImageView - ваш элемент Image WPF
        }

        private BitmapImage ConvertBitmapToBitmapImage(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
                memory.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                bitmapImage.Freeze();
                return bitmapImage;
            }
        }
    }
}

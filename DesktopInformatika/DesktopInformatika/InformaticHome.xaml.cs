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

namespace DesktopInformatika
{
    /// <summary>
    /// Interaction logic for InformaticHome.xaml
    /// </summary>
    public partial class InformaticHome : Page
    {
        public InformaticHome()
        {
            InitializeComponent();
        }

        private void button_Admin(object sender, MouseButtonEventArgs e)
        {
            AdminLogin window = new AdminLogin();
            window.Show();
        }

        private void buttonGetStart_Click(object sender, RoutedEventArgs e)
        {
            InfoLengkapJurusan window = new InfoLengkapJurusan();
            window.Show();
        }

        private void buttonProdi_Click(object sender, RoutedEventArgs e)
        {
            InformaticProdi prodi = new InformaticProdi();
            this.NavigationService.Navigate(prodi);
        }

        private void buttonLab_Click(object sender, RoutedEventArgs e)
        {
            InformaticLab lab = new InformaticLab();
            this.NavigationService.Navigate(lab);
        }

        private void buttonBiro_Click(object sender, RoutedEventArgs e)
        {
            InformaticBiro biro = new InformaticBiro();
            this.NavigationService.Navigate(biro);
        }
    }
}

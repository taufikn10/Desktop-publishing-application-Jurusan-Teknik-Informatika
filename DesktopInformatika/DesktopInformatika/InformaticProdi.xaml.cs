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
    /// Interaction logic for InformaticProdi.xaml
    /// </summary>
    public partial class InformaticProdi : Page
    {
        public InformaticProdi()
        {
            InitializeComponent();
        }

        private void buttonProdi_Click(object sender, RoutedEventArgs e)
        {
            DetailProdi window = new DetailProdi();
            window.Show();
        }
    }
}

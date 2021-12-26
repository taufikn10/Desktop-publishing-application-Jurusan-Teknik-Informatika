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
    /// Interaction logic for InformaticBiro.xaml
    /// </summary>
    public partial class InformaticBiro : Page
    {
        public InformaticBiro()
        {
            InitializeComponent();
        }

        private void buttonBiro_Click(object sender, RoutedEventArgs e)
        {
            DetailBiro window = new DetailBiro();
            window.Show();
        }
    }
}

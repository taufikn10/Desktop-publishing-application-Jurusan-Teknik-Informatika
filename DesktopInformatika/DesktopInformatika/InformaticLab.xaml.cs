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
    /// Interaction logic for InformaticLab.xaml
    /// </summary>
    public partial class InformaticLab : Page
    {
        public InformaticLab()
        {
            InitializeComponent();
        }

        private void buttonLab_Click(object sender, RoutedEventArgs e)
        {
            DetailLab window = new DetailLab();
            window.Show();
        }
    }
}

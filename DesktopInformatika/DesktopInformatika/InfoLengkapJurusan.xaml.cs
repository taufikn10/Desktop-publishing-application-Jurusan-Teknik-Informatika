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
using System.Diagnostics;


namespace DesktopInformatika
{
    /// <summary>
    /// Interaction logic for InfoLengkapJurusan.xaml
    /// </summary>
    public partial class InfoLengkapJurusan : Window
    {
        public InfoLengkapJurusan()
        {
            InitializeComponent();
        }

        private void menujulaman(object sender, MouseButtonEventArgs e)
        {
            Process.Start("http://jtif.ft.unesa.ac.id");
        }
    }
}

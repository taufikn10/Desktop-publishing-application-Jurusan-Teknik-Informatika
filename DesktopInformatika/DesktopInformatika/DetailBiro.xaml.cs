using System;
using System.Collections.Generic;
using System.Data;
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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DesktopInformatika
{
    /// <summary>
    /// Interaction logic for DetailBiro.xaml
    /// </summary>
    public partial class DetailBiro : Window
    {
        MySqlConnection koneksi = new MySqlConnection("SERVER = localhost; USER = root; PASSWORD =; DATABASE = db_desktoppublish");

        public DetailBiro()
        {
            InitializeComponent();
        }

        private void Biro_Loaded(object sender, RoutedEventArgs e)
        {
            koneksi.Open();
            LoadBiro();
            koneksi.Close();
        }

        public void LoadBiro()
        {
            // Inisialisasi MysqlCommand
            MySqlCommand command;
            command = koneksi.CreateCommand();

            // Query ambil data dari tabel
            command.CommandText = "SELECT biro AS 'BIRO', keterangan AS 'KETERANGAN BIRO', ketua AS 'KETUA', wakil AS 'WAKIL', sekertaris AS 'SEKERTARIS', bendahara AS 'BENDAHARA', tempat_latihan AS 'TEMPAT LATIHAN', hari_latihan AS 'HARI LATIHAN', prestasi AS 'PRESTASI' FROM tb_biro;";

            // Memasukkan data ke DATA-GRID-VIEW
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable("Biro");
            adapter.Fill(data);
            DataGridBiro.ItemsSource = data.DefaultView;
        }
    }
}

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
    /// Interaction logic for DetailProdi.xaml
    /// </summary>
    public partial class DetailProdi : Window
    {
        MySqlConnection koneksi = new MySqlConnection("SERVER = localhost; USER = root; PASSWORD =; DATABASE = db_desktoppublish");

        public DetailProdi()
        {
            InitializeComponent();
        }

        private void Prodi_Loaded(object sender, RoutedEventArgs e)
        {
            koneksi.Open();
            LoadProdi();
            koneksi.Close();
        }

        private void LoadProdi()
        {
            // Inisialisasi MysqlCommand
            MySqlCommand command;
            command = koneksi.CreateCommand();

            // Query ambil data dari tabel
            command.CommandText = "SELECT prodi AS 'PRODI', suratKetetapan AS 'NO SK', tahun AS 'TAHUN', akreditasi AS 'AKREDITASI', tglKadaluarsa AS 'TANGGAL KADALUARSA' FROM tb_prodi;";

            // Memasukkan data ke DATA-GRID-VIEW
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable("Prodi");
            adapter.Fill(data);
            DataGridProdi.ItemsSource = data.DefaultView;
        }
    }
}

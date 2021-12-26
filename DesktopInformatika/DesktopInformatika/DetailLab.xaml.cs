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
    /// Interaction logic for DetailLab.xaml
    /// </summary>
    public partial class DetailLab : Window
    {
        MySqlConnection koneksi = new MySqlConnection("SERVER = localhost; USER = root; PASSWORD =; DATABASE = db_desktoppublish");

        public DetailLab()
        {
            InitializeComponent();            
        }

        private void Lab_Loaded(object sender, RoutedEventArgs e)
        {
            koneksi.Open();
            LoadLab();
            koneksi.Close();
        }

        public void LoadLab()
        {
            // Inisialisasi MysqlCommand
            MySqlCommand command;
            command = koneksi.CreateCommand();

            // Query ambil data dari tabel
            command.CommandText = "SELECT laboratorium AS 'LABORATORIUM', kepalaLab AS 'KEPALA LABORATORIUM', fungsi_lab AS 'FUNGSI' FROM tb_lab;";

            // Memasukkan data ke DATA-GRID-VIEW
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable("Laboratorium");
            adapter.Fill(data);
            DataGridLab.ItemsSource = data.DefaultView;
        }
    }
}

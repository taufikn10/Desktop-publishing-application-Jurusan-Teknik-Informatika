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
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection koneksi = new MySqlConnection("SERVER = localhost; USER = root; PASSWORD =; DATABASE = db_desktoppublish");


            // Inisialisasi MysqlCommand
            MySqlCommand command;
            command = koneksi.CreateCommand();

            // Query ambil data dari tabel mahasiswa
            command.CommandText = "SELECT count(*) FROM tb_admin WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Password + "';";

            // Memasukkan data ke DATA-GRID-VIEW
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable data = new DataTable();
            adapter.Fill(data);

            if (data.Rows[0][0].ToString() == "1")
            {
                this.Close();

                Admin window = new Admin();
                window.Show();
            } 
            else
            {
                MessageBox.Show("Anda Bukan Admin ! Halaman tidak bisa diakses.", "Caution", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

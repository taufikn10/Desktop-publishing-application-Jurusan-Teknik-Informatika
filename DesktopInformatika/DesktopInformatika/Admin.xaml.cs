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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        MySqlConnection koneksi = new MySqlConnection("SERVER = localhost; USER = root; PASSWORD =; DATABASE = db_desktoppublish");

        public string[] score { get; set; }

        public Admin()
        {
            InitializeComponent();

            score = new string[] { "A", "B", "C", "D", "E" };
            DataContext = this;
        }

        private void UpdateAdmin_Loaded(object sender, RoutedEventArgs e)
        {
            koneksi.Open();
            LoadProdi();
            LoadLab();
            LoadBiro();
            koneksi.Close();
        }

    // UPDATE DATA BIRO
        private void clearBiro()
        {
            Txt_biro.Text = "";
            Txt_ketua.Text = "";
            Txt_wakil.Text = "";
            Txt_sekertaris.Text = "";
            Txt_bendahara.Text = "";
        }

        public void LoadBiro()
        {
            // Inisialisasi MysqlCommand
            MySqlCommand commandBiro;
            commandBiro = koneksi.CreateCommand();

            // Query ambil data dari tabel
            commandBiro.CommandText = "SELECT biro AS 'BIRO', ketua AS 'KETUA', wakil AS 'WAKIL', sekertaris AS 'SEKERTARIS', bendahara AS 'BENDAHARA' FROM tb_biro;";

            // Memasukkan data ke DATA-GRID-VIEW
            MySqlDataAdapter adp_biro = new MySqlDataAdapter(commandBiro);
            DataTable dt_biro = new DataTable();
            adp_biro.Fill(dt_biro);
            DataBiro.ItemsSource = dt_biro.DefaultView;
            Txt_biro.Focus();
        }

        private void DataBiro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dt_biro = (DataGrid)sender;
            DataRowView row_selected = dt_biro.SelectedItem as DataRowView;

            if (row_selected != null)
            {
                Txt_biro.Text = row_selected["biro"].ToString();
                Txt_ketua.Text = row_selected["ketua"].ToString();
                Txt_wakil.Text = row_selected["wakil"].ToString();
                Txt_sekertaris.Text = row_selected["sekertaris"].ToString();
                Txt_bendahara.Text = row_selected["bendahara"].ToString();
            }
        }

        private void btnUpdateBiro_Click(object sender, RoutedEventArgs e)
        {
            if (Txt_ketua.Text == "" || Txt_wakil.Text == "" || Txt_sekertaris.Text == "" || Txt_bendahara.Text == "")
            {
                MessageBox.Show("Data yang anda masukkan tidak lengkap !", "Caution", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                koneksi.Open();

                // Inisialisasi MysqlCommand
                MySqlCommand commandBiro;
                commandBiro = koneksi.CreateCommand();

                // Query ambil data dari tabel
                commandBiro.CommandText = "UPDATE tb_biro SET ketua = @ketua, wakil = @wakil, sekertaris = @sekertaris, bendahara = @bendahara WHERE biro = @namaBiro;";

                commandBiro.Parameters.AddWithValue("@namaBiro", Txt_biro.Text);
                commandBiro.Parameters.AddWithValue("@ketua", Txt_ketua.Text);
                commandBiro.Parameters.AddWithValue("@wakil", Txt_wakil.Text);
                commandBiro.Parameters.AddWithValue("@sekertaris", Txt_sekertaris.Text);
                commandBiro.Parameters.AddWithValue("@bendahara", Txt_bendahara.Text);

                // Execute query yang diberikan
                commandBiro.ExecuteNonQuery();

                MessageBox.Show("Data Biro Update Successfully");

                // Bersihkan Textbox dan Refresh Database
                clearBiro();
                LoadBiro();
            }
            koneksi.Close();
        }



    // UPDATE DATA LABRATORIUM
        private void clearLab()
        {
            Txt_lab.Text = "";
            Txt_kepala.Text = "";
        }

        public void LoadLab()
        {
            // Inisialisasi MysqlCommand
            MySqlCommand commandLab;
            commandLab = koneksi.CreateCommand();

            // Query ambil data dari tabel
            commandLab.CommandText = "SELECT laboratorium AS 'LABORATORIUM', kepalaLab AS 'KEPALA LAB' FROM tb_lab;";

            // Memasukkan data ke DATA-GRID-VIEW
            MySqlDataAdapter adp_lab = new MySqlDataAdapter(commandLab);
            DataTable dt_lab = new DataTable();
            adp_lab.Fill(dt_lab);
            DataLab.ItemsSource = dt_lab.DefaultView;
            Txt_lab.Focus();
        }

        private void DataLab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dt_lab = (DataGrid)sender;
            DataRowView row_selected = dt_lab.SelectedItem as DataRowView;

            if (row_selected != null)
            {
                Txt_lab.Text = row_selected["laboratorium"].ToString();
            }
        }

        private void btnUpdateLab_Click(object sender, RoutedEventArgs e)
        {
            if (Txt_kepala.Text == "")
            {
                MessageBox.Show("Data yang anda masukkan tidak lengkap !", "Caution", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                koneksi.Open();

                // Inisialisasi MysqlCommand
                MySqlCommand commandLab;
                commandLab = koneksi.CreateCommand();

                // Query ambil data dari tabel
                commandLab.CommandText = "UPDATE tb_lab SET kepalaLab = @kepala WHERE laboratorium = @namaLab;";

                commandLab.Parameters.AddWithValue("@namaLab", Txt_lab.Text);
                commandLab.Parameters.AddWithValue("@kepala", Txt_kepala.Text);
                
                // Execute query yang diberikan
                commandLab.ExecuteNonQuery();

                MessageBox.Show("Data Lab Update Successfully");

                // Bersihkan Textbox dan Refresh Database
                clearLab();
                LoadLab();
            }
            koneksi.Close();
        }



    // UPDATE DATA PRODI
        private void clearProdi()
        {
            Txt_prodi.Text = "";
            Txt_surat.Text = "";
            Txt_tahun.Text = "";
            Txt_akreditasi.SelectedItem = null;
            Txt_kadaluarsa.SelectedDate = null;
        }

        private void LoadProdi()
        {
            // Inisialisasi MysqlCommand
            MySqlCommand commandProdi;
            commandProdi = koneksi.CreateCommand();

            // Query ambil data dari tabel
            commandProdi.CommandText = "SELECT prodi AS 'PRODI', suratKetetapan AS 'NO SK', tahun AS 'TAHUN', akreditasi AS 'AKREDITASI', tglKadaluarsa AS 'TGL KADALUARSA' FROM tb_prodi;";

            // Memasukkan data ke DATA-GRID-VIEW
            MySqlDataAdapter adp_prodi = new MySqlDataAdapter(commandProdi);
            DataTable dt_prodi = new DataTable();
            adp_prodi.Fill(dt_prodi);
            DataProdi.ItemsSource = dt_prodi.DefaultView;
            Txt_prodi.Focus();
        }

        private void DataProdi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dt_prodi = (DataGrid)sender;
            DataRowView row_selected = dt_prodi.SelectedItem as DataRowView;

            if (row_selected != null)
            {
                Txt_prodi.Text = row_selected["prodi"].ToString();
            }
        }

        private void btnUpdateProdi_Click(object sender, RoutedEventArgs e)
        {
            if (Txt_surat.Text == "" || Txt_tahun.Text == "" || Txt_akreditasi.SelectedItem == null || Txt_kadaluarsa.SelectedDate == null)
            {
                MessageBox.Show("Data yang anda masukkan tidak lengkap !", "Caution", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                koneksi.Open();

                // Inisialisasi MysqlCommand
                MySqlCommand commandProdi;
                commandProdi = koneksi.CreateCommand();

                // Query ambil data dari tabel
                commandProdi.CommandText = "UPDATE tb_prodi SET suratKetetapan = @nosk, tahun = @tahun, akreditasi = @akreditasi, tglKadaluarsa = @tgl WHERE prodi = @namaProdi;";

                commandProdi.Parameters.AddWithValue("@namaProdi", Txt_prodi.Text);
                commandProdi.Parameters.AddWithValue("@nosk", Txt_surat.Text);
                commandProdi.Parameters.AddWithValue("@tahun", Txt_tahun.Text);
                commandProdi.Parameters.AddWithValue("@akreditasi", Txt_akreditasi.SelectedItem);
                commandProdi.Parameters.AddWithValue("@tgl", Txt_kadaluarsa.SelectedDate);

                // Execute query yang diberikan
                commandProdi.ExecuteNonQuery();

                MessageBox.Show("Data Prodi Update Successfully");

                // Bersihkan Textbox dan Refresh Database
                clearProdi();
                LoadProdi();
            }
            koneksi.Close();
        }
    }
}

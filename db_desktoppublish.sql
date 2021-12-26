-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 10, 2021 at 10:10 AM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_desktoppublish`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_admin`
--

CREATE TABLE `tb_admin` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_admin`
--

INSERT INTO `tb_admin` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin'),
(2, 'host', 'host');

-- --------------------------------------------------------

--
-- Table structure for table `tb_biro`
--

CREATE TABLE `tb_biro` (
  `id_biro` int(8) NOT NULL,
  `biro` varchar(100) DEFAULT NULL,
  `keterangan` text DEFAULT NULL,
  `ketua` varchar(100) DEFAULT NULL,
  `wakil` varchar(100) DEFAULT NULL,
  `sekertaris` varchar(100) DEFAULT NULL,
  `bendahara` varchar(100) DEFAULT NULL,
  `tempat_latihan` text DEFAULT NULL,
  `hari_latihan` text DEFAULT NULL,
  `prestasi` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_biro`
--

INSERT INTO `tb_biro` (`id_biro`, `biro`, `keterangan`, `ketua`, `wakil`, `sekertaris`, `bendahara`, `tempat_latihan`, `hari_latihan`, `prestasi`) VALUES
(1, 'BIRO VOLI', 'Biro yang mewadahi kreativitas mahasiswa di jurusan teknik informatika dalam bidang non akademik yang mengarah pada ke-olahragaan voli', 'Thowilulbaa’i Muttaqin (SI 2018)', 'Safirul Kudsi (PTI 2019)', 'M. Andika Putra Y (TI 2019)', 'M. David Irsyadus S (PTI 2019)', 'Lapangan E2', 'Senin dan Kamis', '1) DEKAN ESO CUP FT (Juara 1)'),
(2, 'BIRO BADMINTON', 'Biro yang mewadahi kreativitas mahasiswa di jurusan teknik informatika dalam bidang non akademik yang mengarah pada ke-olahragaan badminton', 'Taufik Nurrahman (MI 2019)', 'Mochamad Abhiegail A.P (TI 2019)', '-', '-', 'Kantor Kelurahan Ketintang', 'Untuk sekarang, hari belum dipastikan. Nanti kita diskusikan  untuk hari yang pas dan tentunya latihan diadakan seminggu sekali\r\n', '-'),
(3, 'BIRO FUTSAL', 'Biro yang mewadahi kreativitas mahasiswa di jurusan teknik informatika dalam bidang non akademik yang mengarah pada ke-olahragaan futsal', 'Fahri Darul Farokhi (PTI 2019)', 'Edwin Irfan (TI 2019)', 'Prayogi Kardani (TI 2019)', 'Bagas (SI 2018)', 'Lapangan Weta', 'Senin', '1) MABA CUP UNESA (Juara 2)\r\n2) PEKAN OLAHRAGA FT (Juara 1)\r\n'),
(4, 'BIRO BASKET', 'Biro yang mewadahi kreativitas mahasiswa di jurusan teknik informatika dalam bidang non akademik yang mengarah pada ke-olahragaan basket', 'M. Wisnu Aditya A. R. (SI 2019)', 'Zaidan Z. (MI 2019)', 'M. Rafi’ Atha N. R. (SI 2019)', 'Dandy Arisna P. (SI 2019)', 'Lapangan Sepanjang', 'Kamis', '1) ESO CUP 2018 (Juara 1)\r\n2) ESO CUP 2019 (Juara 1)\r\n'),
(5, 'BIRO MUSIK', 'Suatu wadah kreativitas mahasiswa di jurusan teknik informatika dalam bidang non akademik yang mengarah pada seni musik. Dengan adanya biro arTi mahasiswa jurusan informatika mampu mengasah skill lain diluar keahlian akademik', 'Sulistya Ernawati (SI 2018)', 'M. Adharis Adlani (TI 2018)', 'Faisal Dwi Priatna (PTI 2019)', 'Alda Maretina I. (SI 2019)', 'Gedung A10 Teknik Informatika UNESA Ketintang', 'Kamis', '1) Loop Station Tahun 2017 (Juara 1)\r\n2) Lomba Cover Lagu Tahun 2018 (Juara 2)\r\n3) Lomba Musik di FIP UNESA Tahun 2018 (Juara 3)\r\n4) Pekan Seni Mahasiswa tingkat Universitas Tahun 2018 (Juara 3)\r\n'),
(6, 'BIRO TARI TRADISIONAL', 'Suatu wadah kreativitas mahasiswa di jurusan teknik informatika dalam bidang non akademik yang mengarah pada seni tari tradisional. Dengan adanya biro arTi mahasiswa jurusan informatika mampu mengasah skill lain diluar keahlian akademik', 'Siti Halimatus Sadiyah (TI 2019)', 'Laras Wahyu Lestary (SI 2019)', 'Putri Islamiah (PTI 2019)', 'Farah Akmalia Rose (PTI 2019)', 'Gedung A10 Teknik Informatika', 'Selasa dan Kamis', '-'),
(7, 'BIRO TARI MODERN', 'Suatu wadah kreativitas mahasiswa di jurusan teknik informatika dalam bidang non akademik yang mengarah pada seni tari modern. Dengan adanya biro arTi mahasiswa jurusan informatika mampu mengasah skill lain diluar keahlian akademik', 'Salma Wijdan E (TI 2018)', 'Sintiya Puji Rahayu (TI 2018)', 'Shyndi Dwita Fania (SI 2019)', 'Retha Rehyta (PTI 2018)', '1) Gedung A10 Teknik Informatika UNESA\r\n2) Marvel City Surabaya\r\n', '2-3 kali dalam satu minggu', '-'),
(8, 'BIRO E-SPORT', 'Biro ini adalah sebuah wadah atau tempat untuk berkumpul dan bermain E-Sport seperti : Mobile Legend, PUBG, Dota, Valorant yang nantinya akan difokuskan untuk mengikuti event-event E-Sport', 'M. Dzikri Hisyam (TI 2018)', '-', 'Wahyu Aldi (TI 2018)', 'Viery Lovega (TI 2018)', 'Gedung A10 Teknik Informatika UNESA', 'Rabu', '-'),
(9, 'BIRO KOLEKTIF', 'Biro ini adalah sebuah wadah atau tempat untuk berkumpul dan belajar tentang ilmu kepenulisan karya tulis ilmiah agar anggota dapat memaksimalkan minat dan bakatnya dalam bidang kepenulisan karya ilmiah.\r\n', 'Dhimas Aufarul Minan (PTI 2018)\r\n', 'Aira Rahmatila (SI 2019)\r\n', 'Zaemita Wahidatul Farida (TI 2019)', 'Arifah Mutia Andini (SI 2019)', 'Gedung A10 Teknik Informatika UNESA Ketintang', 'Kamis', '1) Mahasiswa Berprestasi 2019 (Betzy Alimanda)\r\n2) Mahasiswa Berprestasi 2020 (Aira Rahmatila)\r\n\r\n'),
(10, 'KOMATIK', 'Sebuah komunitas bagi mahasiswa UNESA sebagai wadah dalam pengembangan diri di bidang TIK', '-', '-', '-', '-', '-', '-', '-'),
(11, 'BRAIN', 'Biro yang mewadahi dalam bidang jurnalistik terbentuk pada tahun 2015. memiliki beberapa divisi yaitu :\r\n\r\n1) Jurnalis: bertugas mengumpulkan data dan bahan kegiatan yang akan dijadikan sebuah cerita\r\n\r\n2) Fotografi: betugas mengambil gambar yang digunakan untuk mengambarkan sebuah cerita\r\nvidiografi: bertugas mengambil dan mengolah vidio yang nantinya akan menjadi bahan untuk berita\r\n\r\n3) layouter: mengedit bahan-bahan yang telah dikumpulkan oleh jurnalis dan fotografi', '-', '-', '-', '-', '-', '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `tb_lab`
--

CREATE TABLE `tb_lab` (
  `id_lab` int(8) NOT NULL,
  `laboratorium` varchar(50) DEFAULT NULL,
  `kepalaLab` varchar(100) DEFAULT NULL,
  `fungsi_lab` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_lab`
--

INSERT INTO `tb_lab` (`id_lab`, `laboratorium`, `kepalaLab`, `fungsi_lab`) VALUES
(1, 'Lab. Multimedia', 'Ardhini Warih Utami, S.Kom., M.Kom.', 'Untuk praktikum multimedia dan pengembangan ilmu design UI/UX serta design-design lainnya untuk para mahasiswa/i yang fokus penjurusan ke multimedia'),
(2, 'Lab. Sistem Informasi', 'Aries Dwi Indriyanti, S.Kom., M.Kom.', 'Untuk praktikum sistem informasi dan pengembangan ilmu untuk para mahasiswa/i yang fokus penjurusan ke sistem informasi'),
(3, 'Lab. Rekayasa Perangkat Lunak', 'I Made Suartana, S.Kom., M.Kom.', 'Untuk praktikum rekayasa perangkat lunak dan pengembangan ilmu tentang rancang bangun arsitektur komputer juga program-program untuk para mahasiswa/i yang fokus penjurusan ke rekayasa perangkat lunak'),
(4, 'Lab. Jaringan Komputer', 'Aditya Prapanca, S.T., M.Kom.', 'Untuk praktikum jaringan dan pengembangan ilmu tentang pembuatan jaringan komputer juga program-program yang berkaitan tentang jaringan untuk para mahasiswa/i yang fokus penjurusan ke jaringan komputer');

-- --------------------------------------------------------

--
-- Table structure for table `tb_prodi`
--

CREATE TABLE `tb_prodi` (
  `id_prodi` int(8) NOT NULL,
  `prodi` varchar(50) DEFAULT NULL,
  `suratKetetapan` varchar(100) DEFAULT NULL,
  `tahun` varchar(4) DEFAULT NULL,
  `akreditasi` char(1) DEFAULT NULL,
  `tglKadaluarsa` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_prodi`
--

INSERT INTO `tb_prodi` (`id_prodi`, `prodi`, `suratKetetapan`, `tahun`, `akreditasi`, `tglKadaluarsa`) VALUES
(1, 'D4 Manajemen Informatika', '1057/SK/BAN-PT/Akred/Dipl-III/IV/2018', '2018', 'B', '2023-04-17'),
(2, 'S1 Sistem Informasi', '1641/SK/BAN-PT/Akred/S/V/2017', '2017', 'C', '2022-05-30'),
(3, 'S1 Teknik Informatika', '1134/SK/BAN-PT/Akred/S/IV/2017', '2017', 'C', '2022-04-18'),
(4, 'S1 Pendidikan Teknologi Informasi', '255/SK/BAN-PT/Akred/S/IV/2015', '2015', 'C', '2020-04-18');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_admin`
--
ALTER TABLE `tb_admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tb_biro`
--
ALTER TABLE `tb_biro`
  ADD PRIMARY KEY (`id_biro`);

--
-- Indexes for table `tb_lab`
--
ALTER TABLE `tb_lab`
  ADD PRIMARY KEY (`id_lab`);

--
-- Indexes for table `tb_prodi`
--
ALTER TABLE `tb_prodi`
  ADD PRIMARY KEY (`id_prodi`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_admin`
--
ALTER TABLE `tb_admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tb_biro`
--
ALTER TABLE `tb_biro`
  MODIFY `id_biro` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tb_lab`
--
ALTER TABLE `tb_lab`
  MODIFY `id_lab` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tb_prodi`
--
ALTER TABLE `tb_prodi`
  MODIFY `id_prodi` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

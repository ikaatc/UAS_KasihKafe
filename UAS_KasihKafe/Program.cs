using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace UAS_KasirKafe
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class Kasir dapat menjalankan tugas-tugas kasir, 
    /// seperti menampilkan main menu, menghitung harga barang, dan membuat nota</remarks>
    public class Kasir
    {
        /// <summary>
        /// class untuk menampilkan main menu, menerima inputan dari user, dan membuat nota untuk pelanggan
        /// </summary>
        /// <example>ketika di run akan menampilkan Menu Makanan dan Minuman</example>
        /// <code>Console.writeline() digunakan untuk menampilkan teks dan dapat menerima satu atau beberapa argumen teks yang ingin ditampilkan</code>
        public void KasirKafe()
        {
            // menampilkan nama kafe dan jalannya
            Console.WriteLine("+===================================+");
            Console.WriteLine("          Program Kasir Kafe         ");
            Console.WriteLine("             Cafe Cafean             ");
            Console.WriteLine("   Jalan Buntu, Malang, Jawa Timur   ");
            Console.WriteLine("+===================================+");
            Console.Write("\n");
            Console.WriteLine("   Silahkan Memilih Menu   ");
            Console.Write("\n");

            //Memilih Menu Makanan
            Console.WriteLine("=============Makanan=============");
            Console.Write("\n");
            Console.WriteLine("1. Fried Rice         : Rp. 23000");
            Console.WriteLine("2. Rice Bowl          : Rp. 20000");
            Console.WriteLine("3. Bakmi Goreng/Kuah  : Rp. 17000");
            Console.WriteLine("4. Katsu              : Rp. 25000");
            Console.WriteLine("5. Fried Chicken      : Rp. 17000");

            //Memilih Menu Minuman
            Console.WriteLine("=============Minuman=============");
            Console.WriteLine("1. Ice Tea            : Rp. 3000");
            Console.WriteLine("2. Lemon Tea          : Rp. 5000");
            Console.WriteLine("3. Greentea           : Rp. 10000");
            Console.WriteLine("4. Chocolate          : Rp. 7000");
            Console.WriteLine("5. Cappucino          : Rp. 12000");

            //Memilih Menu Snack
            Console.WriteLine("==============Snack==============");
            Console.WriteLine("1. French Fries       : Rp. 8000");
            Console.WriteLine("2. Truffle Fries      : Rp. 10000");
            Console.WriteLine("3. Onion Ring         : Rp. 10000");
            Console.WriteLine("4. Nugget             : Rp. 8000");
            Console.WriteLine("5. Omelette           : Rp. 10000");

            int Jumlah;
            //Looping dengan menginput jumlah barang menggunakan kondisi do while

            ///<example>ketika di run, user dapat menginput barang, jika jumlahnya kurang dari 100</example>
            
            ///<code>
            ///kondisi ini berarti 'Jumlah' kurang dari sama dengan 0 atau lebih besar dari 100, 
            ///maka program akan mengulang terus-menerus hingga nilai variable 'Jumlah' berada dalam rentang 1 hingga 100
            ///</code>          
            do
            {
                Console.Write("\nMasukkan Jumlah Barang : ");
                Jumlah = int.Parse(Console.ReadLine());
            } while (Jumlah <= 0 || Jumlah > 100);

            //Mendeklarasikan variabel data
            string[] Nama = new string[Jumlah]; 
            int[] Harga = new int[Jumlah];
            int Total = 0;
            int Bayar, Kembalian;

            //Menampilkan Masukkan Nama Pelanggan
            Console.WriteLine("============================");
            Console.Write("Masukkan Nama Pelanggan : ");

            //Deklarasi variabel data string
            string NamaPelanggan = Console.ReadLine();

            //Looping menggunakan kombinasi Array

            ///<example>ketika di run, user akan diperlihatkan menu dan dapat menginput barang dan harga yang diminta pelanggan</example>
            
            ///<code>
            ///kondisi dimana 'Jumlah' merupakan sebuah variabel
            ///setiap perulangan for akan menjalankan dua perulangan do-while yang berguna untuk memvalidasi input yang diberikan user.
            ///perulangan do-while pertama akan memastikan bahwa user memasukkan nama barang yang valid,yaitu memiliki panjang string diantara 1 sampai 19 karakter.
            ///perulangan do-while kedua akan memastikan bahwa pengguna memasukkan harga barang yang valid, yaitu antara 1000 sampai 1000000.
            /// </code>
            for (int i = 0; i < Jumlah; i++)
            {
                do
                {
                    //Menampilkan input nama barang
                    Console.WriteLine("==========================");
                    Console.Write("Masukkan Nama Barang Ke-" + (i + 1) + " : ");
                    Nama[i] = Console.ReadLine();
                }
                while (Nama[i].Length <= 0 || Nama[i].Length >= 20);

                do
                {
                    //Menampilkan input harga barang
                    Console.Write("Masukkan Harga Barang Ke-" + (i + 1) + " : ");
                    Harga[i] = int.Parse(Console.ReadLine());
                }
                while (Harga[i] <= 1000 || Harga[i] >= 1000000);
            }
            //Menampilkan nama barang dan harga barang yang telah dipilih
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine("Daftar Barang Yang Dipilih");
            Console.WriteLine("==========================");
            
            ///<example>ketika di run, akan menampilkan total harganya</example>
            
            ///<code>
            ///perulangan for digunakan untuk menampilkan nilai dari array "Nama" dan "Harga" menggunakan fungsi Console.WriteLine().
            ///dalam perulangan ini, nilai "i" akan bertambah 1 pada setiap iterasinya sampai nilai "i" mencapai "Jumlah".
            ///perulangan foreach digunakan untuk menghitung total nilai dari array "Harga".
            ///dalam perulangan ini, setiap nilai dari array "Harga" akan diakses melalui variabel "i", dan kemudian ditambahkan ke variabel "Total" menggunakan operator +=.
            /// </code>
            for (int i = 0; i < Jumlah; i++)
            {
                Console.WriteLine((i + 1) + ". " + Nama[i] + "  " + Harga[i]);
            }
            foreach (int i in Harga)
            {
                Total += i;
            }
            //Menampilkan total harga
            Console.WriteLine("===========================");
            Console.WriteLine("Total Harga : Rp" + Total);

            ///<example>
            ///Ketika di run, akan menampilkan list pesanan dan harga yang harus dibayarkan,
            ///lalu akan diminta untuk memasukkan uang yang telah dibayarkan,
            ///setelah itu akan menampilkan uang kembaliannya
            ///</example>           
            
            ///<code>
            ///Kode tersebut digunakan untuk meminta input dari pengguna mengenai jumlah uang yang dibayarkan untuk membeli barang dan menampilkan kembalian uang yang dibayarkan.
            ///Perulangan do-while akan terus diulang sampai uang yang dibayarkan cukup untuk membayar seluruh total belanjaan.
            /// </code>
            do
            {
                Console.Write("Masukkan Tunai : Rp");
                Bayar = int.Parse(Console.ReadLine());

                //Menampilkan kembalian dari uang yang dibayarkan
                Kembalian = Bayar - Total;

                //Kondisi jika input uang yang dibayarkan kurang
                if (Bayar < Total)
                {
                    Console.WriteLine("Maaf Uang Tidak Cukup !!");
                }
                //Kondisi jika input uang yang dibayarkan lebih
                else //menampilkan uang kembalian
                {
                    Console.WriteLine("Uang Kembalian Anda : Rp" + Kembalian);
                }
            } while (Bayar < Total);
            Console.Write("\n");
            Console.Write("Nama Pelanggan : " + NamaPelanggan.ToString());
            Console.Write("\n");

            //Menampilkan tanggal dan waktu transaksi

            ///<example>ketika di run, akan menampilkan nota pembayaran yang sudah dilakukan</example>
           
            ///<code>kode DateTime digunakan untuk menampilkan tanggal dan jam sekarang</code>
            Console.WriteLine("Tanggal Transaksi : " + DateTime.Today.ToString("dd-MM-yyyy"));
            Console.WriteLine("Jam Transaksi : " + DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine("===========================================");
            Console.WriteLine("Nama Kasir : Tania ");
            Console.WriteLine("Terima Kasih");
            Console.WriteLine("===========================================");

            Console.WriteLine();
            Console.Write("Tekan ENTER untuk keluar");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Kasir KasirC = new Kasir();
            KasirC.KasirKafe();
        }
    }
}
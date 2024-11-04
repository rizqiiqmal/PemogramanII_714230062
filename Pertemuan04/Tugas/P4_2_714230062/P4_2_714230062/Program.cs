using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230062
{
    using System;
    using System.Collections.Generic;

    public class Tiket
    {
        public int TiketID { get; set; }
        public string NamaFilm { get; set; }
        public DateTime WaktuTayang { get; set; }
        public string NamaPelanggan { get; set; }

        public Tiket(int tiketID, string namaFilm, DateTime waktuTayang, string namaPelanggan)
        {
            TiketID = tiketID;
            NamaFilm = namaFilm;
            WaktuTayang = waktuTayang;
            NamaPelanggan = namaPelanggan;
        }

        public void TampilkanInfoTiket()
        {
            Console.WriteLine($"ID Tiket: {TiketID}");
            Console.WriteLine($"Film: {NamaFilm}");
            Console.WriteLine($"Waktu Tayang: {WaktuTayang}");
            Console.WriteLine($"Pelanggan: {NamaPelanggan}");
            Console.WriteLine("-------------------------------");
        }
    }

    public class SistemPemesananTiket
    {
        private List<Tiket> tiketList = new List<Tiket>();
        private int penghitungTiket = 1;

        public void PesanTiket()
        {
            Console.Write("Masukkan Nama Film: ");
            string namaFilm = Console.ReadLine();

            Console.Write("Masukkan Waktu Tayang (yyyy-mm-dd hh:mm): ");
            DateTime waktuTayang = DateTime.Parse(Console.ReadLine());

            Console.Write("Masukkan Nama Pelanggan: ");
            string namaPelanggan = Console.ReadLine();

            Tiket tiketBaru = new Tiket(penghitungTiket++, namaFilm, waktuTayang, namaPelanggan);
            tiketList.Add(tiketBaru);
            Console.WriteLine("Tiket berhasil dipesan!\n");
        }

        public void TampilkanSemuaTiket()
        {
            Console.WriteLine("Semua Tiket:");
            foreach (var tiket in tiketList)
            {
                tiket.TampilkanInfoTiket();
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SistemPemesananTiket sistemPemesanan = new SistemPemesananTiket();
            int pilihan;

            do
            {
                Console.WriteLine("1. Pesan Tiket");
                Console.WriteLine("2. Tampilkan Semua Tiket");
                Console.WriteLine("3. Keluar");
                Console.Write("Masukkan pilihan Anda: ");
                pilihan = int.Parse(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        sistemPemesanan.PesanTiket();
                        break;
                    case 2:
                        sistemPemesanan.TampilkanSemuaTiket();
                        break;
                    case 3:
                        Console.WriteLine("Keluar dari sistem.");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid! Silakan coba lagi.");
                        break;
                }
            } while (pilihan != 3);
        }
    }
}
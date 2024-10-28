using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714230062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ulangi = true;

            while (ulangi)
            {
                Console.Clear();  // Membersihkan layar
                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");

                // Membaca pilihan user
                string pilihan = Console.ReadLine();

                // Mengambil tindakan sesuai pilihan
                switch (pilihan)
                {
                    case "1":
                        // Menghitung luas
                        HitungLuas();
                        break;
                    case "2":
                        // Menghitung keliling
                        HitungKeliling();
                        break;
                    case "3":
                        // Keluar dari program
                        ulangi = false;
                        Console.WriteLine("Program selesai. Terima kasih!");
                        break;
                    default:
                        // Pilihan tidak valid
                        Console.WriteLine("Menu tidak tersedia. Silakan pilih menu yang valid.");
                        break;
                }

                // Jika belum memilih keluar, tawarkan untuk mengulang
                if (ulangi)
                {
                    Console.Write("\nIngin mengulang kembali (Y/T)? ");
                    string jawab = Console.ReadLine().ToUpper();
                    ulangi = (jawab == "Y");
                }
            }

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }

        // Fungsi untuk menghitung luas persegi panjang
        static void HitungLuas()
        {
            Console.Write("Masukkan panjang (cm): ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar (cm): ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double luas = panjang * lebar;
            Console.WriteLine($"Luas Persegi Panjang: {luas} cm²");
        }

        // Fungsi untuk menghitung keliling persegi panjang
        static void HitungKeliling()
        {
            Console.Write("Masukkan panjang (cm): ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar (cm): ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double keliling = 2 * (panjang + lebar);
            Console.WriteLine($"Keliling Persegi Panjang: {keliling} cm");
        }
    }
}

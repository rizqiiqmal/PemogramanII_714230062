using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714230062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan angka pertama: ");
            double angkaPertama =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukan angka kedua: ");
            double angkaKedua = Convert.ToDouble(Console.ReadLine());

            double penjumlahan = angkaPertama + angkaKedua;
            double pengurangan = angkaPertama - angkaKedua;
            double perkalian = angkaPertama * angkaKedua;
            double pembagian = angkaPertama / angkaKedua;

            Console.WriteLine($"{angkaPertama} + {angkaKedua} = {penjumlahan}");
            Console.WriteLine($"{angkaPertama} - {angkaKedua} = {pengurangan}");
            Console.WriteLine($"{angkaPertama} * {angkaKedua} = {perkalian}");
            Console.WriteLine($"{angkaPertama} / {angkaKedua} = {pembagian}");

        }
    }
}

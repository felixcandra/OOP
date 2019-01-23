using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bangun2D panggil;
            string pil;
            double jarijari;
            double alas;
            double tinggi;
            double sisi;
            double panjang;
            double lebar;
            double pi = 3.14;
            double llingkar;
            double ltiga;
            double lsegi;
            double lpanjang;
            Console.WriteLine("--------PERHITUNGAN LUAS-------");
            Console.WriteLine("1. Lingkaran");
            Console.WriteLine("2. Segitiga");
            Console.WriteLine("3. Persegi");
            Console.WriteLine("4. Persegi Panjang");
            Console.WriteLine("================================");
            Console.WriteLine("Pilihan Ikam: ");
            pil = Console.ReadLine();
            Console.WriteLine("================================");
            switch (pil)
            {
                case "1":
                    Console.Write("Masukkan nilai jari-jari: ");
                    jarijari = Convert.ToDouble(Console.ReadLine());
                    panggil = new LuasLingkaran(jarijari);
                    panggil.CetakLuas("Lingkaran");
                    Console.Read();
                    break;
                case "2":
                    Console.Write("Masukkan nilai alas: ");
                    alas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan nilai tinggi: ");
                    tinggi = Convert.ToDouble(Console.ReadLine());
                    panggil = new LuasSegitiga(alas,tinggi);
                    panggil.CetakLuas("Segitiga");
                    Console.Read();
                    break;
                case "3":
                    Console.Write("Masukkan nilai sisi: ");
                    sisi = Convert.ToDouble(Console.ReadLine());
                    panggil = new LuasPersegi(sisi);
                    panggil.CetakLuas("Persegi");
                    Console.Read();
                    break;
                case "4":
                    Console.Write("Masukkan nilai panjang: ");
                    panjang = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan nilai lebar: ");
                    lebar = Convert.ToDouble(Console.ReadLine());
                    panggil = new LuasPersegiPanjang(panjang, lebar);
                    panggil.CetakLuas("Persegi Panjang");
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Your choice isnt found, try again see you later good bye");
                    Console.Read();
                    break;
            }
            Console.Read();
        }
    }
}

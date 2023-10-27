using System.Security.Cryptography;

namespace studycase25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENGHITUNG :\n" +
                "1. Luas Persegi \n" +
                "2. Luas Lingkaran\n" +
                "3. Volume Balok\n" +
                "4. Keluar Program\n" +
                "");

            Console.Write("pilih program (1/2/3/4) : ");
            string pilih = Console.ReadLine();

            if (pilih == "1")          
            {
                Console.Write("Masukkan ukuran sisi: ");
                double sisi = Convert.ToDouble(Console.ReadLine());

                double luasPersegi = sisi * sisi;
                Console.WriteLine("Luas Persegi adalah " + luasPersegi);
            }
            else if (pilih == "2") 
            {
                int r;
                double phi = 3.14;
                double luas;

                Console.Write("Masukan Jari Jari : ");
                r = Convert.ToInt32(Console.ReadLine());
                luas = phi * r * r;
                Console.WriteLine("Luas Lingkaran Adalah " + luas);
            }
            else if(pilih == "3")
            {
                int panjang, lebar, tinggi;
                double volume;

                Console.Write("Masukkan nilai panjang balok (m) = ");
                panjang = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan nilai lebar balok (m) = ");
                lebar = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan nilai tinggi balok (m) = ");
                tinggi = Convert.ToInt32(Console.ReadLine());
                volume = panjang * lebar * tinggi;
                Console.WriteLine("Maka volumenya = " + volume + "(m3)");
            }
            else if (pilih == "4")
            {
                Console.Write("kilik enter...");
                Console.ReadKey();
            }
            else
            {
                Console.Write("perintah yang anda masukan salah klik enter...");
                Console.ReadKey();
            }

        }
    }
}
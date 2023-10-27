using System.Runtime.CompilerServices;

namespace studycase27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string merk;
            string ukuran;

            Console.WriteLine("Program menentukan harga sebuah baju dari ukuran");

            Console.Write("Merk baju (H&M/Adidas/Uniqlo)     : ");
            merk = Console.ReadLine();

            // adidas
            if (merk == "ADIDAS" || merk == "Adidas" || merk == "adidas")
            {
                Console.Write("Masukan ukuran baju (S/M/L/XL): ");
                ukuran = Console.ReadLine();

                if (ukuran == "s" || ukuran == "S")
                {
                    Console.WriteLine("\nData Baju : ");
                    Console.WriteLine($"Merk baju {merk}");
                    Console.WriteLine($"Ukuran {ukuran}");
                    Console.WriteLine("Harga Rp120.000,00");

                }
                else if (ukuran == "M" || ukuran == "m")
                {

                    Console.WriteLine("\nData Baju : ");
                    Console.WriteLine($"Merk baju {merk}");
                    Console.WriteLine($"Ukuran {ukuran}");
                    Console.WriteLine("Harga Rp122.000,00\n");


                }
                else if (ukuran == "L" || ukuran == "l")
                {

                    Console.WriteLine("\nData Baju : ");
                    Console.WriteLine($"Merk baju {merk}");
                    Console.WriteLine($"Ukuran {ukuran}");
                    Console.WriteLine("Harga Rp125.000,00\n");


                }
                else if (ukuran == "XL" || ukuran == "xl")
                {

                    Console.WriteLine("\nData Baju : ");
                    Console.WriteLine($"Merk baju {merk}");
                    Console.WriteLine($"Ukuran {ukuran}");
                    Console.WriteLine("Harga Rp130.000,00\n");


                }
                else
                {
                    Console.WriteLine("Maaf perintah yang anda masukan salah");
                }
            }

            // uniqlo
            else if (merk == "Uniqlo" || merk == "UNIQLO" || merk == "unqilo")
            {
                Console.Write("Masukan ukuran baju (S/M/L/XL): ");
                ukuran = Console.ReadLine();

                if (ukuran == "s" || ukuran == "S")
                {

                    Console.WriteLine("\nData Baju : ");
                    Console.WriteLine($"Merk baju {merk}");
                    Console.WriteLine($"Ukuran {ukuran}");
                    Console.WriteLine("Harga Rp44.000,00\n");


                }
                else if (ukuran == "M" || ukuran == "m")
                {

                    Console.WriteLine("\nData Baju : ");
                    Console.WriteLine($"Merk baju {merk}");
                    Console.WriteLine($"Ukuran {ukuran}");
                    Console.WriteLine("Harga Rp49.000,00\n");

                }
                else if (ukuran == "L" || ukuran == "l")
                {

                    Console.WriteLine("\nData Baju : ");
                    Console.WriteLine($"Merk baju {merk}");
                    Console.WriteLine($"Ukuran {ukuran}");
                    Console.WriteLine("Harga Rp54.000,00\n");


                }
                else if (ukuran == "XL" || ukuran == "xl")
                {

                    Console.WriteLine("\nData Baju : ");
                    Console.WriteLine($"Merk baju {merk}");
                    Console.WriteLine($"Ukuran {ukuran}");
                    Console.WriteLine("Harga Rp64.000,00\n");


                }
                else
                {
                    Console.WriteLine("Maaf perintah yang anda masukan salah");
                }
            }

            else if (merk == "H&M" || merk == "h&m")
            {
                Console.Write("Masukan ukuran baju (S/M/L/XL): ");
                ukuran = Console.ReadLine();

                if (ukuran == "s" || ukuran == "S")
                {

                    Console.WriteLine("\nData Baju : ");
                    Console.WriteLine($"Merk baju {merk}");
                    Console.WriteLine($"Ukuran {ukuran}");
                    Console.WriteLine("Harga Rp49.000,00\n");


                }
                else if (ukuran == "M" || ukuran == "m")
                {

                    Console.WriteLine("\nData Baju : ");
                    Console.WriteLine($"Merk baju {merk}");
                    Console.WriteLine($"Ukuran {ukuran}");
                    Console.WriteLine("Harga Rp54.000,00\n");

                }
                else if (ukuran == "L" || ukuran == "l")
                {

                    Console.WriteLine("\nData Baju : ");
                    Console.WriteLine($"Merk baju {merk}");
                    Console.WriteLine($"Ukuran {ukuran}");
                    Console.WriteLine("Harga Rp59.000,00\n");


                }
                else if (ukuran == "XL" || ukuran == "xl")
                {

                    Console.WriteLine("\nData Baju : ");
                    Console.WriteLine($"Merk baju {merk}");
                    Console.WriteLine($"Ukuran {ukuran}");
                    Console.WriteLine("Harga Rp69.000,00\n");


                }
                else
                {
                    Console.WriteLine("Maaf perintah yang anda masukan salah");
                }
            }
            else
            {
                Console.Write("Maaf perintah yang anda masukan salah");
            }


            
        }

        }
 }
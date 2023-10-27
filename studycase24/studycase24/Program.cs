namespace studycase24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai mata pelajaran: ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            if (nilai >= 0 && nilai <= 50)
            {
                Console.WriteLine("Nilai termasuk dalam rentang 0 - 50");
            }
            else if (nilai >= 51 && nilai <= 73)
            {
                Console.WriteLine("Nilai termasuk dalam rentang 51 - 73");
            }
            else if (nilai >= 74 && nilai <= 90)
            {
                Console.WriteLine("Nilai termasuk dalam rentang 74 - 90");
            }
            else if (nilai >= 91 && nilai <= 100)
            {
                Console.WriteLine("Nilai termasuk dalam rentang 91 - 100");
            }
            else
            {
                Console.WriteLine("Nilai tidak valid, harus dalam rentang 0 - 100");
            }
        }
    }
}
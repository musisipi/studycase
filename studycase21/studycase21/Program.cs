namespace studycase21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Program menentukan golongan usia ");

            Console.Write("Masukkan usia Anda: ");
            int usia = Convert.ToInt32(Console.ReadLine());

            if (usia <= 5)
            {
                Console.WriteLine("Anda adalah seorang balita.");
            }
            else if (usia > 5 && usia <= 12)
            {
                Console.WriteLine("Anda adalah seorang anak-anak.");
            }
            else if (usia > 12 && usia <= 18)
            {
                Console.WriteLine("Anda adalah seorang remaja.");
            }
            else if (usia > 18)
            {
                Console.WriteLine("Anda adalah seorang dewasa.");
            }
            else
            {
                Console.WriteLine("Input tidak valid.");
            }

        }
    }
}
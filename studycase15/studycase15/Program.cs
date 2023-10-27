namespace studycase15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input penguna
            Console.Write("Masukan nilai tugas:");
            double tugas = Convert.ToDouble(Console.ReadLine());

            if (tugas >= 73)
                Console.WriteLine("Tuntas KKM");

            else
                Console.WriteLine("Remidial");

            Console.Write("Masukan nilai Kehadiran:");
            double kehadiran = Convert.ToDouble(Console.ReadLine());

            if (kehadiran >= 73)
                Console.WriteLine("Tuntas KKM");

            else
                Console.WriteLine("Remidial");

            Console.Write("Masukan nilai UAS:");
            double UAS = Convert.ToDouble(Console.ReadLine());

            if (UAS >= 73)
                Console.WriteLine("Tuntas KKM");

            else
                Console.WriteLine("Remidial");

            Console.Write("Masukan nilai UTS:");
            double UTS = Convert.ToDouble(Console.ReadLine());

            if (UTS >= 73)
                Console.WriteLine("Tuntas KKM");

            else
                Console.WriteLine("Remidial");

            Console.Write("Masukan nilai Kuis:");
            double kuis = Convert.ToDouble(Console.ReadLine());

            if (kuis >= 73)
                Console.WriteLine("Tuntas KKM");

            else
                Console.WriteLine("Remidial");


            {
                double a = tugas + 0.25;
                double b = kehadiran + 0.05;
                double c= UAS + 0.30;
                double d = UTS + 0.25;
                double e = kuis + 0.15;

                Console.WriteLine("===========================================HasilAkhir===========================================");
                Console.WriteLine("Nilai tugas:" + a);
                Console.WriteLine("Nilai Kehadridan:" + b);
                Console.WriteLine("Nilai UAS:" + c);
                Console.WriteLine("Nilai UTS:" + d);
                Console.WriteLine("Nilai Kuis:" + e);







            }

        }
    }
}
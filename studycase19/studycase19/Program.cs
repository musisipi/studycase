namespace studycase19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double perintah;
            

            Console.WriteLine("program traffictlight dengan menginputkan angka:" +
                "\n0 = MERAH\n" +
                "1 = KUNING\n" +
                "2 = HIJAU\n");

            Console.Write("Inputkan perintah : ");
            perintah = Convert.ToDouble(Console.ReadLine());

            if (perintah == 0)
            {
                Console.WriteLine("Berhentii");
            }
            else if (perintah == 1)
            {
                Console.WriteLine("Hati hati");
            }
            else if (perintah == 2)
            {
                Console.WriteLine("Jalan");
            }
            else
            {
                Console.WriteLine("Perintah yang anda masukan tidak di ketahui");
            }
        }
    }
}
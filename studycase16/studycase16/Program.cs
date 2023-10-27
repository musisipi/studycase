namespace studycase16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan Umur Anda:");
            int umur = Convert.ToInt32(Console.ReadLine());

            {
                if (umur >= 18)
                    Console.WriteLine("Silahakan anda boleh menonton film ini. Selamat menonton!");
                else
                    Console.WriteLine("Anda belum cukup umur untuk menonton film ini. Silahkan untuk menonton film yang sesuai dengan umur anda");
            }


        }
    }
}
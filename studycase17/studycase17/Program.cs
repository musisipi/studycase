namespace studycase17
{
    internal class Program
    {
        static void Main(string[] args)
        {                                                   
            Console.Write("Masukan bilangan: ");
            int bilangan = Convert.ToInt32(Console.ReadLine());

            if (bilangan % 2 == 0)
                Console.WriteLine("Bilangan adalah genap");


            else
                Console.WriteLine("Bilangan adalah ganjil");


        }
    }
}
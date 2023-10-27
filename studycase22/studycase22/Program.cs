namespace studycase22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan total belanjaan: ");
            decimal totalBelanja = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Masukkan jumlah barang yang dibeli: ");
            int jumlahBarang = Convert.ToInt32(Console.ReadLine());

            
            string hadiah = "Tidak mendapat hadiah";

            if (totalBelanja >= 500000 && jumlahBarang > 5)
            {
                hadiah = "Setrika";
            }
            else if (totalBelanja >= 100000 && jumlahBarang > 3)
            {
                hadiah = "Payung";
            }
            else if (totalBelanja >= 50000 && jumlahBarang > 2)
            {
                hadiah = "Pena";
            }

            
            Console.WriteLine("Hadiah yang didapat: " + hadiah);
        }
    }
}
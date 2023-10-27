namespace studycase23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program menentukan kriteria nilai");

            Console.Write("Masukkan nilai: ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            
            string kriteria;

            if (nilai >= 80)
            {
                kriteria = "A";
            }
            else if (nilai >= 70)
            {
                kriteria = "B";
            }
            else if (nilai >= 60)
            {
                kriteria = "C";
            }
            else if (nilai >= 50)
            {
                kriteria = "D";
            }
            else
            {
                kriteria = "E";
            }

            
            Console.WriteLine("Kriteria nilai: " + kriteria);
        }
    }
}
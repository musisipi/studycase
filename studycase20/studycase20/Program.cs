namespace studycase20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string infut;
            Console.WriteLine("Program mengetahui karakter/kepribadian dari golongan darah");

            Console.Write("Inputkan golongan darah (O/B/A/AB) : ");
            infut = Console.ReadLine();

            if (infut == "o" || infut == "O")
            {
                Console.WriteLine("\nGolongan darah O:\n Ambisius, atletis, kuat, dan percaya diri. Pemimpin alami.");
            }
            else if (infut == "b" || infut == "B")
            {
                Console.WriteLine("\nGolongan darah B:\n Kreatif, fleksibel, individualis, dan optimis. Sifat terburuk: Tidak stabil, egois, dan tidak konsisten.");
            }
            else if (infut == "a" || infut == "A")
            {
                Console.WriteLine("\nGolongan darah A:\n Konservatif, tertutup, pendiam, artistik, sabar dan tepat waktu, dapat dipercaya, Perfeksionis. Sifat terburuk: Obsesif, keras kepala, sadar diri dan tegang..");
            }
            else if (infut == "ab" || infut == "AB")
            {
                Console.WriteLine("\nGolongan darah AB:\n Ramah, kreatif, dan mudah bergaul. Sifat terburuk: Tidak stabil, sulit membuat keputusan, dan tidak konsisten.");
            }
            else
            {
                Console.WriteLine("\nPerintah yang anda masukan salah");
            }
        }
    }
}
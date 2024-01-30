using System;

namespace Pinta_ala_laskuri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                /*Annetaan ohjelman vaihtoehdot*/
                Console.WriteLine("Valitse toiminto:");
                Console.WriteLine("1. Ympyrän pinta-ala");
                Console.WriteLine("2. Nelikulmion pinta-ala");
                Console.WriteLine("3. Kolmion pinta-ala");
                Console.WriteLine("L. Lopetus");

                string valinta = Console.ReadLine();

                switch (valinta)
                {
                    /*Lasketaan ympyrän pinta-ala*/
                    case "1":
                        LaskeYmpyranPintaAla();
                        break;
                    /*Lasketaan nelikulmion pinta-ala*/

                    case "2":
                        LaskeNelikulmionPintaAla();
                        break;
                    /*Lasketaan kolmio pinta-ala*/

                    case "3":
                        LaskeKolmionPintaAla();
                        break;
                    /*Mahdollisuus  lopettamiseen*/

                    case "L":
                    case "l":
                        Console.WriteLine("Ohjelma sulkeutuu.");
                        return;
                        /*Lisätään ehto jos valitaan väärin.*/
                    default:
                        Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                        break;
                }

                Console.WriteLine();
            }
        }
        /*Lasketaan ympyrän pinta-ala*/

        static void LaskeYmpyranPintaAla()
        {
            Console.Write("Anna ympyrän säde: ");
            double sade = double.Parse(Console.ReadLine());

            double pintaAla = Math.PI * Math.Pow(sade, 2);
            Console.WriteLine($"Ympyrän pinta-ala on {pintaAla:F2}");
        }
        /*Lasketaan nelikulmion pinta-ala*/

        static void LaskeNelikulmionPintaAla()
        {
            Console.Write("Anna nelikulmion leveys: ");
            double leveys = double.Parse(Console.ReadLine());

            Console.Write("Anna nelikulmion korkeus: ");
            double korkeus = double.Parse(Console.ReadLine());

            double pintaAla = leveys * korkeus;
            Console.WriteLine($"Nelikulmion pinta-ala on {pintaAla:F2}");
        }
        /*Lasketaan kolmio pinta-ala*/

        static void LaskeKolmionPintaAla()
        {
            Console.Write("Anna kolmion kanta: ");
            double kanta = double.Parse(Console.ReadLine());

            Console.Write("Anna kolmion korkeus: ");
            double korkeus = double.Parse(Console.ReadLine());

            double pintaAla = 0.5 * kanta * korkeus;
        /*Formatoidaan eri tavalla vaihtelun vuoksi.*/
            Console.WriteLine("Kolmion pinta-ala on " + pintaAla.ToString("F2"));
        }
    }
}

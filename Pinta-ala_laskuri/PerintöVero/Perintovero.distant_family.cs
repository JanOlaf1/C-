using System;

namespace Perintovero.distant_family
{
    internal class DistantFamily
    {
        public static void DistantFamilyToiminnallisuus()
        {
            Console.WriteLine("Anna perinnön arvo: ");
            double perinnonArvo = double.Parse(Console.ReadLine());

            double vero = 0;

            if (perinnonArvo <= 40000)
            {
                vero = 100 + (perinnonArvo - 20000) * 0.19;
            }
            else if (perinnonArvo <= 60000)
            {
                vero = 3900 + (perinnonArvo - 40000) * 0.25;
            }
            else if (perinnonArvo <= 200000)
            {
                vero = 8900 + (perinnonArvo - 60000) * 0.29;
            }
            else if (perinnonArvo <= 1000000)
            {
                vero = 49500 + (perinnonArvo - 200000) * 0.31;
            }
            else
            {
                vero = 297500 + (perinnonArvo - 1000000) * 0.33;
            }

            Console.WriteLine($"Perintöveroa maksettava: {vero} euroa");
        }
    }
}

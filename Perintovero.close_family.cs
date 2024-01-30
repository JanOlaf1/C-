using System;

namespace Perintovero.close_family
{
    internal class Perintovero
    {
        public static void LaskePerintoVero()
        {
            Console.WriteLine("Anna perinnön arvo: ");
            double perinnonArvo = double.Parse(Console.ReadLine());

            double vero = 0;

            if (perinnonArvo <= 20000)
            {
                vero = 0;
            }
            else if (perinnonArvo <= 40000)
            {
                vero = 100 + (perinnonArvo - 20000) * 0.07;
            }
            else if (perinnonArvo <= 60000)
            {
                vero = 1500 + (perinnonArvo - 40000) * 0.10;
            }
            else if (perinnonArvo <= 200000)
            {
                vero = 3500 + (perinnonArvo - 60000) * 0.13;
            }
            else if (perinnonArvo <= 1000000)
            {
                vero = 21700 + (perinnonArvo - 200000) * 0.16;
            }
            else
            {
                vero = 149700 + (perinnonArvo - 1000000) * 0.19;
            }

            Console.WriteLine($"Perintöveroa maksettava: {vero} euroa");
        }
    }
}

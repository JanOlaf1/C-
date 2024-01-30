using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perintovero.information;
using Perintovero.distant_family;
using Perintovero.close_family;

namespace Perintovero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                /*2 eri luokkaa mm. lähimmät sukulaiset ja muut kuin lähimmät sukulaiset*/
                Console.WriteLine("Valitse veroluokkasi");
                Console.WriteLine("1. Lähimmäiset sukulaiset");
                Console.WriteLine("2. Muut kuin lähimmät sukulaiset");
                Console.WriteLine("3. Lisätietoaa vaihtoehdoista.");
                Console.WriteLine("L. Lopeta ohjelma");
                string valinta = Console.ReadLine();
                switch (valinta)
                {
                    case "1":
                        Perintovero.close_family.Perintovero.LaskePerintoVero();
                        break;
                    case "2":
                        Perintovero.distant_family.DistantFamily.DistantFamilyToiminnallisuus();
                        break;
                    case "3":
                        Information information = new Information();
                        information.InformationToiminnallisuus();
                        break;
                    case "L":
                    case "l":
                        Console.WriteLine("Ohjelma sulkeutuu.");
                        return;
                    /*Väärä valinta*/
                    default:
                        Console.WriteLine("Virheellinen valinta. Yritä uudelleen (L. Lopettaa ohjelman");
                        break;
                        
                }
                Console.WriteLine();


            }
        }
    }
}

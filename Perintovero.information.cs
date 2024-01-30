using System;

namespace Perintovero.information
{
    internal class Information
    {
        public void InformationToiminnallisuus()
        {
            while (true)
            {
                Console.WriteLine("Valitse toiminto: ");
                Console.WriteLine("1. Lähimmät sukulaiset");
                Console.WriteLine("2. Muut kuin lähimmät sukulaiset");
                Console.WriteLine("T. Poistu");

                string valinta = Console.ReadLine();

                switch (valinta.ToUpper())
                {
                    case "1":
                        Console.WriteLine("Kuulut 1. Veroluokkaan jos olet: ");
                        Console.WriteLine("- Aviopuoliso tai rekisteröidyn parisuhteen osapuoli");
                        Console.WriteLine("- Suoraan alenevassa tai ylenevässä polvessa oleva perillinen (lapsi, lapsenlapsi, vanhempi, isovanhempi)");
                        Console.WriteLine("- Aviopuolison tai entisen aviopuolison suoraan alenevassa polvessa oleva perillinen");
                        Console.WriteLine("- Kihlakumppani, joka saa avustuksen (perintökaaren 8 luvun 2 §)");
                        Console.WriteLine("- Elänyt perinnönjättäjän kanssa avoliitossa ja täyttää toisen seuraavista kohdista:");
                        Console.WriteLine("  Aiemmin avioliitossa perinnönjättäjän kanssa.");
                        Console.WriteLine("  On tai on ollut yhteinen lapsi perinnönjättäjän kanssa.");
                        Console.WriteLine("  Adoptiolapset ja -vanhemmat ovat verotuksellisesti samassa asemassa biologisten sukulaisten kanssa.");
                        break;
                    case "2":
                        Console.WriteLine("");
                        Console.WriteLine("veroluokkaan kuuluvat muut kuin lähimmät sukulaiset sekä suvun ja perheen ulkopuoliset henkilöt.");
                        Console.WriteLine("Mikäli et vieläkään ole varma, ota yhteyttä Verotoimistoon.");
                        break;
                    case "T":
                        Console.WriteLine("Takaisin valikkoon.");
                        return;
                    default:
                        Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                        break;
                }
            }
        }
    }
}

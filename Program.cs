namespace Zadanie_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ahoj, som tvoj Asistent, máš na výber príkazy 'sum' (sčítanie), 'odm'(odmocnina), 'find' (podreťazec), 'help'(vypise prikazy) alebo 'exit'(ukoncenie).");
        string prikaz = Console.ReadLine();
        
        if (prikaz.ToLower() == "sum")
        {
            Scitavanie_cisel();
        }
        
        //tu je odmocnina
         else if (prikaz.ToLower() == "odm")
         {
             Odmocnenie_cisla();
         }
        
        //find prikaz
        else if (prikaz.ToLower() == "find")
        {
            Hladanie_slova();
        }
        //prikaz help
        else if (prikaz.ToLower() == "help")
        {
            Pomahanie();
        } 
        //prikaz exit
        else if (prikaz.ToLower() == "exit")
        {
            Ukoncenie();
        }
        //prikaz rect
        else if (prikaz.ToLower() == "rect")
        {
            Meranie_obdlznika();
        }
        else
        {
                Console.WriteLine("Vypísal si nesprávny údaj");
        }

        //funkcia scitavanie
        void Scitavanie_cisel()
        {
            Console.WriteLine("Zadaj prvé číslo");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj druhé číslo");
            int b = int.Parse(Console.ReadLine());
            int vysledok = a + b;
            Console.WriteLine("Tvoj výsledok je: " + vysledok);
        }
        //funkcia odmocnenie
        void Odmocnenie_cisla()
        {
            Console.WriteLine("Zadaj číslo, ktoré chces odmocniť");
            int cislo = int.Parse(Console.ReadLine());
                
            if (cislo < 0)
            {
                Console.WriteLine("Nemožeš dať príkaz 'odmocnina' na záporné čísla ");
            }
            else
            {
                Console.WriteLine(Math.Sqrt(cislo));
            }
        }
        //funkcia hladanie slova
        void Hladanie_slova()
        {
            Console.WriteLine("Zadaj vetu.");
            string veta = Console.ReadLine();
            Console.WriteLine("Zadaj slovo ktoré chceš hľadať");
            string slovo = Console.ReadLine();
            int pozicia = veta.IndexOf(slovo);
            if ( pozicia != -1)
            {
                Console.WriteLine("Tvoje slovo ktoré si chcel nájsť sa nachádza:" + slovo);
            }
            else
            {
                Console.WriteLine("Tvoje slovo ktoré si chcel nájsť sa nenachádza");
            }
            
        }
        //funkcia help
        void Pomahanie()
        {
            Console.WriteLine("Príkaz 'sum' sčítava 2 čísla. Príkaz 'odm' z čísla spravý odmocninu. Príkaz 'find' hľadá vo vete slovo, ktoré mu zadáš (podreťazec). Príkaz 'help' vypíše všetky prikazy a vysvetlí, čo robia. Príkaz 'exit' ukončí program.");
        }
        
        
        //funkcia Meranie_obdlznika
        void Meranie_obdlznika()
        {
            Console.WriteLine("Ideme zmerať tvoj obdlžnik");
            Console.WriteLine("Zadaj velkost PRVEJ strany");
            double strana1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj velkost DRUHEJ strany");
            double strana2 = double.Parse(Console.ReadLine());

            if ((strana1 == strana2) || (strana1 < 0) || (strana2 < 0)) 
            {
                Console.WriteLine("Zadal si nesprávne údaje pre obdlznik");
            }
            else
            {// -----DALSIE PRIKAZY (area, perimeter, diagonal,exit)------
                Console.WriteLine("Máme obdĺžnik s rozmermi "+strana1+ " x "+strana2+" ,čo chceš vypočítať?: 'area' (obsah - S), 'perimeter' (obvod - O), 'diagonal' (uhlopriečka), 'exit' (ukončenie)" );
                string prikaz2 = Console.ReadLine();
                
                //prikaz area
                if (prikaz2.ToLower() == "area")
                {
                    Meranie_obsahu();
                }
                //prikaz perimeter
                else if (prikaz2.ToLower() == "perimeter")
                {
                    Meranie_obvodu();
                }
                //prikaz diagonal
                else if (prikaz2.ToLower() == "diagonal")
                {
                    Meranie_uhloprecka();
                }
                //prikaz exit
                else if (prikaz2.ToLower() == "exit")
                {
                    Ukoncenie();
                }
                else
                {
                    Console.WriteLine("Vypísal si nesprávny údaj");
                }
            }
            
            //funkcia area
            void Meranie_obsahu()
            {
                double vysledok_area = strana1 * strana2;
                Console.WriteLine("Obsah pre tento obdlznik je "+vysledok_area);
                
                // DALSIE PRIKAZY (area, perimeter, diagonal)
                Console.WriteLine("Máme obdĺžnik s rozmermi "+strana1+ " x "+strana2+" ,čo chceš vypočítať?: 'area' (obsah - S), 'perimeter' (obvod - O), 'diagonal' (uhlopriečka), 'exit' (ukončenie)" );
                string prikaz2 = Console.ReadLine();
                
                //prikaz area
                if (prikaz2.ToLower() == "area")
                {
                    Meranie_obsahu();
                }
                //prikaz perimeter
                else if (prikaz2.ToLower() == "perimeter")
                {
                    Meranie_obvodu();
                }
                //prikaz diagonal
                else if (prikaz2.ToLower() == "diagonal")
                {
                    Meranie_uhloprecka();
                }
                //prikaz exit
                else if (prikaz2.ToLower() == "exit")
                {
                    Ukoncenie();
                }
                else
                {
                    Console.WriteLine("Vypísal si nesprávny údaj");
                }
                
            }
            //funkcia perimeter
            void Meranie_obvodu()
            {
                double vysledok_perimeter = (strana1*2) + (strana2*2);
                Console.WriteLine("Obvod pre tento obdlznik je "+vysledok_perimeter);
                
                // DALSIE PRIKAZY (area, perimeter, diagonal)
                Console.WriteLine("Máme obdĺžnik s rozmermi "+strana1+ " x "+strana2+" ,čo chceš vypočítať?: 'area' (obsah - S), 'perimeter' (obvod - O), 'diagonal' (uhlopriečka), 'exit' (ukončenie)" );
                string prikaz2 = Console.ReadLine();
                
                //prikaz area
                if (prikaz2.ToLower() == "area")
                {
                    Meranie_obsahu();
                }
                //prikaz perimeter
                else if (prikaz2.ToLower() == "perimeter")
                {
                    Meranie_obvodu();
                }
                //prikaz diagonal
                else if (prikaz2.ToLower() == "diagonal")
                {
                    Meranie_uhloprecka();
                }
                //prikaz exit
                else if (prikaz2.ToLower() == "exit")
                {
                    Ukoncenie();
                }
                else
                {
                    Console.WriteLine("Vypísal si nesprávny údaj");
                }
                
            }
            
            
            //funkcia diagonal
            void Meranie_uhloprecka()
            {
                double vysledok_perimeter = Math.Sqrt((Math.Pow(strana1,2)) + (Math.Pow(strana2,2)));
                Console.WriteLine("Obsah pre tento obdlznik je "+vysledok_perimeter);
                
                // DALSIE PRIKAZY (area, perimeter, diagonal)
                Console.WriteLine("Máme obdĺžnik s rozmermi "+strana1+ " x "+strana2+" ,čo chceš vypočítať?: 'area' (obsah - S), 'perimeter' (obvod - O), 'diagonal' (uhlopriečka), 'exit' (ukončenie)" );
                string prikaz2 = Console.ReadLine();
                
                //prikaz area
                if (prikaz2.ToLower() == "area")
                {
                    Meranie_obsahu();
                }
                //prikaz perimeter
                else if (prikaz2.ToLower() == "perimeter")
                {
                    Meranie_obvodu();
                }
                //prikaz diagonal
                else if (prikaz2.ToLower() == "diagonal")
                {
                    Meranie_uhloprecka();
                }
                //prikaz exit
                else if (prikaz2.ToLower() == "exit")
                {
                    Ukoncenie();
                }
                else
                {
                    Console.WriteLine("Vypísal si nesprávny údaj");
                }
                
            }
            //funkcia exit
            void Ukoncenie()
            {
                Console.WriteLine("Zadal si príkaz exit - ukončuješ program -- Rád pomôžem aj nabudúce:)");
            }
        }
        //funkcia exit
        void Ukoncenie()
        {
            Console.WriteLine("Zadal si príkaz exit - ukončuješ program -- Rád pomôžem aj nabudúce:)");
            
        }

    }
}
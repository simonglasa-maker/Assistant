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
        //prikaz array
        else if (prikaz.ToLower() == "array")
        {
            Praca_s_polom();
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
        //funkcia hladanie slova------------------------------------------------------------------------------------
        void Hladanie_slova()
        {
            Console.WriteLine("Zadaj vetu.");
            string veta = Console.ReadLine();
            Console.WriteLine("Zadaj slovo ktoré chceš hľadať");
            string slovo = Console.ReadLine();
            int pozicia = veta.IndexOf(slovo);
            if ( pozicia != -1)
            {
                Console.WriteLine("Tvoje slovo ktoré si chcel nájsť sa nachádza vo vete na pozícií " + pozicia);
            }
            else
            {
                Console.WriteLine("Tvoje slovo ktoré si chcel nájsť sa nenachádza vo vete");
            }
            
        }
        //funkcia help
        void Pomahanie()
        {
            Console.WriteLine("Príkaz 'sum' sčítava 2 čísla. Príkaz 'odm' z čísla spravý odmocninu. Príkaz 'find' hľadá vo vete slovo, ktoré mu zadáš (podreťazec). Príkaz 'help' vypíše všetky prikazy a vysvetlí, čo robia. Príkaz 'exit' ukončí program.");
        }
        
        
        //funkcia Meranie_obdlznika-----------------------------------------------------------------------------
        void Meranie_obdlznika()
        {
            Console.WriteLine("Ideme zmerať tvoj obdlžnik");
            Console.WriteLine("Zadaj velkost PRVEJ strany");
            double strana1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj velkost DRUHEJ strany");
            double strana2 = double.Parse(Console.ReadLine());

            if ((strana1 == strana2) || (strana1 <= 0) || (strana2 <= 0) ) 
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
        //funkcia Praca_s_polom-----------------------------------------------------------------------------
        void Praca_s_polom()
        {
            Console.WriteLine("Príkaz Array, zadaj pole čísiel a každé číslo oddeľ medzerou.");
            string zadane_cisla = Console.ReadLine();
            int pocetCisel = 1;
            for (int i = 0; i < zadane_cisla.Length; i++) //spocitam kolko cisel tam je
            {
                if (zadane_cisla[i] == ' ')
                {
                    pocetCisel++;
                }
            }

            // vytvorenie pola
            int[] cisla = new int[pocetCisel];
            string slovo = "";
            int index = 0;

            for (int i = 0; i < zadane_cisla.Length; i++)
            {
                if (zadane_cisla[i] != ' ')
                {
                    slovo += zadane_cisla[i]; // spajam cisla / cifry
                }
                else
                {
                    if (slovo != "")
                    {
                        cisla[index] = int.Parse(slovo); // ulozim poskladane cislo
                        index++;
                        slovo = ""; // uvolnenie priestoru pre spajanie dalsich cisliel
                    }
                }
            }
            if (slovo != "")
            {
                cisla[index] = int.Parse(slovo); //posledne cislo sa ulozi
            }
            
            //while aby sa opakovalo stale dookola
            while (true)
            {
                Console.WriteLine("Čo si praješ robiť s týmto poľom? ");
                Console.WriteLine("Príkaz 'find' - nájde zadanú hodnotu v poli a napíše na akej pozícii sa nachádza" +
                                      "Príkaz 'min' - nájde minimálnu hodnotu v poli" +
                                      "Príkaz 'sort' - zoradí pole od najmenšej hodnoty, po najväčšiu" +
                                      "Príkaz 'exit' - ukonci program");
                string prikaz3 = Console.ReadLine();
                    
                //prikaz find cisla v poli
                if (prikaz3.ToLower() == "find")
                {
                    Vyhladavanie_v_poli(cisla);
                }
                    
                //prikaz minimalna hodnota
                else if (prikaz3.ToLower() == "min")
                {
                    Urcenie_min_hodnoty(cisla);
                }
                    
                //prikaz sorting
                else if (prikaz3.ToLower() == "sort")
                {
                    Zoradenie_Pola(cisla);
                }
                    
                //prikaz exit
                else if (prikaz3.ToLower() == "exit")
                {
                    Ukoncenie();
                    break;
                }
                else 
                {
                    Console.WriteLine("Zadal si nesprávny príkaz.");
                } 
            }
            
            

            //funkcia hladanie cisla
            void Vyhladavanie_v_poli(int[] cisla)
            {
                Console.WriteLine("Zadaj číslo, ktoré chceš nájsť.");
                int hladane_cislo = int.Parse(Console.ReadLine());
                
                int pozicia = -1;

                for (int i = 0; i < cisla.Length; i++)
                {
                    if(cisla[i] == hladane_cislo)
                    {
                        pozicia = i + 1;
                        break;
                    }
                }

                if (pozicia != -1)
                {
                        Console.WriteLine("Tvoje číslo " + hladane_cislo +
                                          ", ktoré si chcel nájsť, sa nachádza v poli na pozícií " + pozicia);
                }
                else
                {
                        Console.WriteLine("Tvoje čislo " + hladane_cislo +
                                          ", ktoré si chcel nájsť, sa nenachádza v poli.");
                }
            }
            //funkcia minimalna hodnota
            void Urcenie_min_hodnoty(int[] cisla)
            {
                int najmensie = cisla[0];
                
                for (int i = 0; i < cisla.Length; i++)
                {
                    if (cisla[i] < najmensie)
                    {
                        najmensie = cisla[i];
                    }
                }
                Console.WriteLine("Najmensie cislo je: " + najmensie );
            }
            //funkcia minimalna hodnota
            void Zoradenie_Pola(int[] cisla)
            {
                Array.Sort(cisla);
                Console.Write("Pole je zoradené. Teraz to vyzerá takto: ");
                for (int i = 0; i < cisla.Length; i++)
                {
                    Console.Write(cisla[i]+ " ");
                }

                Console.WriteLine();
            }
        }
        

    }

}
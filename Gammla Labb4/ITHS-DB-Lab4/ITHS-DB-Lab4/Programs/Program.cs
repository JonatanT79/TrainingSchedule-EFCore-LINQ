using ITHS_DB_Lab4.DataCon;
using ITHS_DB_Lab4.Models;
using ITHS_DB_Lab4.Programs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ITHS_DB_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInfo gt = new GetInfo();
            Värden v = new Värden();

            v.AddvalueA();
            v.AddvalueT();
            v.AddvalueÖ();
            v.AddvalueU();
            v.AddvalueJ();
            v.AddvalueFP();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Värderna har blivit insatta i databasen!");
            Console.WriteLine("Tryck på valfri tangent för att hämta info på uppgifterna...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Alla användare och deras träningspass:");
            Console.ResetColor();
            Console.WriteLine("");
            gt.HämtaInfo1();
            Console.WriteLine("Tryck på valfri tangent för att forsätta...");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Alla utrustningar som inte används:");
            Console.ResetColor();
            Console.WriteLine("");
            gt.HämtaInfo2();
            Console.WriteLine("Tryck på valfri tangent för att forsätta...");
            Console.ReadKey();
            Console.WriteLine("");
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hur många gånger varje utrustning använts. De som inte använts står det 0 på");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("Hantlar används " + v.count1 + " gånger");
            Console.WriteLine("Skivstång används " + v.count2 + " gånger");
            Console.WriteLine("Maskin används " + v.count3 + " gånger");
            Console.WriteLine("Skor används " + v.count4 + " gånger");
            Console.WriteLine("Löpband används " + v.count5 + " gånger");
            Console.WriteLine("Spinningscykel används " + v.count6 + " gånger");
            Console.WriteLine("");
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Vilken övning som har varit jobbigast. Skriv ut information om användaren, träningspasset, övningen och hur jobbig övningen var.");
            Console.WriteLine("Om det finns flera övningar som varit lika jobbiga ska alla dessa skrivas ut.");
            Console.ResetColor();
            Console.WriteLine("");
            gt.HämtaInfo4();
        }
    }
    class GetInfo
    {
        public void HämtaInfo1()
        {
            using (LabbContext con = new LabbContext())
            {
                int i = 1;
                var query1 = from atp in con.FullständigtPassT
                             join atp2 in con.AnvändareT on EF.Property<int>(atp, "AnvändareID") equals atp2.ID
                             join atp3 in con.TräningspassT on EF.Property<int>(atp, "TräningsPassID") equals atp3.ID
                             join atp4 in con.UtrustT on EF.Property<int>(atp, "UtrustningID") equals atp4.ID
                             select new
                             {
                                 FN = atp2.Förnamn,
                                 EN = atp2.Efternamn,
                                 PN = atp3.Passnamn,
                                 BE = atp3.Beskrivning,
                                 TI = atp3.Tid,
                                 TY = atp3.Typ,
                                 UT = atp4.Utrustning
                             };
                
                foreach (var item in query1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nr: Förnamn:   Efternamn:    Passnamn:      Beskrivning: ");
                    Console.ResetColor();
                    Console.WriteLine(i+ ". " + item.FN + "       " + item.EN + "       " + item.PN + "   " + item.BE);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tid:      Typ:      Utrustning:");
                    Console.ResetColor();
                    Console.WriteLine(item.TI + "     " + item.TY + "     " + item.UT);
                    Linedivide();
                    i++;
                }
            }
        }
        public void HämtaInfo2()
        {
            using (LabbContext con = new LabbContext())
            {
                var query2 = from ut in con.UtrustT
                             where ut.ID == 5 || ut.ID == 6
                             select ut;

                foreach (var item2 in query2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Utrustning:");
                    Console.ResetColor();
                    Console.WriteLine(item2.Utrustning);
                    Linedivide();
                }
            }
        }
        public void HämtaInfo4()
        {
            using (LabbContext con = new LabbContext())
            {
                var query4 = from sist in con.FullständigtPassT
                             join sist2 in con.AnvändareT on EF.Property<int>(sist, "AnvändareID") equals sist2.ID
                             join sist3 in con.TräningspassT on EF.Property<int>(sist, "TräningsPassID") equals sist3.ID
                             join sist4 in con.ÖvningarT on EF.Property<int>(sist, "ÖvningarID") equals sist4.ID
                             join sist5 in con.JobbinivåT on EF.Property<int>(sist, "JobbighetsnivåID") equals sist5.ID
                             join sist6 in con.UtrustT on EF.Property<int>(sist, "UtrustningID") equals sist6.ID
                             where sist5.JobbighetsNivå >=9
                             select new
                             {
                                 FN = sist2.Förnamn,
                                 EN = sist2.Efternamn,
                                 EM = sist2.Email,
                                 PN = sist3.Passnamn,
                                 BE = sist3.Beskrivning,
                                 TI = sist3.Tid,
                                 TY = sist3.Typ,
                                 ÖV = sist4.Övningensnamn,
                                 RE = sist4.Repetitioner,
                                 SE = sist4.Sets,
                                 UT = sist6.Utrustning,
                                 JO = sist5.JobbighetsNivå
                             };

                foreach (var item4 in query4)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Förnamn:   EFternamn:  Email:  Passnamn:  beskrivning:                                              Tid:  Typ:");
                    Console.ResetColor();
                    Console.WriteLine(item4.FN + " "  + item4.EN + " " + item4.EM + " " + item4.PN+ " " + item4.BE + " " + item4.TI + " " + item4.TY);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Övningensnamn:  Repetition:  Sets:  Utrustning:  Jobbighetsnivå:");
                    Console.ResetColor();
                    Console.WriteLine(item4.ÖV + " " + item4.RE + " " + item4.SE + " " + item4.UT + " " + item4.JO);
                    Linedivide();
                }
            }
        }
        public void Linedivide()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }
    }
}

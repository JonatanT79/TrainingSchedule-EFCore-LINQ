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
            v.AddvalueTU();
            v.AddvalueÖD();

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
            gt.HämtaInfo3();
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
                var query1 = from atp in con.AnvändareT
                             join atp2 in con.TräningspassT on atp.ID equals EF.Property<int>(atp2, "AnvändareID")
                             join atp3 in con.ÖvningDetalj on atp2.ID equals EF.Property<int>(atp3, "TräningsPassID")
                             join atp4 in con.ÖvningarT on EF.Property<int>(atp3, "ÖvningarID") equals atp4.ID
                             orderby atp.Förnamn
                             select new
                             {
                                 FN = atp.Förnamn,
                                 EN = atp.Efternamn,
                                 PN = atp2.Passnamn,
                                 BE = atp2.Beskrivning,
                                 TI = atp2.Tid,
                                 TY = atp2.Typ,
                                 ÖN = atp4.Övningensnamn,
                                 SE = atp4.Sets,
                                 RE = atp4.Repetitioner,
                                 JO = atp3.JobbighetsNivå
                             };
                //  ---------------------------------------------  Query för Utrustning ---------------------------------------------

                var query1_2 = from atp in con.AnvändareT
                               join atp2 in con.TräningspassT on atp.ID equals EF.Property<int>(atp2, "AnvändareID")
                               join atp3 in con.TräningsUtrustningT on atp2.ID equals EF.Property<int>(atp3, "TräningsPassID")
                               join atp4 in con.UtrustT on EF.Property<int>(atp3, "UtrustningID") equals atp4.ID
                               orderby atp.Förnamn
                               select new
                               {
                                   FN = atp.Förnamn,
                                   EN = atp.Efternamn,
                                   PN = atp2.Passnamn,
                                   BE = atp2.Beskrivning,
                                   TI = atp2.Tid,
                                   TY = atp2.Typ,
                                   UT = atp4.Utrustning
                               };

                foreach (var item in query1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nr: Förnamn:   Efternamn:    Passnamn:      Beskrivning: ");
                    Console.ResetColor();
                    Console.WriteLine(i + ". " + item.FN + "       " + item.EN + "       " + item.PN + "   " + item.BE);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tid:      Typ:      Övningensnamn:    Sets:    Repetitioner:     JobbighetsNivå:");
                    Console.ResetColor();
                    Console.WriteLine(item.TI + "     " + item.TY + "     " + item.ÖN + "     " + item.SE + "     " + item.RE + "     " + item.JO);
                    Linedivide();
                    i++;
                }
                i = 1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tryck på valfri knapp för att visa vilka utrustningar som användes i träningspasset:");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                foreach (var item_2 in query1_2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Nr: Förnamn:   Efternamn:    Passnamn:      Beskrivning: ");
                    Console.ResetColor();
                    Console.WriteLine(i + ". " + item_2.FN + "       " + item_2.EN + "       " + item_2.PN + "   " + item_2.BE);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Tid:      Typ:    Utrustning:");
                    Console.ResetColor();
                    Console.WriteLine(item_2.TI + "     " + item_2.TY + "     " + item_2.UT);
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
                                  where !(from s in con.TräningsUtrustningT select EF.Property<int>(s, "UtrustningID")).Contains(ut.ID)
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
        public void HämtaInfo3()
        {
            using (LabbContext con = new LabbContext())
            {
                var query1_2 = from atp in con.AnvändareT
                               join atp2 in con.TräningspassT on atp.ID equals EF.Property<int>(atp2, "AnvändareID")
                               join atp3 in con.TräningsUtrustningT on atp2.ID equals EF.Property<int>(atp3, "TräningsPassID")
                               join atp4 in con.UtrustT on EF.Property<int>(atp3, "UtrustningID") equals atp4.ID
                               group atp4 by atp4.Utrustning into grp
                               select new
                               {
                                   UT = grp.Key,
                                   CO = grp.Count()
                               };

                foreach (var item3 in query1_2)
                {
                    Console.WriteLine(item3.UT + " används " + item3.CO + " gånger");
                }
            }
        }
        public void HämtaInfo4()
        {

            using (LabbContext con = new LabbContext())
            {

                var query4 = from sist in con.AnvändareT
                             join sist2 in con.TräningspassT on sist.ID equals EF.Property<int>(sist2, "AnvändareID")
                             join sist3 in con.ÖvningDetalj on sist2.ID equals EF.Property<int>(sist3, "TräningsPassID")
                             join sist4 in con.ÖvningarT on EF.Property<int>(sist3, "ÖvningarID") equals sist4.ID
                             where sist3.JobbighetsNivå == (con.ÖvningDetalj.Select(ö => ö.JobbighetsNivå).Max())
                             select new
                             {
                                 FN = sist.Förnamn,
                                 EN = sist.Efternamn,
                                 EM = sist.Email,
                                 PN = sist2.Passnamn,
                                 BE = sist2.Beskrivning,
                                 TI = sist2.Tid,
                                 TY = sist2.Typ,
                                 JO = sist3.JobbighetsNivå,
                                 ÖV = sist4.Övningensnamn,
                                 RE = sist4.Repetitioner,
                                 SE = sist4.Sets
                             };

                foreach (var item4 in query4)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Förnamn:   EFternamn:  Email:  Passnamn:  beskrivning:                                              Tid:  Typ:");
                    Console.ResetColor();
                    Console.WriteLine(item4.FN + " " + item4.EN + " " + item4.EM + " " + item4.PN + " " + item4.BE + " " + item4.TI + " " + item4.TY);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Övningensnamn:  Repetition:  Sets:  Utrustning:  Jobbighetsnivå:");
                    Console.ResetColor();
                    Console.WriteLine(item4.ÖV + " " + item4.RE + " " + item4.SE + " " + " " + item4.JO);
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

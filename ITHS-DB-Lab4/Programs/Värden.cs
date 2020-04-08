using ITHS_DB_Lab4.DataCon;
using ITHS_DB_Lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITHS_DB_Lab4.Programs
{
    class Värden
    {
        public int count1 = 0;
        public int count2 = 0;
        public int count3 = 0;
        public int count4 = 0;
        public int count5 = 0;
        public int count6 = 0;
        public void AddvalueA()
        {
            using (LabbContext c = new LabbContext())
            {
                //Användare a1 = new Användare() { Namn = "Hans Hansson" };
                //Användare a2 = new Användare() { Namn = "Linn Andersson" };
                //Användare a3 = new Användare() { Namn = "Mats Olsson" };

                //c.AnvändareT.Add(a1);
                //c.AnvändareT.Add(a2);
                //c.AnvändareT.Add(a3);
                //c.SaveChanges();
                Användare a1 = new Användare() { Förnamn = "Hans", Efternamn = "Hansson", Email = "Hans.Hansson@gmail.com" };
                Användare a2 = new Användare() { Förnamn = "Linn", Efternamn = "Andresson", Email = "Linn.Andersson@gmail.com" };
                Användare a3 = new Användare() { Förnamn = "Mats", Efternamn = "Olsson", Email = "Mats.Olsson@gmail.com" };

                if (!c.AnvändareT.Any(A => a1.Förnamn == "Hans" && a2.Förnamn == "Linn" && a3.Förnamn == "Mats"))
                {
                    c.AnvändareT.Add(a1);
                    c.AnvändareT.Add(a2);
                    c.AnvändareT.Add(a3);
                    c.SaveChanges();
                }
            }
            }
        public void AddvalueT()
        {
            using (LabbContext c = new LabbContext())
            {
                TräningsPass t1 = new TräningsPass()
                { Passnamn = "TräningsPass 1", Beskrivning = "Tufft pass, fokus på att öka styrkan", Tid = "17:00", Typ = "Gym" };
                c.Entry(t1).Property("AnvändareID").CurrentValue = 1;

                TräningsPass t2 = new TräningsPass()
                { Passnamn = "TräningsPass 2", Beskrivning = "Kort pass,fokus på högpuls", Tid = "12:00", Typ = "Gym" };
                c.Entry(t2).Property("AnvändareID").CurrentValue = 2;

                TräningsPass t3 = new TräningsPass()
                { Passnamn = "TräningsPass 3", Beskrivning = "Lite längre pass, fokus på muskeltillväxt", Tid = "16:00", Typ = "Gym" };
                c.Entry(t3).Property("AnvändareID").CurrentValue = 3;

                TräningsPass t4 = new TräningsPass()
                { Passnamn = "TräningsPass 4", Beskrivning = "Vanligt pass, fokus på valfri muskelgrupp", Tid = "18:00", Typ = "Gym" };
                c.Entry(t4).Property("AnvändareID").CurrentValue = 1;

                TräningsPass t5 = new TräningsPass()
                { Passnamn = "TräningsPass 5", Beskrivning = "Statiskt pass,fokus på uthållighet och styrka", Tid = "17:00", Typ = "Gym" };
                c.Entry(t5).Property("AnvändareID").CurrentValue = 2;

                TräningsPass t6 = new TräningsPass()
                { Passnamn = "TräningsPass 6", Beskrivning = "Högintensivt pass, fokus på hög puls och styrka", Tid = "17:00", Typ = "Gym" };
                c.Entry(t6).Property("AnvändareID").CurrentValue = 3;

                TräningsPass t7 = new TräningsPass()
                { Passnamn = "TräningsPass 7", Beskrivning = "Vanligt pass, fokus på valfri muskelgrupp", Tid = "18:00", Typ = "Gym" };
                c.Entry(t7).Property("AnvändareID").CurrentValue = 1;

                TräningsPass t8 = new TräningsPass()
                { Passnamn = "TräningsPass 8", Beskrivning = "Vanligt pass, fokus på valfri muskelgrupp", Tid = "18:00", Typ = "Gym" };
                c.Entry(t8).Property("AnvändareID").CurrentValue = 2;

                TräningsPass t9 = new TräningsPass()
                { Passnamn = "TräningsPass 9", Beskrivning = "Lågintensivt pass, fokus på bra teknik och lågpuls", Tid = "17:00", Typ = "Gym" };
                c.Entry(t9).Property("AnvändareID").CurrentValue = 3;

                TräningsPass t10 = new TräningsPass()
                { Passnamn = "TräningsPass 10", Beskrivning = "Lite längre pass,fokus på valfri muskelgrupp", Tid = "16:00", Typ = "Gym" };
                c.Entry(t10).Property("AnvändareID").CurrentValue = 1;

                c.TräningspassT.Add(t1);
                c.TräningspassT.Add(t2);
                c.TräningspassT.Add(t3);
                c.TräningspassT.Add(t4);
                c.TräningspassT.Add(t5);
                c.TräningspassT.Add(t6);
                c.TräningspassT.Add(t7);
                c.TräningspassT.Add(t8);
                c.TräningspassT.Add(t9);
                c.TräningspassT.Add(t10);
                c.SaveChanges();

                if (t1.ID > 10)
                {
                    c.Remove(t1);
                    c.Remove(t2);
                    c.Remove(t3);
                    c.Remove(t4);
                    c.Remove(t5);
                    c.Remove(t6);
                    c.Remove(t7);
                    c.Remove(t8);
                    c.Remove(t9);
                    c.Remove(t10);
                    c.SaveChanges();
                }
            }
        }
        public void AddvalueÖ()
        {
            using (LabbContext c = new LabbContext())
            {
                Övningar ö1 = new Övningar() { Övningensnamn = "Marklyft", Repetitioner = 5, Sets = 5 };
                Övningar ö2 = new Övningar() { Övningensnamn = "Hantelpress", Repetitioner = 10, Sets = 3 };
                Övningar ö3 = new Övningar() { Övningensnamn = "Plankan", Repetitioner = 1, Sets = 2 };
                Övningar ö4 = new Övningar() { Övningensnamn = "Militärpress", Repetitioner = 10, Sets = 3 };
                Övningar ö5 = new Övningar() { Övningensnamn = "Tricepspress maskin", Repetitioner = 10, Sets = 3 };

                if (
                    !c.ÖvningarT.Any(Ö => ö1.Övningensnamn == "Marklyft" && ö2.Övningensnamn == "Hantelpress" && ö3.Övningensnamn == "Plankan"
                    && ö4.Övningensnamn == "Militärpress" && ö5.Övningensnamn == "Tricepspress maskin"
                    ))
                {
                    c.ÖvningarT.Add(ö1);
                    c.ÖvningarT.Add(ö2);
                    c.ÖvningarT.Add(ö3);
                    c.ÖvningarT.Add(ö4);
                    c.ÖvningarT.Add(ö5);
                    c.SaveChanges();
                }
            }
        }
        public void AddvalueU()
        {
            using (LabbContext c = new LabbContext())
            {
                Utrust u1 = new Utrust() { Utrustning = "Hantlar" };
                Utrust u2 = new Utrust() { Utrustning = "Skivstång" };
                Utrust u3 = new Utrust() { Utrustning = "Maskin" };
                Utrust u4 = new Utrust() { Utrustning = "Skor" };
                Utrust u5 = new Utrust() { Utrustning = "Löpband" };
                Utrust u6 = new Utrust() { Utrustning = "Spinningscykel" };
                if (
                    !c.UtrustT.Any(U => u1.Utrustning == "Hantlar" && u2.Utrustning == "Skivstång" && u3.Utrustning == "Maskin"
                    && u4.Utrustning == "Skor" && u5.Utrustning == "Löpband" && u6.Utrustning == "Spinningscykel"
                   ))
                {
                    c.UtrustT.Add(u1);
                    c.UtrustT.Add(u3);
                    c.UtrustT.Add(u2);
                    c.UtrustT.Add(u4);
                    c.UtrustT.Add(u5);
                    c.UtrustT.Add(u6);
                    c.SaveChanges();
                }
            }
        }
        public void AddvalueÖD()
        {
            using (LabbContext c = new LabbContext())
            {
                // ------------------------------------------- insert till shadow property -----------------------------------------------
                ÖvningDetalj fp1 = new ÖvningDetalj() { JobbighetsNivå = 6 };
                c.Entry(fp1).Property("TräningsPassID").CurrentValue = 1;
                c.Entry(fp1).Property("ÖvningarID").CurrentValue = 2;

                ÖvningDetalj fp2 = new ÖvningDetalj() { JobbighetsNivå = 10 };
                c.Entry(fp2).Property("TräningsPassID").CurrentValue = 2;
                c.Entry(fp2).Property("ÖvningarID").CurrentValue = 5;

                ÖvningDetalj fp3 = new ÖvningDetalj() { JobbighetsNivå = 3 };
                c.Entry(fp3).Property("TräningsPassID").CurrentValue = 3;
                c.Entry(fp3).Property("ÖvningarID").CurrentValue = 4;

                ÖvningDetalj fp4 = new ÖvningDetalj() { JobbighetsNivå = 2 };
                c.Entry(fp4).Property("TräningsPassID").CurrentValue = 4;
                c.Entry(fp4).Property("ÖvningarID").CurrentValue = 2;

                ÖvningDetalj fp5 = new ÖvningDetalj() { JobbighetsNivå = 4 };
                c.Entry(fp5).Property("TräningsPassID").CurrentValue = 5;
                c.Entry(fp5).Property("ÖvningarID").CurrentValue = 3;

                ÖvningDetalj fp6 = new ÖvningDetalj() { JobbighetsNivå = 1 };
                c.Entry(fp6).Property("TräningsPassID").CurrentValue = 6;
                c.Entry(fp6).Property("ÖvningarID").CurrentValue = 1;

                ÖvningDetalj fp7 = new ÖvningDetalj() { JobbighetsNivå = 9 };
                c.Entry(fp7).Property("TräningsPassID").CurrentValue = 7;
                c.Entry(fp7).Property("ÖvningarID").CurrentValue = 2;

                ÖvningDetalj fp8 = new ÖvningDetalj() { JobbighetsNivå = 7 };
                c.Entry(fp8).Property("TräningsPassID").CurrentValue = 8;
                c.Entry(fp8).Property("ÖvningarID").CurrentValue = 4;

                ÖvningDetalj fp9 = new ÖvningDetalj() { JobbighetsNivå = 10 };
                c.Entry(fp9).Property("TräningsPassID").CurrentValue = 9;
                c.Entry(fp9).Property("ÖvningarID").CurrentValue = 5;

                ÖvningDetalj fp10 = new ÖvningDetalj() { JobbighetsNivå = 6 };
                c.Entry(fp10).Property("TräningsPassID").CurrentValue = 3;
                c.Entry(fp10).Property("ÖvningarID").CurrentValue = 3;

                c.Add(fp1);
                c.Add(fp2);
                c.Add(fp3);
                c.Add(fp4);
                c.Add(fp5);
                c.Add(fp6);
                c.Add(fp7);
                c.Add(fp8);
                c.Add(fp9);
                c.Add(fp10);

                c.SaveChanges();

                if (fp1.ID > 10)
                {
                    c.Remove(fp1);
                    c.Remove(fp2);
                    c.Remove(fp3);
                    c.Remove(fp4);
                    c.Remove(fp5);
                    c.Remove(fp6);
                    c.Remove(fp7);
                    c.Remove(fp8);
                    c.Remove(fp9);
                    c.Remove(fp10);
                    c.SaveChanges();
                }
            }
        }
        public void AddvalueTU()
        {
            using (LabbContext c = new LabbContext())
            {
                TräningsUtrustning tu1 = new TräningsUtrustning();
                c.Entry(tu1).Property("TräningsPassID").CurrentValue = 1;
                c.Entry(tu1).Property("UtrustningID").CurrentValue = 1;
                count1++;

                TräningsUtrustning tu2 = new TräningsUtrustning();
                c.Entry(tu2).Property("TräningsPassID").CurrentValue = 1;
                c.Entry(tu2).Property("UtrustningID").CurrentValue = 4;
                count4++;

                TräningsUtrustning tu3 = new TräningsUtrustning();
                c.Entry(tu3).Property("TräningsPassID").CurrentValue = 2;
                c.Entry(tu3).Property("UtrustningID").CurrentValue = 2;
                count2++;

                TräningsUtrustning tu4 = new TräningsUtrustning();
                c.Entry(tu4).Property("TräningsPassID").CurrentValue = 3;
                c.Entry(tu4).Property("UtrustningID").CurrentValue = 3;
                count3++;

                TräningsUtrustning tu5 = new TräningsUtrustning();
                c.Entry(tu5).Property("TräningsPassID").CurrentValue = 3;
                c.Entry(tu5).Property("UtrustningID").CurrentValue = 4;
                count4++;

                TräningsUtrustning tu6 = new TräningsUtrustning();
                c.Entry(tu6).Property("TräningsPassID").CurrentValue = 3;
                c.Entry(tu6).Property("UtrustningID").CurrentValue = 1;
                count1++;

                TräningsUtrustning tu7 = new TräningsUtrustning();
                c.Entry(tu7).Property("TräningsPassID").CurrentValue = 4;
                c.Entry(tu7).Property("UtrustningID").CurrentValue = 1;
                count1++;

                TräningsUtrustning tu8 = new TräningsUtrustning();
                c.Entry(tu8).Property("TräningsPassID").CurrentValue = 5;
                c.Entry(tu8).Property("UtrustningID").CurrentValue = 4;
                count4++;

                TräningsUtrustning tu9 = new TräningsUtrustning();
                c.Entry(tu9).Property("TräningsPassID").CurrentValue = 6;
                c.Entry(tu9).Property("UtrustningID").CurrentValue = 3;
                count3++;

                TräningsUtrustning tu10 = new TräningsUtrustning();
                c.Entry(tu10).Property("TräningsPassID").CurrentValue = 6;
                c.Entry(tu10).Property("UtrustningID").CurrentValue = 4;
                count4++;

                TräningsUtrustning tu11 = new TräningsUtrustning();
                c.Entry(tu11).Property("TräningsPassID").CurrentValue = 7;
                c.Entry(tu11).Property("UtrustningID").CurrentValue = 1;
                count1++;

                TräningsUtrustning tu12 = new TräningsUtrustning();
                c.Entry(tu12).Property("TräningsPassID").CurrentValue = 8;
                c.Entry(tu12).Property("UtrustningID").CurrentValue = 4;
                count4++;

                TräningsUtrustning tu13 = new TräningsUtrustning();
                c.Entry(tu13).Property("TräningsPassID").CurrentValue = 8;
                c.Entry(tu13).Property("UtrustningID").CurrentValue = 1;
                count1++;

                TräningsUtrustning tu14 = new TräningsUtrustning();
                c.Entry(tu14).Property("TräningsPassID").CurrentValue = 9;
                c.Entry(tu14).Property("UtrustningID").CurrentValue = 2;
                count2++;

                TräningsUtrustning tu15 = new TräningsUtrustning();
                c.Entry(tu15).Property("TräningsPassID").CurrentValue = 9;
                c.Entry(tu15).Property("UtrustningID").CurrentValue = 4;
                count4++;

                TräningsUtrustning tu16 = new TräningsUtrustning();
                c.Entry(tu16).Property("TräningsPassID").CurrentValue = 10;
                c.Entry(tu16).Property("UtrustningID").CurrentValue = 4;
                count4++;

                c.Add(tu1);
                c.Add(tu2);
                c.Add(tu3);
                c.Add(tu4);
                c.Add(tu5);
                c.Add(tu6);
                c.Add(tu7);
                c.Add(tu8);
                c.Add(tu9);
                c.Add(tu10);
                c.Add(tu11);
                c.Add(tu12);
                c.Add(tu13);
                c.Add(tu14);
                c.Add(tu15);
                c.Add(tu16);
                c.SaveChanges();

                if (tu1.ID > 16)
                {
                    c.Remove(tu1);
                    c.Remove(tu2);
                    c.Remove(tu3);
                    c.Remove(tu4);
                    c.Remove(tu5);
                    c.Remove(tu6);
                    c.Remove(tu7);
                    c.Remove(tu8);
                    c.Remove(tu9);
                    c.Remove(tu10);
                    c.Remove(tu11);
                    c.Remove(tu12);
                    c.Remove(tu13);
                    c.Remove(tu14);
                    c.Remove(tu15);
                    c.Remove(tu16);
                    c.SaveChanges();
                }
            }
        }
    }
}

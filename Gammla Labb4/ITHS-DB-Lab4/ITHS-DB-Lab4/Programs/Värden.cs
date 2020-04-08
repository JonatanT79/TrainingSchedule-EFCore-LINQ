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
                /*
                Användare a1 = new Användare() { Namn = "Hans Hansson" };
                Användare a2 = new Användare() { Namn = "Linn Andersson" };
                Användare a3 = new Användare() { Namn = "Mats Olsson" };
                */

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

                TräningsPass t2 = new TräningsPass()
                { Passnamn = "TräningsPass 2", Beskrivning = "Kort pass,fokus på högpuls", Tid = "12:00", Typ = "Gym" };

                TräningsPass t3 = new TräningsPass()
                { Passnamn = "TräningsPass 3", Beskrivning = "Lite längre pass, fokus på muskeltillväxt", Tid = "16:00", Typ = "Gym" };

                TräningsPass t4 = new TräningsPass()
                { Passnamn = "TräningsPass 4", Beskrivning = "Vanligt pass, fokus på valfri muskelgrupp", Tid = "18:00", Typ = "Gym" };

                TräningsPass t5 = new TräningsPass()
                { Passnamn = "TräningsPass 5", Beskrivning = "Statiskt pass,fokus på uthållighet och styrka", Tid = "17:00", Typ = "Gym" };

                TräningsPass t6 = new TräningsPass()
                { Passnamn = "TräningsPass 6", Beskrivning = "Högintensivt pass, fokus på hög puls och styrka", Tid = "17:00", Typ = "Gym" };

                TräningsPass t7 = new TräningsPass()
                { Passnamn = "TräningsPass 7", Beskrivning = "Vanligt pass, fokus på valfri muskelgrupp", Tid = "18:00", Typ = "Gym" };

                TräningsPass t8 = new TräningsPass()
                { Passnamn = "TräningsPass 8", Beskrivning = "Vanligt pass, fokus på valfri muskelgrupp", Tid = "18:00", Typ = "Gym" };

                TräningsPass t9 = new TräningsPass()
                { Passnamn = "TräningsPass 9", Beskrivning = "Lågintensivt pass, fokus på bra teknik och lågpuls", Tid = "17:00", Typ = "Gym" };

                TräningsPass t10 = new TräningsPass()
                { Passnamn = "TräningsPass 10", Beskrivning = "Lite längre pass,fokus på valfri muskelgrupp", Tid = "16:00", Typ = "Gym" };
                
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

                if (!c.ÖvningarT.Any(Ö => ö1.Övningensnamn == "Marklyft" && ö2.Övningensnamn == "Hantelpress" && ö3.Övningensnamn == "Plankan" && ö4.Övningensnamn == "Militärpress" && ö5.Övningensnamn == "Tricepspress maskin"))
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
                if (!c.UtrustT.Any(U => u1.Utrustning == "Hantlar" && u2.Utrustning == "Skivstång" && u3.Utrustning == "Maskin" && u4.Utrustning == "Skor" && u5.Utrustning == "Löpband" && u6.Utrustning == "Spinningscykel"))
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
        public void AddvalueJ()
        {
            using (LabbContext c = new LabbContext())
            {
                Jobbinivå j1 = new Jobbinivå() { JobbighetsNivå = 1 };
                Jobbinivå j2 = new Jobbinivå() { JobbighetsNivå = 2 };
                Jobbinivå j3 = new Jobbinivå() { JobbighetsNivå = 3 };
                Jobbinivå j4 = new Jobbinivå() { JobbighetsNivå = 4 };
                Jobbinivå j5 = new Jobbinivå() { JobbighetsNivå = 5 };
                Jobbinivå j6 = new Jobbinivå() { JobbighetsNivå = 6 };
                Jobbinivå j7 = new Jobbinivå() { JobbighetsNivå = 7 };
                Jobbinivå j8 = new Jobbinivå() { JobbighetsNivå = 8 };
                Jobbinivå j9 = new Jobbinivå() { JobbighetsNivå = 9 };
                Jobbinivå j10 = new Jobbinivå() { JobbighetsNivå = 10 };

                c.JobbinivåT.Add(j1);
                c.JobbinivåT.Add(j2);
                c.JobbinivåT.Add(j3);
                c.JobbinivåT.Add(j4);
                c.JobbinivåT.Add(j5);
                c.JobbinivåT.Add(j6);
                c.JobbinivåT.Add(j7);
                c.JobbinivåT.Add(j8);
                c.JobbinivåT.Add(j9);
                c.JobbinivåT.Add(j10);
                c.SaveChanges();

                if (j1.ID > 10)
                {
                    c.Remove(j1);
                    c.Remove(j2);
                    c.Remove(j3);
                    c.Remove(j4);
                    c.Remove(j5);
                    c.Remove(j6);
                    c.Remove(j7);
                    c.Remove(j8);
                    c.Remove(j9);
                    c.Remove(j10);
                    c.SaveChanges();
                }
            }
        }
        public void AddvalueFP()
        {
            using (LabbContext c = new LabbContext())
            {
                // ------------------------------------------- insert till shadow property -----------------------------------------------
                FullständigtPass fp1 = new FullständigtPass();
                c.Entry(fp1).Property("AnvändareID").CurrentValue = 1;
                c.Entry(fp1).Property("TräningsPassID").CurrentValue = 3;
                c.Entry(fp1).Property("ÖvningarID").CurrentValue = 4;
                c.Entry(fp1).Property("UtrustningID").CurrentValue = 2;
                c.Entry(fp1).Property("JobbighetsnivåID").CurrentValue = 7;
                count2++;

                FullständigtPass fp2 = new FullständigtPass();
                c.Entry(fp2).Property("AnvändareID").CurrentValue = 1;
                c.Entry(fp2).Property("TräningsPassID").CurrentValue = 3;
                c.Entry(fp2).Property("ÖvningarID").CurrentValue = 4;
                c.Entry(fp2).Property("UtrustningID").CurrentValue = 4;
                c.Entry(fp2).Property("JobbighetsnivåID").CurrentValue = 7;
                count4++;

                FullständigtPass fp3 = new FullständigtPass();
                c.Entry(fp3).Property("AnvändareID").CurrentValue = 1;
                c.Entry(fp3).Property("TräningsPassID").CurrentValue = 3;
                c.Entry(fp3).Property("ÖvningarID").CurrentValue = 4;
                c.Entry(fp3).Property("UtrustningID").CurrentValue = 1;
                c.Entry(fp3).Property("JobbighetsnivåID").CurrentValue = 7;
                count1++;

                FullständigtPass fp4 = new FullständigtPass();
                c.Entry(fp4).Property("AnvändareID").CurrentValue = 1;
                c.Entry(fp4).Property("TräningsPassID").CurrentValue = 7;
                c.Entry(fp4).Property("ÖvningarID").CurrentValue = 2;
                c.Entry(fp4).Property("UtrustningID").CurrentValue = 1;
                c.Entry(fp4).Property("JobbighetsnivåID").CurrentValue = 5;
                count1++;

                FullständigtPass fp5 = new FullständigtPass();
                c.Entry(fp5).Property("AnvändareID").CurrentValue = 1;
                c.Entry(fp5).Property("TräningsPassID").CurrentValue = 5;
                c.Entry(fp5).Property("ÖvningarID").CurrentValue = 3;
                c.Entry(fp5).Property("UtrustningID").CurrentValue = 4;
                c.Entry(fp5).Property("JobbighetsnivåID").CurrentValue = 4;
                count4++;

                FullständigtPass fp6 = new FullständigtPass();
                c.Entry(fp6).Property("AnvändareID").CurrentValue = 2;
                c.Entry(fp6).Property("TräningsPassID").CurrentValue = 6;
                c.Entry(fp6).Property("ÖvningarID").CurrentValue = 1;
                c.Entry(fp6).Property("UtrustningID").CurrentValue = 2;
                c.Entry(fp6).Property("JobbighetsnivåID").CurrentValue = 8;
                count2++;

                FullständigtPass fp7 = new FullständigtPass();
                c.Entry(fp7).Property("AnvändareID").CurrentValue = 2;
                c.Entry(fp7).Property("TräningsPassID").CurrentValue = 6;
                c.Entry(fp7).Property("ÖvningarID").CurrentValue = 1;
                c.Entry(fp7).Property("UtrustningID").CurrentValue = 4;
                c.Entry(fp7).Property("JobbighetsnivåID").CurrentValue = 8;
                count4++;

                FullständigtPass fp8 = new FullständigtPass();
                c.Entry(fp8).Property("AnvändareID").CurrentValue = 2;
                c.Entry(fp8).Property("TräningsPassID").CurrentValue = 3;
                c.Entry(fp8).Property("ÖvningarID").CurrentValue = 5;
                c.Entry(fp8).Property("UtrustningID").CurrentValue = 3;
                c.Entry(fp8).Property("JobbighetsnivåID").CurrentValue = 7;
                count3++;

                FullständigtPass fp9 = new FullständigtPass();
                c.Entry(fp9).Property("AnvändareID").CurrentValue = 3;
                c.Entry(fp9).Property("TräningsPassID").CurrentValue = 9;
                c.Entry(fp9).Property("ÖvningarID").CurrentValue = 5;
                c.Entry(fp9).Property("UtrustningID").CurrentValue = 3;
                c.Entry(fp9).Property("JobbighetsnivåID").CurrentValue = 9;
                count3++;

                FullständigtPass fp10 = new FullständigtPass();
                c.Entry(fp10).Property("AnvändareID").CurrentValue = 3;
                c.Entry(fp10).Property("TräningsPassID").CurrentValue = 9;
                c.Entry(fp10).Property("ÖvningarID").CurrentValue = 5;
                c.Entry(fp10).Property("UtrustningID").CurrentValue = 4;
                c.Entry(fp10).Property("JobbighetsnivåID").CurrentValue = 9;
                count4++;

                FullständigtPass fp11 = new FullständigtPass();
                c.Entry(fp11).Property("AnvändareID").CurrentValue = 3;
                c.Entry(fp11).Property("TräningsPassID").CurrentValue = 4;
                c.Entry(fp11).Property("ÖvningarID").CurrentValue = 2;
                c.Entry(fp11).Property("UtrustningID").CurrentValue = 1;
                count1++;

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
                c.Add(fp11);
                c.SaveChanges();

                if (fp1.ID > 11)
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
                    c.Remove(fp11);
                    c.SaveChanges();
                }
            }
        }
    }
}

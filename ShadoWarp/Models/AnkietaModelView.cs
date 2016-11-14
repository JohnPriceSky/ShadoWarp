using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShadoWarp.Models
{
    public class AnkietaModelView
    {
        public string ans { get; private set; }
        public string komentarz { get; private set; }
        private static int glosRok;
        private static int glosDwa;
        private static int glosTrzy;
        private static int glosWiecej; 
        public int iloscGlosow { get; private set; }
        public AnkietaModelView(string s)
        {
            switch (s)
            {
                case "rok":
                    ans = string.Format("Wybrałeś {0}!", s);
                    komentarz = "Co za nooooooooooob :P";
                    iloscGlosow = ++glosRok;
                    break;
                case "dwa":
                    ans = string.Format("Wybrałeś {0} lata!", s);
                    komentarz = "Tak dalej!!!";
                    iloscGlosow = ++glosDwa;
                    break;
                case "trzy":
                    ans = string.Format("Wybrałeś {0} lata!", s);
                    komentarz = "Zajebioza :D";
                    iloscGlosow = ++glosTrzy;
                    break;
                case "wiecej":
                    ans = string.Format("Wybrałeś więcej");
                    komentarz = "WOW. Jaki świrus z Ciebie, jakiś syn diabła.";
                    iloscGlosow = ++glosWiecej;
                    break;
                default:
                    ans = string.Format("Jaki zjeb nic nie wybrał...");
                    komentarz = string.Format("No... jakby to powiedzieć..., jakiś okrutnik :/");
                    break;
            }
            /*StreamWriter sw = new StreamWriter("~/AnkietaWyn/wyniki.txt");
            sw.WriteLine(glosRok);
            sw.WriteLine(glosDwa);
            sw.WriteLine(glosTrzy);
            sw.WriteLine(glosWiecej);
            sw.Close();*/
        }
    }
}
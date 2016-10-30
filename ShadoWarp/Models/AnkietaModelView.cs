using System;
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
        public AnkietaModelView(string s)
        {
            switch (s)
            {
                case "rok":
                    ans = string.Format("Wybrałeś {0}!", s);
                    komentarz = "Co za nooooooooooob :P";
                    break;
                case "dwa":
                    ans = string.Format("Wybrałeś {0} lata!", s);
                    komentarz = "Tak dalej!!!";
                    break;
                case "trzy":
                    ans = string.Format("Wybrałeś {0} lata!", s);
                    komentarz = "Zajebioza :D";
                    break;
                case "wiecej":
                    ans = string.Format("Wybrałeś więcej");
                    komentarz = "WOW. Jaki świrus z Ciebie, jakiś syn diabła.";
                    break;
                default:
                    ans = string.Format("Jaki zjeb nic nie wybrał...");
                    komentarz = string.Format("No... jakby to powiedzieć..., jakiś okrutnik :/");
                    break;
            }
        }
    }
}
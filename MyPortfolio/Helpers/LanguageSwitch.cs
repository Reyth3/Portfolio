
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolio.Helpers
{
    public class LanguageSwitch
    {
        public static Lang GetLanguage()
        {
            var c = HttpContext.Current.Request.Cookies.Get("lang");
            if (c == null)
                return (Lang)0;
            else return (Lang)int.Parse(c["language"]);
        }

        public static void SetLang(Lang l)
        {
            var lang = new HttpCookie("lang");
            lang.Expires = DateTime.Now.AddDays(7);
            lang["language"] = ((int)l).ToString();
            HttpContext.Current.Response.Cookies.Set(lang);
        }
    }

    public enum Lang { English, Polish }
}
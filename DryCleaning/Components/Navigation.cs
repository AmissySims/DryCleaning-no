using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DryCleaning.Components
{
    internal class Navigation
    {
        public static User AuthUser = null;
        public static bool isAuth = false;
        public static MainWindow main;
        public static List<Nav> navs = new List<Nav>();

        public static void NextPage(Nav nav)
        {
            navs.Add(nav);
            Update(nav);

        }
        public static void BackPage(Nav nav)
        {
            if(navs.Count > 1)
                navs.Remove(navs[navs.Count - 1]);
            Update(navs[navs.Count - 1]);

        }
        private static void Update(Nav nav)
        {
            main.MainFrame.Navigate(nav.Page);
            main.TitlePage.Text = nav.Title;
        }
    }
    class Nav
    {
        public string Title { get; set; }
        public Page Page { get; set; }
        public Nav(string Title, Page Page)
        {
            this.Title = Title;
            this.Page = Page;

        }

    }
}

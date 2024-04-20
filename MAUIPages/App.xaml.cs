using MAUIPages.Pages;
using MAUIPages.Pages.FlyoutPageDemo;
using MAUIPages.Pages.NavPageDemo;
using MAUIPages.Pages.TabbedPageDemo;

namespace MAUIPages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            // Demo page uchun
            //MainPage = new DemoContentPage1();

            // nav content demo
            //MainPage = new NavigationPage(new NavContentPage1());

            // navigation uchun advancedroq
            //var navigationPage = new NavigationPage(new NavContentPage1());

            //navigationPage.BarBackgroundColor = Colors.Firebrick;
            //navigationPage.BarTextColor = Colors.Black;

            //MainPage = navigationPage;

            //Flyout Page
             //MainPage = new DemoFlyoutPage();

            // Tabbed Page
            MainPage = new DemoTabbedPage();

        }
    }
}

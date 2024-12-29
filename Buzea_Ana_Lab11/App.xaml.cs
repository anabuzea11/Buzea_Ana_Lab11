using Buzea_Ana_Lab11.Data;

namespace Buzea_Ana_Lab11 
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            InitializeComponent();

            Database = new ShoppingListDatabase(new RestService()); 
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}

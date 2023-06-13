using MySqlConnector;
using ProbDemTwo.PageSS;
using ProbDemTwo.SecurityY;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProbDemTwo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (AuthClassUser.user != null)
            {
                if (AuthClassUser.user.UserLogin == "Guest")
                {
                    btZapisi.Visibility = Visibility.Hidden;
                }
            }

            //MySqlConnectionStringBuilder qwe = new MySqlConnectionStringBuilder()
            //{
            //    Server = "cfif31.ru",
            //    Port = 3306,
            //    Database = "ISPr22-43_AhmadulinTI_ProbDemTwo",
            //    UserID = "ISPr22-43_AhmadulinTI",
            //    Password = "ISPr22-43_AhmadulinTI",
            //    CharacterSet = "utf8"
            //};
            //Debug.WriteLine(qwe);
        }

        private void btSotrudnikiPageSwichClick(object sender, RoutedEventArgs e)
        {
            FrNav.Navigate(new SotrudnikiPage());
        }

        private void btZapisiPageSwichClick(object sender, RoutedEventArgs e)
        {
            FrNav.Navigate(new ZapisiPage());
        }
    }
}

using ProbDemTwo.DbConnection;
using ProbDemTwo.DbConnection.EntityES;
using System;
using System.Collections.Generic;
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

namespace ProbDemTwo.PageSS
{
    /// <summary>
    /// Interaction logic for AddSortrunikPage.xaml
    /// </summary>
    public partial class AddSortrunikPage : Page
    {
        Vrachi vrachi;
        public AddSortrunikPage(Vrachi vrachi)
        {
            this.vrachi = vrachi;
            InitializeComponent();
            DataContext = vrachi;
        }

        private void btAddSotrudniki(object sender, RoutedEventArgs e)
        {
            if (vrachi.VrachiId == 0)
                EfModel.Init().Vrachis.Add(vrachi);
            EfModel.Init().SaveChanges();
            NavigationService.Navigate(new SotrudnikiPage());
        }
    }
}

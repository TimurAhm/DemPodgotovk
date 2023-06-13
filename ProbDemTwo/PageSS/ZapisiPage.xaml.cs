using ProbDemTwo.DbConnection;
using ProbDemTwo.SecurityY;
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
    /// Interaction logic for ZapisiPage.xaml
    /// </summary>
    public partial class ZapisiPage : Page
    {
        public ZapisiPage()
        {
            InitializeComponent();
            UpdateData();
        }

        private void UpdateData()
        {
            if (AuthClassPacient.pacient == null)
            {
                if (AuthClassUser.user == AuthClassUser.user)
                {
                    lvZapisi.ItemsSource = EfModel.Init().Poseschenies.Where(i => i.PosescheniePacient.Contains(tbSearch.Text) || i.PoseschenieVrachFam.Contains(tbSearch.Text) || i.PoseschenieVrachName.Contains(tbSearch.Text) || i.PoseschenieVrachOtch.Contains(tbSearch.Text) || Convert.ToString(i.PoseschenieDataZapis).Contains(tbSearch.Text) || Convert.ToString(i.PoseschenieDataPos).Contains(tbSearch.Text) || Convert.ToString(i.PoseschenieTimePos).Contains(tbSearch.Text) || i.PoseschenieTipPos.Contains(tbSearch.Text) || i.PoseschenieKritetiyPos.Contains(tbSearch.Text)).ToList();
                }
            }
            if (AuthClassUser.user == null)
            {
                if (AuthClassPacient.pacient == AuthClassPacient.pacient)
                {
                    lvZapisi.ItemsSource = EfModel.Init().Poseschenies.Where(q => q.PosescheniePacient == AuthClassPacient.pacient.PacientFio && (q.PosescheniePacient.Contains(tbSearch.Text) || q.PoseschenieVrachFam.Contains(tbSearch.Text) || q.PoseschenieVrachName.Contains(tbSearch.Text) || q.PoseschenieVrachOtch.Contains(tbSearch.Text) || Convert.ToString(q.PoseschenieDataZapis).Contains(tbSearch.Text) || Convert.ToString(q.PoseschenieDataPos).Contains(tbSearch.Text) || Convert.ToString(q.PoseschenieTimePos).Contains(tbSearch.Text) || q.PoseschenieTipPos.Contains(tbSearch.Text) || q.PoseschenieKritetiyPos.Contains(tbSearch.Text))).ToList();
                }
            }
        }

        private void tbTextChang(object sender, TextChangedEventArgs e)
        {
            UpdateData();
        }
    }
}

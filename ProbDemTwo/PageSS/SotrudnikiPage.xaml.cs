using ProbDemTwo.DbConnection;
using ProbDemTwo.DbConnection.EntityES;
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
    /// Interaction logic for SotrudnikiPage.xaml
    /// </summary>
    public partial class SotrudnikiPage : Page
    {
        int a = EfModel.Init().Vrachis.Count();
        public SotrudnikiPage()
        {
            InitializeComponent();
            UpdateData();
        }

        private void UpdateData()
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" +  a;
        }

        private void tbsearchTextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
        }

        private void btCortUpClick(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.OrderByDescending(u => u.VrachiFam).Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btCortDowmClick(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.OrderBy(u => u.VrachiFam).Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btCortResetClick(object sender, RoutedEventArgs e)
        {
            UpdateData();
        }

        private void btCortResetClickT(object sender, RoutedEventArgs e)
        {
            UpdateData();
        }

        private void btCortUpClickT(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.OrderByDescending(u => u.VrachiDoljnost).Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;

        }

        private void btCortDowmClickT(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.OrderBy(u => u.VrachiDoljnost).Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btCortResetClickS(object sender, RoutedEventArgs e)
        {
            UpdateData();
        }

        private void btCortUpClickS(object sender, RoutedEventArgs e)
        {

            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiStatus == "Присутствует").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btCortDowmClickS(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiStatus == "В отпуске").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btVkomanditovkeClickS(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiStatus == "В командировке").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btResetTipPos(object sender, RoutedEventArgs e)
        {
            UpdateData();
        }

        private void btPolisOMS(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiTipPos == "По полису ОМС").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btSrochnoe(object sender, RoutedEventArgs e)
        {

            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiTipPos == "Срочное").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btPoNapravl(object sender, RoutedEventArgs e)
        {

            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiTipPos == "По направлению").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btPlatnoe(object sender, RoutedEventArgs e)
        {

            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiTipPos == "Платное").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btResetNapravl(object sender, RoutedEventArgs e)
        {
            UpdateData();
        }

        private void DEndokr(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiDoljnost == "Детский эндокринолог").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btDietolog(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiDoljnost == "Диетолог").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btInfectionist(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiDoljnost == "Инфекционист").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btKardio(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiDoljnost == "Кардиолог").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btKosmetolog(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiDoljnost == "Косметолог").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
            u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btNevrolog(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiDoljnost == "Невролог").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
          u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btosteopat(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiDoljnost == "Остеопат").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
           u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btPediatr(object sender, RoutedEventArgs e)
        {
            lvSotrudniki.ItemsSource = EfModel.Init().Vrachis.Where(u => u.VrachiDoljnost == "Педиатр").Where(u => u.VrachiFam.Contains(tbSearch.Text) || u.VrachiName.Contains(tbSearch.Text) || u.VrachiOtch.Contains(tbSearch.Text) || u.VrachiDoljnost.Contains(tbSearch.Text) ||
           u.VrachiSmena.Contains(tbSearch.Text) || u.VrachiVremya.Contains(tbSearch.Text) || u.VrachiTipPos.Contains(tbSearch.Text) || u.VrachiStatus.Contains(tbSearch.Text)).ToList();
            itemsCount.Text = "Всего элементов - " + Convert.ToString(lvSotrudniki.Items.Count) + "/" + a;
        }

        private void btAddSotrudnikClick(object sender, RoutedEventArgs e)
        {
            if (lvSotrudniki.SelectedValue != null)
            {
                Vrachi vrachi = (Vrachi)lvSotrudniki.SelectedValue;
                NavigationService.Navigate(new AddSortrunikPage(vrachi));
            }
            else
            {
                NavigationService.Navigate(new AddSortrunikPage(new Vrachi()));
            }
        }
    }
}

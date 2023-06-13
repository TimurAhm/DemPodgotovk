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
using System.Windows.Shapes;

namespace ProbDemTwo
{
    /// <summary>
    /// Interaction logic for AuthWin.xaml
    /// </summary>
    public partial class AuthWin : Window
    {
        public AuthWin()
        {
            InitializeComponent();
           
        }

        private void btLoginClick(object sender, RoutedEventArgs e)
        {

            if (AuthClassUser.Autent(tbLogin.Text, tbPassword.Text) == true)
            {
                tbLogin.Clear();
                tbPassword.Clear();
                MessageBox.Show("Добро пожаловать, " + AuthClassUser.user.UserName + "!");
                Hide();
                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();
                Show();
            }
            else if (AuthClassPacient.Autent(tbLogin.Text, tbPassword.Text) == true)
            {
                tbLogin.Clear();
                tbPassword.Clear();
                MessageBox.Show("Добро пожаловать, " + AuthClassPacient.pacient.PacientFio + "!");
                Hide();
                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Неверно введены данные."); 
            }
        }

        private void btLoginGuestClick(object sender, RoutedEventArgs e)
        {
            if (AuthClassUser.Autent("Guest", "Guest") == true)
            {
                tbLogin.Clear();
                tbPassword.Clear();
                MessageBox.Show("Добро пожаловать, " + AuthClassUser.user.UserName + "!");
                Hide();
                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();
                Show();
            }
        }
    }
}

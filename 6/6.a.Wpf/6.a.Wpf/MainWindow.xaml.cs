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

namespace _6.a.Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Rect_Button(object sender, RoutedEventArgs e)
        {
            try
            {

                libs.Rect rect = new libs.Rect(Convert.ToDouble(side1.Text), Convert.ToDouble(side2.Text));
                rect.Area();
                rect.Perimetor();
                double a, p;
                string n;
                (a,p,n) = rect.Show();
                Rect_propertys.Content = String.Format("aria is {0},\nperimeter is {1},\nname is '{2}'",a,p,n);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Введенное значение не похоже на не метрическую систему счета вы были признаны инагентом");
            }

            side1.Text = ""; side2.Text = "";
        }

        public void Squere_Button(object sender, RoutedEventArgs e)
        {
            try
            {
                libs.Squeare rect = new libs.Squeare(Convert.ToDouble(side.Text));
                rect.Area();
                rect.Perimetor();
                double a, p;
                string n;
                (a, p, n) = rect.Show();
                Cquere_propertys.Content = String.Format("aria is {0},\nperimeter is {1},\nname is '{2}'", a, p, n);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Введенное значение не похоже на не метрическую систему счета вы были признаны инагентом");
            }

            side1.Text = ""; side2.Text = "";
        }

        public void Cercle_Button(object sender, RoutedEventArgs e)
        {
            try
            {
                libs.Circle rect = new libs.Circle(Convert.ToDouble(radius.Text));
                rect.Area();
                rect.Perimetor();
                double a, p;
                string n;
                (a, p, n) = rect.Show();
                Sercle_propertys.Content = String.Format("aria is {0},\nperimeter is {1},\nname is '{2}'", a, p, n);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Введенное значение не похоже на не метрическую систему счета вы были признаны инагентом");
            }

            side1.Text = ""; side2.Text = "";
        }
    }
}

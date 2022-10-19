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
using _5.a.libs;

namespace _5.a
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int money;
        private int change;
        private int price;
        private string tipe;
        public MainWindow()
        {
            startingState();
            InitializeComponent();
        }
        private void startingState()
        {
            this.change = 0;
            this.money = 0;
            this.price = 0;
            this.tipe = "americano";
        }

        /// <summary>
        /// money inmort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                money+=Convert.ToInt32(TexBox1.Text);
                TexBox1.Text = "";
                mony_now.Content = "Внесенная сумма: "+ this.money;
            }
            catch (FormatException ex)
            {
                TexBox1.Text = "";
                MessageBox.Show("Введенное значение не похоже на деньги нашего государства вы были признаны инагентом");
            }
            update();
        }

        private void image_update1()
        {
            Image_americano.Visibility = Visibility.Hidden;
            Image_cacao.Visibility = Visibility.Hidden;
            Image_capuchino.Visibility = Visibility.Hidden;
            Image_espresso.Visibility = Visibility.Hidden;
        }
        private void image_update2()
        {
            Image_milk_endgoal.Visibility = Visibility.Hidden;
            Image_sugar.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            //MessageBox.Show(pressed.Content.ToString());
            image_update1();
            if (pressed.Content.ToString() == "Американо")
            {
                this.tipe = "americano";
                americano americano = new americano();
                this.price = americano.price;
                Image_americano.Visibility = Visibility.Visible;
            }
            if (pressed.Content.ToString() == "Капучино")
            {
                this.tipe = "capuchino";
                capuchino temp = new capuchino();
                this.price = temp.price;
                Image_capuchino.Visibility = Visibility.Visible;
            }
            if (pressed.Content.ToString() == "Эспрессо")
            {
                this.tipe = "espresso";
                espresso temp = new espresso();
                this.price = temp.price;
                Image_espresso.Visibility = Visibility.Visible;
            }
            if (pressed.Content.ToString() == "Какао")
            {
                this.tipe = "cacao";
                cacao temp = new cacao();
                this.price = temp.price;
                Image_cacao.Visibility = Visibility.Visible;
            }
            update();
        }
        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            update();
        }

        /// <summary>
        /// update all
        /// </summary>
        private void update()
        {
            int temp = 0;
            image_update2();
            if (checkBox1.IsChecked == true) { temp += 10; Image_sugar.Visibility = Visibility.Visible; }
            if (checkBox2.IsChecked == true) { temp += 10; Image_milk_endgoal.Visibility = Visibility.Visible; }
            mony_for.Content = "Цена напитка: " + Convert.ToString(this.price + temp);
            mony_out.Content = "Сдача: " + Convert.ToString(this.money - this.price + temp);
            if ((this.price + temp > this.money) || (this.price == 0)) { button2.IsEnabled = false; mony_out.Content = "Сдача: 0"; } else { button2.IsEnabled = true; mony_out.Content = "Сдача: " + Convert.ToString(this.money - this.price - temp);this.change = this.money - this.price - temp; }
        }
        /// <summary>
        /// start coffe prosessing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Enjoy! your "+ Convert.ToString(this.tipe)+" for the price of "+ Convert.ToString(this.money-this.change)+"p and take your exes: "+ Convert.ToString(this.change));
        }
    }
}

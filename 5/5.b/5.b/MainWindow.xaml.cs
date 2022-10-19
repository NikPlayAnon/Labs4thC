using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace _5.b
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int flors;
        public int current_flore = 1;
        public lift_action elevator;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void button1_clicked(object sender, RoutedEventArgs e)
        {

            try
            {
                this.flors += Convert.ToInt32(TextBox1.Text);
                TextBox1.Text = "";
                if (this.flors > 1)
                {
                    step_2();
                    elevator = new lift_action(this.flors);
                    Door_action.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Have you ever seen an elevator for les then 1 flore?");
                }
            }
            catch (FormatException ex)
            {
                TextBox1.Text = "";
                MessageBox.Show("Введенное значение не похоже на не метрическую систему счета вы были признаны инагентом");
            }
        }
        public void step_2()
        {
            int L = 17;
            int U = 200;
            for (int i = 1; i < this.flors+1; i++)
            {
                
                var button = new Button() { Content = Convert.ToString(i) }; // Creating button
                button.Click += Button_Click; //Hooking up to event
                button.Height = 30;
                button.Width = 40;
                button.Visibility = Visibility.Visible;
                button.Margin = new Thickness(L, U, this.Width-button.Width-L-10, this.Height-button.Height-U-35);
                // MessageBox.Show(Convert.ToString(L)+" "+ Convert.ToString(U)+" "+ Convert.ToString(this.Width - button.Width - L - 10) +" "+ Convert.ToString(this.Height - button.Height - U- 35));
                myGrid.Children.Add(button); //Adding to grid or other parent
                L += 40;
                if ((i) % 5 == 0)
                {
                    L -= 40 * 5;
                    U += 35;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e) //Event which will be triggerd on click of ya button
        {
            Button prosseced = (Button)sender;
            int temp = this.elevator.currentFlore;
            if (this.elevator.move(Convert.ToInt32(prosseced.Content.ToString())) == false)
            {
                MessageBox.Show("Fail. Doors are open");
            }
            else
            {
                if (this.elevator.currentFlore > temp)
                {
                    animation_up(sender,e);
                }
                if (this.elevator.currentFlore < temp)
                {
                    animation_Down(sender, e);
                }
            }
            CFlore.Content = "Curent flore: " + Convert.ToString( this.elevator.currentFlore);
            Door_action.IsEnabled = true;
        }
        public void animation_up(object sender, RoutedEventArgs e)
        {
            
        }
        public void animation_Down(object sender, RoutedEventArgs e)
        {
            
        }
        private void button_Door(object sender, RoutedEventArgs e)
        {
            this.elevator.close_doors();
            Door_action.IsEnabled = false;
        }
    }
}

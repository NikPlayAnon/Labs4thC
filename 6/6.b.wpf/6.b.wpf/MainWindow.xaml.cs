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
using _6.b.wpf.libs;

namespace _6.b.wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Deck deck;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void NDeck(object sender, RoutedEventArgs e)
        {
            clear_Grid();
            deck = new Deck();
            Render_the_cards();
            shuffle_button.IsEnabled = true;
        }

        public void Shuffle_Button_action(object sender, RoutedEventArgs e)
        {
            clear_Grid();
            deck.Shuffle();
            Render_the_cards();
            
        }

        public void clear_Grid()
        {
            var b1 = start_button;
            var b2 = shuffle_button;
            myGrid.Children.Clear();
            myGrid.Children.Add(b1);
            myGrid.Children.Add(b2);
        }

        public void Render_the_cards()
        {

            int H = 122, W = 171;
            int Left = 10, Up = 100;
            this.Width = H * 14;
            this.Height = W * 5;
            string[] imgs = new string[52];
            for (int i = 0; i < 52; i++)
            {
                imgs[i] = deck.GetCard(i);
            }
            for (int i = 0; i < 52; i++)
            {
                /*BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"/cards_img\10Clubs.png");
                bitmap.EndInit();*/

                var img = new Image();//new BitmapImage(new Uri("cards_img/" + imgs[i] + ".png"), UriKind.Relative) }; // Creating button
                Uri resourceUri = new Uri("/cards_img/" + imgs[i].ToString() + ".png", UriKind.Relative);
                img.Source = new BitmapImage(resourceUri);
                img.Height = W;
                img.Width = H;
                img.Visibility = Visibility.Visible;
                img.Margin = new Thickness(Left, Up, this.Width - img.Width - Left - 20, this.Height - img.Height - Up - 35);
                // MessageBox.Show(Convert.ToString(L)+" "+ Convert.ToString(U)+" "+ Convert.ToString(this.Width - button.Width - L - 10) +" "+ Convert.ToString(this.Height - button.Height - U- 35));
                myGrid.Children.Add(img); //Adding to grid or other parent
                Left += H;
                if ((i + 1) % 13 == 0)
                {
                    Left -= H * 13;
                    Up += W + 10;
                }
            }
        }
    }
}
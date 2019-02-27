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
using System.Windows.Threading;


namespace BubbleShooterCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dt = new DispatcherTimer();
        int score = 0;

        public MainWindow()
        {
            InitializeComponent();

            dt.Start();


        }
        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Instructions_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("How to Play? Click on the bubbles to make them pop. Don't pop the bombs or you lose points. Get the highest score in 15 seconds. Good Luck!", "Instructions");
        }

        private void Imagebutton_Click(object sender, RoutedEventArgs e)
        {
            ball.Visibility = Visibility.Hidden;
            imagebutton.Click -= Imagebutton_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton1_Click(object sender, RoutedEventArgs e)
        {
            ball1.Visibility = Visibility.Hidden;
            imagebutton1.Click -= Imagebutton1_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton44_Click(object sender, RoutedEventArgs e)
        {
            ball44.Visibility = Visibility.Hidden;
            imagebutton44.Click -= Imagebutton44_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton48_Click(object sender, RoutedEventArgs e)
        {
            ball48.Visibility = Visibility.Hidden;
            imagebutton48.Click -= Imagebutton48_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton47_Click(object sender, RoutedEventArgs e)
        {
            ball47.Visibility = Visibility.Hidden;
            imagebutton47.Click -= Imagebutton47_Click;
            score = score + 20;
            Score.Content = score.ToString();
        }

        private void Imagebutton46_Click(object sender, RoutedEventArgs e)
        {
            ball46.Visibility = Visibility.Hidden;
            imagebutton46.Click -= Imagebutton46_Click;
            score = score - 15;
            Score.Content = score.ToString();
        }

        private void Imagebutton45_Click(object sender, RoutedEventArgs e)
        {
            ball45.Visibility = Visibility.Hidden;
            imagebutton45.Click -= Imagebutton45_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton2_Click(object sender, RoutedEventArgs e)
        {
            ball2.Visibility = Visibility.Hidden;
            imagebutton2.Click -= Imagebutton2_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton4_Click(object sender, RoutedEventArgs e)
        {
            ball4.Visibility = Visibility.Hidden;
            imagebutton4.Click -= Imagebutton4_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton43_Click(object sender, RoutedEventArgs e)
        {
            ball43.Visibility = Visibility.Hidden;
            imagebutton43.Click -= Imagebutton43_Click;
            score = score + 20;
            Score.Content = score.ToString();
        }

        private void Imagebutton42_Click(object sender, RoutedEventArgs e)
        {
            ball42.Visibility = Visibility.Hidden;
            imagebutton42.Click -= Imagebutton42_Click;
            score = score - 15;
            Score.Content = score.ToString();
        }

        private void Imagebutton41_Click(object sender, RoutedEventArgs e)
        {
            ball41.Visibility = Visibility.Hidden;
            imagebutton41.Click -= Imagebutton41_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton40_Click(object sender, RoutedEventArgs e)
        {
            ball40.Visibility = Visibility.Hidden;
            imagebutton40.Click -= Imagebutton40_Click;
            score = score - 15;
            Score.Content = score.ToString();
        }

        private void Imagebutton39_Click(object sender, RoutedEventArgs e)
        {
            ball39.Visibility = Visibility.Hidden;
            imagebutton39.Click -= Imagebutton39_Click;
            score = score + 20;
            Score.Content = score.ToString();
        }
        private void Imagebutton36_Click(object sender, RoutedEventArgs e)
        {
            ball36.Visibility = Visibility.Hidden;
            imagebutton36.Click -= Imagebutton36_Click;
            score = score - 15;
            Score.Content = score.ToString();
        }

        private void Imagebutton6_Click(object sender, RoutedEventArgs e)
        {
            ball6.Visibility = Visibility.Hidden;
            imagebutton6.Click -= Imagebutton6_Click;
            score = score - 15;
            Score.Content = score.ToString();
        }

        private void Imagebutton14_Click(object sender, RoutedEventArgs e)
        {
            ball14.Visibility = Visibility.Hidden;
            imagebutton14.Click -= Imagebutton14_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton28_Click(object sender, RoutedEventArgs e)
        {
            ball28.Visibility = Visibility.Hidden;
            imagebutton28.Click -= Imagebutton28_Click;
            score = score + 20;
            Score.Content = score.ToString();
        }

        private void Imagebutton29_Click(object sender, RoutedEventArgs e)
        {
            ball29.Visibility = Visibility.Hidden;
            imagebutton29.Click -= Imagebutton29_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton15_Click(object sender, RoutedEventArgs e)
        {
            ball15.Visibility = Visibility.Hidden;
            imagebutton15.Click -= Imagebutton15_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton27_Click(object sender, RoutedEventArgs e)
        {
            ball27.Visibility = Visibility.Hidden;
            imagebutton27.Click -= Imagebutton27_Click;
            score = score - 15;
            Score.Content = score.ToString();
        }

        private void Imagebutton30_Click(object sender, RoutedEventArgs e)
        {
            ball30.Visibility = Visibility.Hidden;
            imagebutton30.Click -= Imagebutton30_Click;
            score = score - 15;
            Score.Content = score.ToString();
        }

        private void Imagebutton37_Click(object sender, RoutedEventArgs e)
        {
            ball37.Visibility = Visibility.Hidden;
            imagebutton37.Click -= Imagebutton37_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton5_Click(object sender, RoutedEventArgs e)
        {
            ball5.Visibility = Visibility.Hidden;
            imagebutton5.Click -= Imagebutton5_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton17_Click(object sender, RoutedEventArgs e)
        {
            ball17.Visibility = Visibility.Hidden;
            imagebutton17.Click -= Imagebutton17_Click;
            score = score + 20;
            Score.Content = score.ToString();
        }

        private void Imagebutton26_Click(object sender, RoutedEventArgs e)
        {
            ball26.Visibility = Visibility.Hidden;
            imagebutton26.Click -= Imagebutton26_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton31_Click(object sender, RoutedEventArgs e)
        {
            ball31.Visibility = Visibility.Hidden;
            imagebutton31.Click -= Imagebutton31_Click;
            score = score + 20;
            Score.Content = score.ToString();
        }

        private void Imagebutton38_Click(object sender, RoutedEventArgs e)
        {
            ball38.Visibility = Visibility.Hidden;
            imagebutton38.Click -= Imagebutton38_Click;
            score = score - 15;
            Score.Content = score.ToString();
        }

        private void Imagebutton3_Click(object sender, RoutedEventArgs e)
        {
            ball3.Visibility = Visibility.Hidden;
            imagebutton3.Click -= Imagebutton3_Click;
            score = score - 15;
            Score.Content = score.ToString();
        }

        private void Imagebutton8_Click(object sender, RoutedEventArgs e)
        {
            ball8.Visibility = Visibility.Hidden;
            imagebutton8.Click -= Imagebutton8_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton18_Click(object sender, RoutedEventArgs e)
        {
            ball18.Visibility = Visibility.Hidden;
            imagebutton18.Click -= Imagebutton18_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton25_Click(object sender, RoutedEventArgs e)
        {
            ball.Visibility = Visibility.Hidden;
            imagebutton25.Click -= Imagebutton25_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton32_Click(object sender, RoutedEventArgs e)
        {
            ball32.Visibility = Visibility.Hidden;
            imagebutton32.Click -= Imagebutton32_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton9_Click(object sender, RoutedEventArgs e)
        {
            ball9.Visibility = Visibility.Hidden;
            imagebutton9.Click -= Imagebutton9_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton7_Click(object sender, RoutedEventArgs e)
        {
            ball7.Visibility = Visibility.Hidden;
            imagebutton7.Click -= Imagebutton7_Click;
            score = score + 20;
            Score.Content = score.ToString();
        }

        private void Imagebutton19_Click(object sender, RoutedEventArgs e)
        {
            ball19.Visibility = Visibility.Hidden;
            imagebutton19.Click -= Imagebutton19_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton24_Click(object sender, RoutedEventArgs e)
        {
            ball24.Visibility = Visibility.Hidden;
            imagebutton24.Click -= Imagebutton24_Click;
            score = score - 15;
            Score.Content = score.ToString();
        }

        private void Imagebutton33_Click(object sender, RoutedEventArgs e)
        {
            ball33.Visibility = Visibility.Hidden;
            imagebutton33.Click -= Imagebutton33_Click;
            score = score + 20;
            Score.Content = score.ToString();
        }

        private void Imagebutton10_Click(object sender, RoutedEventArgs e)
        {
            ball10.Visibility = Visibility.Hidden;
            imagebutton10.Click -= Imagebutton10_Click;
            score = score + 20;
            Score.Content = score.ToString();
        }

        private void Imagebutton12_Click(object sender, RoutedEventArgs e)
        {
            ball12.Visibility = Visibility.Hidden;
            imagebutton12.Click -= Imagebutton12_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton20_Click(object sender, RoutedEventArgs e)
        {
            ball20.Visibility = Visibility.Hidden;
            imagebutton20.Click -= Imagebutton20_Click;
            score = score - 15;
            Score.Content = score.ToString();
        }

        private void Imagebutton23_Click(object sender, RoutedEventArgs e)
        {
            ball23.Visibility = Visibility.Hidden;
            imagebutton23.Click -= Imagebutton23_Click;
            score = score + 20;
            Score.Content = score.ToString();
        }

        private void Imagebutton34_Click(object sender, RoutedEventArgs e)
        {
            ball34.Visibility = Visibility.Hidden;
            imagebutton34.Click -= Imagebutton34_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton11_Click(object sender, RoutedEventArgs e)
        {
            ball11.Visibility = Visibility.Hidden;
            imagebutton11.Click -= Imagebutton11_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton13_Click(object sender, RoutedEventArgs e)
        {
            ball13.Visibility = Visibility.Hidden;
            imagebutton13.Click -= Imagebutton13_Click;
            score = score - 15;
            Score.Content = score.ToString();
        }

        private void Imagebutton21_Click(object sender, RoutedEventArgs e)
        {
            ball21.Visibility = Visibility.Hidden;
            imagebutton21.Click -= Imagebutton21_Click;
            score = score + 10;
            Score.Content = score.ToString();
        }

        private void Imagebutton22_Click(object sender, RoutedEventArgs e)
        {
            ball22.Visibility = Visibility.Hidden;
            imagebutton22.Click -= Imagebutton22_Click;
            score = score + 20;
            Score.Content = score.ToString();
        }

        private void Imagebutton35_Click(object sender, RoutedEventArgs e)
        {
            ball35.Visibility = Visibility.Hidden;
            imagebutton35.Click -= Imagebutton35_Click;
            Score.Content = score.ToString();
        }
        private void Imagebutton49_Click(object sender, RoutedEventArgs e)
        {
            ball49.Visibility = Visibility.Hidden;
            imagebutton49.Click -= Imagebutton49_Click;
            score = score + 10;
            Score.Content = score.ToString();
           
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += Dt_Timer;
            dt.Start();

        }
        private int increment = 16;
        private void Dt_Timer(object sender, EventArgs e)
        {

            increment--;
            if(increment == 0)
            {
                dt.Stop();
                MessageBox.Show("The score is " + score.ToString(), "Game Over");
            }
            Timer.Content = increment.ToString();
                
        }

        
    }
}  

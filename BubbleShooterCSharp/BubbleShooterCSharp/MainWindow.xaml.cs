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
        }

        private void Imagebutton1_Click(object sender, RoutedEventArgs e)
        {
            ball1.Visibility = Visibility.Hidden;
        }

        private void Imagebutton44_Click(object sender, RoutedEventArgs e)
        {
            ball44.Visibility = Visibility.Hidden;
        }

        private void Imagebutton48_Click(object sender, RoutedEventArgs e)
        {
            ball48.Visibility = Visibility.Hidden;
        }

        private void Imagebutton47_Click(object sender, RoutedEventArgs e)
        {
            ball47.Visibility = Visibility.Hidden;
        }

        private void Imagebutton46_Click(object sender, RoutedEventArgs e)
        {
            ball46.Visibility = Visibility.Hidden;
        }

        private void Imagebutton45_Click(object sender, RoutedEventArgs e)
        {
            ball45.Visibility = Visibility.Hidden;
        }

        private void Imagebutton2_Click(object sender, RoutedEventArgs e)
        {
            ball2.Visibility = Visibility.Hidden;
        }

        private void Imagebutton4_Click(object sender, RoutedEventArgs e)
        {
            ball4.Visibility = Visibility.Hidden;
        }

        private void Imagebutton43_Click(object sender, RoutedEventArgs e)
        {
            ball43.Visibility = Visibility.Hidden;
        }

        private void Imagebutton42_Click(object sender, RoutedEventArgs e)
        {
            ball42.Visibility = Visibility.Hidden;
        }

        private void Imagebutton41_Click(object sender, RoutedEventArgs e)
        {
            ball41.Visibility = Visibility.Hidden;
        }

        private void Imagebutton40_Click(object sender, RoutedEventArgs e)
        {
            ball40.Visibility = Visibility.Hidden;
        }

        private void Imagebutton39_Click(object sender, RoutedEventArgs e)
        {
            ball39.Visibility = Visibility.Hidden;
        }
        private void Imagebutton36_Click(object sender, RoutedEventArgs e)
        {
            ball36.Visibility = Visibility.Hidden;
        }

        private void Imagebutton6_Click(object sender, RoutedEventArgs e)
        {
            ball6.Visibility = Visibility.Hidden;
        }

        private void Imagebutton14_Click(object sender, RoutedEventArgs e)
        {
            ball14.Visibility = Visibility.Hidden;
        }

        private void Imagebutton28_Click(object sender, RoutedEventArgs e)
        {
            ball28.Visibility = Visibility.Hidden;
        }

        private void Imagebutton29_Click(object sender, RoutedEventArgs e)
        {
            ball29.Visibility = Visibility.Hidden;
        }

        private void Imagebutton15_Click(object sender, RoutedEventArgs e)
        {
            ball15.Visibility = Visibility.Hidden;
        }

        private void Imagebutton27_Click(object sender, RoutedEventArgs e)
        {
            ball27.Visibility = Visibility.Hidden;
        }

        private void Imagebutton30_Click(object sender, RoutedEventArgs e)
        {
            ball30.Visibility = Visibility.Hidden;
        }

        private void Imagebutton37_Click(object sender, RoutedEventArgs e)
        {
            ball37.Visibility = Visibility.Hidden;
        }

        private void Imagebutton5_Click(object sender, RoutedEventArgs e)
        {
            ball5.Visibility = Visibility.Hidden;
        }

        private void Imagebutton17_Click(object sender, RoutedEventArgs e)
        {
            ball17.Visibility = Visibility.Hidden;
        }

        private void Imagebutton26_Click(object sender, RoutedEventArgs e)
        {
            ball26.Visibility = Visibility.Hidden;
        }

        private void Imagebutton31_Click(object sender, RoutedEventArgs e)
        {
            ball31.Visibility = Visibility.Hidden;

        }

        private void Imagebutton38_Click(object sender, RoutedEventArgs e)
        {
            ball38.Visibility = Visibility.Hidden;

        }

        private void Imagebutton3_Click(object sender, RoutedEventArgs e)
        {
            ball3.Visibility = Visibility.Hidden;

        }

        private void Imagebutton8_Click(object sender, RoutedEventArgs e)
        {
            ball8.Visibility = Visibility.Hidden;

        }

        private void Imagebutton18_Click(object sender, RoutedEventArgs e)
        {
            ball18.Visibility = Visibility.Hidden;

        }

        private void Imagebutton25_Click(object sender, RoutedEventArgs e)
        {
            ball.Visibility = Visibility.Hidden;

        }

        private void Imagebutton32_Click(object sender, RoutedEventArgs e)
        {
            ball32.Visibility = Visibility.Hidden;

        }

        private void Imagebutton9_Click(object sender, RoutedEventArgs e)
        {
            ball9.Visibility = Visibility.Hidden;

        }

        private void Imagebutton7_Click(object sender, RoutedEventArgs e)
        {
            ball7.Visibility = Visibility.Hidden;

        }

        private void Imagebutton19_Click(object sender, RoutedEventArgs e)
        {
            ball19.Visibility = Visibility.Hidden;

        }

        private void Imagebutton24_Click(object sender, RoutedEventArgs e)
        {
            ball24.Visibility = Visibility.Hidden;

        }

        private void Imagebutton33_Click(object sender, RoutedEventArgs e)
        {
            ball33.Visibility = Visibility.Hidden;

        }

        private void Imagebutton10_Click(object sender, RoutedEventArgs e)
        {
            ball10.Visibility = Visibility.Hidden;

        }

        private void Imagebutton12_Click(object sender, RoutedEventArgs e)
        {
            ball12.Visibility = Visibility.Hidden;

        }

        private void Imagebutton20_Click(object sender, RoutedEventArgs e)
        {
            ball20.Visibility = Visibility.Hidden;

        }

        private void Imagebutton23_Click(object sender, RoutedEventArgs e)
        {
            ball23.Visibility = Visibility.Hidden;

        }

        private void Imagebutton34_Click(object sender, RoutedEventArgs e)
        {
            ball34.Visibility = Visibility.Hidden;

        }

        private void Imagebutton11_Click(object sender, RoutedEventArgs e)
        {
            ball11.Visibility = Visibility.Hidden;

        }

        private void Imagebutton13_Click(object sender, RoutedEventArgs e)
        {
            ball13.Visibility = Visibility.Hidden;

        }

        private void Imagebutton21_Click(object sender, RoutedEventArgs e)
        {
            ball21.Visibility = Visibility.Hidden;

        }

        private void Imagebutton22_Click(object sender, RoutedEventArgs e)
        {
            ball22.Visibility = Visibility.Hidden;

        }

        private void Imagebutton35_Click(object sender, RoutedEventArgs e)
        {
            ball35.Visibility = Visibility.Hidden;

        }
        private void Imagebutton49_Click(object sender, RoutedEventArgs e)
        {
            ball49.Visibility = Visibility.Hidden;
            
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

            }
            Timer.Content = increment.ToString();
                
        }

        public void Score_Click(object sender, RoutedEventArgs e)
        {
            
            int Score = 0;
            if (true == int.TryParse(Score.ToString(), out Score))
            {
                Score = Score + Score++;
            }
            
        }
    }
}  

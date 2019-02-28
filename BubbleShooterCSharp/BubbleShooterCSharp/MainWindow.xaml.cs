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
using System.Media;


namespace BubbleShooterCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dt = new DispatcherTimer();
        int score = 0;
        BitmapImage[] Bubbles;
        BitmapImage[] Bomb;
        Random rnd;
        String[] arrayOfBombLocation = new string[7];
        public SoundPlayer player = new SoundPlayer(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb2.wav");
        Image[,] BubbleArray;
        String[] NumberArray;




        public MainWindow()
        {
            InitializeComponent();

            dt.Start();
            bubbleImage();
            gameBombRandomization();


        }

        public void bubbleImage()
        {
           

            

            BubbleArray = new Image[7, 7];
            BubbleArray[0, 0] = ball;
            BubbleArray[0, 1] = ball1;
            BubbleArray[0, 2] = ball2;
            BubbleArray[0, 3] = ball3;
            BubbleArray[0, 4] = ball4;
            BubbleArray[0, 5] = ball5;
            BubbleArray[0, 6] = ball6;
            BubbleArray[1, 0] = ball7;
            BubbleArray[1, 1] = ball8;
            BubbleArray[1, 2] = ball9;
            BubbleArray[1, 3] = ball10;
            BubbleArray[1, 4] = ball11;
            BubbleArray[1, 5] = ball12;
            BubbleArray[1, 6] = ball13;
            BubbleArray[2, 0] = ball14;
            BubbleArray[2, 1] = ball15;
            BubbleArray[2, 2] = ball17;
            BubbleArray[2, 3] = ball18;
            BubbleArray[2, 4] = ball19;
            BubbleArray[2, 5] = ball20;
            BubbleArray[2, 6] = ball21;
            BubbleArray[3, 0] = ball22;
            BubbleArray[3, 1] = ball23;
            BubbleArray[3, 2] = ball24;
            BubbleArray[3, 3] = ball25;
            BubbleArray[3, 4] = ball26;
            BubbleArray[3, 5] = ball27;
            BubbleArray[3, 6] = ball28;
            BubbleArray[4, 0] = ball29;
            BubbleArray[4, 1] = ball30;
            BubbleArray[4, 2] = ball31;
            BubbleArray[4, 3] = ball32;
            BubbleArray[4, 4] = ball33;
            BubbleArray[4, 5] = ball34;
            BubbleArray[4, 6] = ball35;
            BubbleArray[5, 0] = ball36;
            BubbleArray[5, 1] = ball37;
            BubbleArray[5, 2] = ball38;
            BubbleArray[5, 3] = ball39;
            BubbleArray[5, 4] = ball40;
            BubbleArray[5, 5] = ball41;
            BubbleArray[5, 6] = ball42;
            BubbleArray[6, 0] = ball43;
            BubbleArray[6, 1] = ball44;
            BubbleArray[6, 2] = ball45;
            BubbleArray[6, 3] = ball46;
            BubbleArray[6, 4] = ball47;
            BubbleArray[6, 5] = ball48;
            BubbleArray[6, 6] = ball49;

            Bubbles = new BitmapImage[3];
            Bubbles[0] = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\basketball_ball.png"));
            Bubbles[1] = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Blue-Ball.png"));
           // Bubbles[2] = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
            Bubbles[2] = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\green-ball.png"));
            Bomb = new BitmapImage[1];
            Bomb[0] = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
            rnd = new Random();
            
            for (int i = 0; i < BubbleArray.GetLength(0); i++)
            {
                for (int b = 0; b < BubbleArray.GetLength(1); b++)
                {
                    int image = rnd.Next(3);
                    BubbleArray[i, b].Source = Bubbles[image];
                }
            }


        }
        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void Instructions_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("How to Play? Click on the bubbles to make them pop. Don't pop the bombs or you lose points. Get the highest score in 15 seconds. Good Luck!", "Instructions");
        } 
        public void Point20()
        {
            score = score + 20;
            Score.Content = score.ToString();
        }
        public void Point10()
        {
            score = score + 10;
            Score.Content = score.ToString();
        }
        public void pointMinus15()
        {
            score = score - 15;
            Score.Content = score.ToString();
        }
        public void scorePoint(Image img)
        {
                    if (img.Source == Bubbles[0])
                    {
                        Point10();
                    }
                    if (img.Source == Bubbles[1])
                    {
                        Point10();
                    }
                    if (img.Source == Bubbles[2])
                    {
                        Point20();
                    }
            
        }
        
        public void gameBombRandomization()
        {
            // generate 7 random numbers btw 0 and 50 and store in an array of strings
            //where each string is a name of any button on the game borad
            // example if we generate 33 then imagebutton33 is created as "imagebutton"+"33"
            // then is each button click event listener we check is the name of the current 
            // button is found in the array or list
           for (int i = 0; i < 7; i++)
           {
                int number = getRandomNumber();
                string str = "imagebutton" + number;
                arrayOfBombLocation[i] = str;
           }
           
        }
        public int getRandomNumber()
        {
            
            return rnd.Next(0, 49);
        }
        private void Imagebutton_Click(object sender, RoutedEventArgs e)
        {

            ball.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            //ball.Source = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
           
            //imagebutton.Click -= Imagebutton_Click;
            Image img = ball;
      
            scorePoint(ball);
            
        }

        private void Imagebutton1_Click(object sender, RoutedEventArgs e)
        {
            ball1.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton1.Click -= Imagebutton1_Click;
            Image img = ball1;
            scorePoint(ball1);
        }

        private void Imagebutton44_Click(object sender, RoutedEventArgs e)
        {
            ball44.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton44.Click -= Imagebutton44_Click;
            Image img = ball44;
            scorePoint(ball44);
        }

        private void Imagebutton48_Click(object sender, RoutedEventArgs e)
        {
            ball48.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton48.Click -= Imagebutton48_Click;
            Image img = ball48;
            scorePoint(ball48);
        }

        private void Imagebutton47_Click(object sender, RoutedEventArgs e)
        {
            ball47.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton47.Click -= Imagebutton47_Click;
            Image img = ball47;
            scorePoint(ball47);
        }

        private void Imagebutton46_Click(object sender, RoutedEventArgs e)
        {
            ball46.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton46.Click -= Imagebutton46_Click;
            Image img = ball46;
            scorePoint(ball46);
        }

        private void Imagebutton45_Click(object sender, RoutedEventArgs e)
        {
            ball45.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton45.Click -= Imagebutton45_Click;
            Image img = ball45;
            scorePoint(ball45);
        }

        private void Imagebutton2_Click(object sender, RoutedEventArgs e)
        {
            ball2.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton2.Click -= Imagebutton2_Click;
            Image img = ball2;
            scorePoint(ball2);
        }

        private void Imagebutton4_Click(object sender, RoutedEventArgs e)
        {
            ball4.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton4.Click -= Imagebutton4_Click;
            Image img = ball4;
            scorePoint(ball4);
        }

        private void Imagebutton43_Click(object sender, RoutedEventArgs e)
        {
            ball43.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            //ball43.Source = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
            
            imagebutton43.Click -= Imagebutton43_Click;
            Image img = ball43;
            scorePoint(ball43);
        }

        private void Imagebutton42_Click(object sender, RoutedEventArgs e)
        {
            ball42.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton42.Click -= Imagebutton42_Click;
            Image img = ball42;
            scorePoint(ball42);
        }

        private void Imagebutton41_Click(object sender, RoutedEventArgs e)
        {
            ball41.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton41.Click -= Imagebutton41_Click;
            Image img = ball41;
            scorePoint(ball41);
        }

        private void Imagebutton40_Click(object sender, RoutedEventArgs e)
        {
            ball40.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton40.Click -= Imagebutton40_Click;
            Image img = ball40;
            scorePoint(ball40);
        }

        private void Imagebutton39_Click(object sender, RoutedEventArgs e)
        {
            ball39.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton39.Click -= Imagebutton39_Click;
            Image img = ball39;
            scorePoint(ball39);
        }
        private void Imagebutton36_Click(object sender, RoutedEventArgs e)
        {
            ball36.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton36.Click -= Imagebutton36_Click;
            Image img = ball36;
            scorePoint(ball36);
        }

        private void Imagebutton6_Click(object sender, RoutedEventArgs e)
        {
            ball6.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton6.Click -= Imagebutton6_Click;
            Image img = ball6;
            scorePoint(ball6);
        }

        private void Imagebutton14_Click(object sender, RoutedEventArgs e)
        {
            ball14.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton14.Click -= Imagebutton14_Click;
            Image img = ball14;
            scorePoint(ball14);
        }

        private void Imagebutton28_Click(object sender, RoutedEventArgs e)
        {
            ball28.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            //ball28.Source = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
            
            imagebutton28.Click -= Imagebutton28_Click;
            Image img = ball28;
            scorePoint(ball28);
        }

        private void Imagebutton29_Click(object sender, RoutedEventArgs e)
        {
            ball29.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton29.Click -= Imagebutton29_Click;
            Image img = ball29;
            scorePoint(ball29);
        }

        private void Imagebutton15_Click(object sender, RoutedEventArgs e)
        {
            ball15.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton15.Click -= Imagebutton15_Click;
            Image img = ball15;
            scorePoint(ball15);
        }

        private void Imagebutton27_Click(object sender, RoutedEventArgs e)
        {
            ball27.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton27.Click -= Imagebutton27_Click;
            Image img = ball27;
            scorePoint(ball27);
        }

        private void Imagebutton30_Click(object sender, RoutedEventArgs e)
        {
            ball30.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton30.Click -= Imagebutton30_Click;
            Image img = ball30;
            scorePoint(ball30);
        }

        private void Imagebutton37_Click(object sender, RoutedEventArgs e)
        {
            ball37.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton37.Click -= Imagebutton37_Click;
            Image img = ball37;
            scorePoint(ball37);
        }

        private void Imagebutton5_Click(object sender, RoutedEventArgs e)
        {
            ball5.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton5.Click -= Imagebutton5_Click;
            Image img = ball5;
            scorePoint(ball5);
        }

        private void Imagebutton17_Click(object sender, RoutedEventArgs e)
        {
            ball17.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton17.Click -= Imagebutton17_Click;
            Image img = ball17;
            scorePoint(ball17);
        }

        private void Imagebutton26_Click(object sender, RoutedEventArgs e)
        {
            ball26.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton26.Click -= Imagebutton26_Click;
            Image img = ball26;
            scorePoint(ball26);
        }

        private void Imagebutton31_Click(object sender, RoutedEventArgs e)
        {
            ball31.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton31.Click -= Imagebutton31_Click;
            Image img = ball31;
            scorePoint(ball31);
        }

        private void Imagebutton38_Click(object sender, RoutedEventArgs e)
        {
            ball38.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton38.Click -= Imagebutton38_Click;
            Image img = ball38;
            scorePoint(ball38);
        }

        private void Imagebutton3_Click(object sender, RoutedEventArgs e)
        {
            ball3.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton3.Click -= Imagebutton3_Click;
            Image img = ball3;
            scorePoint(ball3);
        }

        private void Imagebutton8_Click(object sender, RoutedEventArgs e)
        {
            ball8.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton8.Click -= Imagebutton8_Click;
            Image img = ball8;
            scorePoint(ball8);
        }

        private void Imagebutton18_Click(object sender, RoutedEventArgs e)
        {
            ball18.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton18.Click -= Imagebutton18_Click;
            Image img = ball18;
            scorePoint(ball18);
        }

        private void Imagebutton25_Click(object sender, RoutedEventArgs e)
        {
            ball25.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            //ball25.Source = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
            
            imagebutton25.Click -= Imagebutton25_Click;
            Image img = ball25;
            scorePoint(ball25);
        }

        private void Imagebutton32_Click(object sender, RoutedEventArgs e)
        {
            ball32.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton32.Click -= Imagebutton32_Click;
            Image img = ball32;
            scorePoint(ball32);
        }

        private void Imagebutton9_Click(object sender, RoutedEventArgs e)
        {
            ball9.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton9.Click -= Imagebutton9_Click;
            Image img = ball9;
            scorePoint(ball9);
        }

        private void Imagebutton7_Click(object sender, RoutedEventArgs e)
        {
            ball7.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton7.Click -= Imagebutton7_Click;
            Image img = ball7;
            scorePoint(ball7);
        }

        private void Imagebutton19_Click(object sender, RoutedEventArgs e)
        {
            ball19.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton19.Click -= Imagebutton19_Click;
            Image img = ball19;
            scorePoint(ball19);
        }

        private void Imagebutton24_Click(object sender, RoutedEventArgs e)
        {
            ball24.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton24.Click -= Imagebutton24_Click;
            Image img = ball24;
            scorePoint(ball24);
        }

        private void Imagebutton33_Click(object sender, RoutedEventArgs e)
        {
            ball33.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton33.Click -= Imagebutton33_Click;
            Image img = ball33;
            scorePoint(ball33);
        }

        private void Imagebutton10_Click(object sender, RoutedEventArgs e)
        {
            ball10.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton10.Click -= Imagebutton10_Click;
            Image img = ball10;
            scorePoint(ball10);
        }

        private void Imagebutton12_Click(object sender, RoutedEventArgs e)
        {
            ball12.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton12.Click -= Imagebutton12_Click;
            Image img = ball12;
            scorePoint(ball12);
        }

        private void Imagebutton20_Click(object sender, RoutedEventArgs e)
        {
            ball20.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton20.Click -= Imagebutton20_Click;
            Image img = ball20;
            scorePoint(ball20);
        }

        private void Imagebutton23_Click(object sender, RoutedEventArgs e)
        {
            ball23.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton23.Click -= Imagebutton23_Click;
            Image img = ball23;
            scorePoint(ball23);
        }

        private void Imagebutton34_Click(object sender, RoutedEventArgs e)
        {
            ball34.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton34.Click -= Imagebutton34_Click;
            Image img = ball34;
            scorePoint(ball34); 
        }

        private void Imagebutton11_Click(object sender, RoutedEventArgs e)
        {
            ball11.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            
            imagebutton11.Click -= Imagebutton11_Click;
            Image img = ball11;
            scorePoint(ball11);
        }

        private void Imagebutton13_Click(object sender, RoutedEventArgs e)
        {
            ball13.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton13.Click -= Imagebutton13_Click;
            Image img = ball13;
            scorePoint(ball13);
        }

        private void Imagebutton21_Click(object sender, RoutedEventArgs e)
        {
            ball21.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton21.Click -= Imagebutton21_Click;
            Image img = ball21;
            scorePoint(ball21);
        }

        private void Imagebutton22_Click(object sender, RoutedEventArgs e)
        {
            ball22.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton22.Click -= Imagebutton22_Click;
            Image img = ball22;
            scorePoint(ball22);
        }

        private void Imagebutton35_Click(object sender, RoutedEventArgs e)
        {
            ball35.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            imagebutton35.Click -= Imagebutton35_Click;
            Image img = ball35;
            scorePoint(ball35);
        }
        private void Imagebutton49_Click(object sender, RoutedEventArgs e)
        {
            ball49.Visibility = Visibility.Hidden;
            Button bt = (Button)e.Source;
            if (arrayOfBombLocation.Contains(bt.Name))
            {
                BitmapImage bm = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
                Image mg = new Image();
                mg.Source = bm;
                bt.Content = mg;
                player.Play();
                pointMinus15();
            }
            //ball49.Source = new BitmapImage(new Uri(@"C:\Users\tech-w86.LAPTOP-3ALVMOF3\Documents\Engineering26\Week7\Day1\Sparta-global-CSharpGame\BubbleShooterCSharp\BubbleShooterCSharp\Bomb.gif"));
           
            imagebutton49.Click -= Imagebutton49_Click;
            Image img = ball49;
            scorePoint(ball49);
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

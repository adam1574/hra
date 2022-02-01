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

namespace hra
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush barva1;
        Brush barva2;
        Brush barva3;
        Brush barva4;

        public MainWindow()
        {
            InitializeComponent();
            NastavVariantu0();
            NastavBarvyPC();
            Title = $"{barva1} - {barva2} - {barva3} - {barva4}";
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse ellipse = (Ellipse)sender;

            if (ellipse.Fill.ToString() == "#FFFFFFFF")
            {
                ellipse.Fill = Brushes.Red;
            }
            else if (ellipse.Fill == Brushes.Red)
            {
                ellipse.Fill = Brushes.Green;
            }
            else if (ellipse.Fill == Brushes.Green)
            {
                ellipse.Fill = Brushes.Blue;
            }
            else if (ellipse.Fill == Brushes.Blue)
            {
                ellipse.Fill = Brushes.Yellow;
            }
            else if (ellipse.Fill == Brushes.Yellow)
            {
                ellipse.Fill = Brushes.Orange;
            }
            else if (ellipse.Fill == Brushes.Orange)
            {
                ellipse.Fill = Brushes.Pink;
            }
            else
            {
                ellipse.Fill = Brushes.Red;
            }
        }
        private void NastavElipsuEnabled (Ellipse ellipse)
        {
            ellipse.IsEnabled = true;
            ellipse.Fill = Brushes.LightGray;
            ellipse.Stroke = Brushes.Black;
            ellipse.Cursor = Cursors.Hand;
        }
        private void NastavElipsuDisabled(Ellipse ellipse)
        {
            ellipse.IsEnabled = false;
            ellipse.Fill = Brushes.White;
            ellipse.Stroke = Brushes.Gray;
        }
        
        private void NastavVariantu0()
        {
            NastavElipsuEnabled(elipse0_0);
            NastavElipsuEnabled(elipse0_1);
            NastavElipsuEnabled(elipse0_2);
            NastavElipsuEnabled(elipse0_3);

            NastavElipsuDisabled(elipse1_0);
            NastavElipsuDisabled(elipse1_1);
            NastavElipsuDisabled(elipse1_2);
            NastavElipsuDisabled(elipse1_3);

            NastavElipsuDisabled(elipse2_0);
            NastavElipsuDisabled(elipse2_1);
            NastavElipsuDisabled(elipse2_2);
            NastavElipsuDisabled(elipse2_3);
           
            NastavElipsuDisabled(elipse3_0);
            NastavElipsuDisabled(elipse3_1);
            NastavElipsuDisabled(elipse3_2);
            NastavElipsuDisabled(elipse3_3);

            NastavElipsuDisabled(elipse4_0);
            NastavElipsuDisabled(elipse4_1);
            NastavElipsuDisabled(elipse4_2);
            NastavElipsuDisabled(elipse4_3);

            NastavElipsuDisabled(elipse5_0);
            NastavElipsuDisabled(elipse5_1);
            NastavElipsuDisabled(elipse5_2);
            NastavElipsuDisabled(elipse5_3);

            NastavElipsuDisabled(elipse6_0);
            NastavElipsuDisabled(elipse6_1);
            NastavElipsuDisabled(elipse6_2);
            NastavElipsuDisabled(elipse6_3);

            NastavElipsuDisabled(elipse7_0);
            NastavElipsuDisabled(elipse7_1);
            NastavElipsuDisabled(elipse7_2);
            NastavElipsuDisabled(elipse7_3);

            NastavElipsuDisabled(elipse8_0);
            NastavElipsuDisabled(elipse8_1);
            NastavElipsuDisabled(elipse8_2);
            NastavElipsuDisabled(elipse8_3);
        }
        private void NastavBarvyPC()
        {
            barva1 = ZiskejBarvu();
            barva2 = ZiskejBarvu();
            barva3 = ZiskejBarvu();
            barva4 = ZiskejBarvu();
        }
        private Brush ZiskejBarvu()
        {
            Random random = new Random();
            int cislo = random.Next(1, 7);

            if (cislo == 1)
            {
               return Brushes.Red;
            }
            else if (cislo == 2)
            {
                return Brushes.Green;
            }
            else if (cislo == 3)
            {
                return Brushes.Blue;
            }
            else if (cislo == 4)
            {
                return Brushes.Yellow;
            }
            else if (cislo == 5)
            {
                return Brushes.Orange;
            }
            else if (cislo == 6)
            {
                return Brushes.Pink;
            }
            return Brushes.Red;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            rectangle1_0.Fill = Brushes.LightGray;
            rectangle1_1.Fill = Brushes.LightGray;
            rectangle1_2.Fill = Brushes.LightGray;
            rectangle1_3.Fill = Brushes.LightGray;
           
            //1. varianta
            
            int pocetcernych = 0;
            int pocetbilych = 0;
           
            
            if (elipse0_0.Fill == barva1)
            {
                pocetcernych++;
            }
            else if (elipse0_0.Fill == barva2 || elipse0_0.Fill == barva3 || elipse0_0.Fill == barva4)
            {
                pocetbilych++;
            }

            if (elipse0_1.Fill == barva2)
            {
                pocetcernych++;
            }
            else if (elipse0_0.Fill == barva1 || elipse0_0.Fill == barva3 || elipse0_0.Fill == barva4)
            {
                pocetbilych++;
            }

            if (elipse0_2.Fill == barva3)
            {
                pocetcernych++;
            }
            else if (elipse0_0.Fill == barva2 || elipse0_0.Fill == barva1 || elipse0_0.Fill == barva4)
            {
                pocetbilych++;
            }

            if (elipse0_3.Fill == barva4)
            {
                pocetcernych++;
            }
            else if (elipse0_0.Fill == barva2 || elipse0_0.Fill == barva3 || elipse0_0.Fill == barva1)
            {
                pocetbilych++;
            }
            
            
            if (pocetcernych > 0)
            {
                rectangle1_0.Fill = Brushes.Black;
            }
            if (pocetcernych > 1)
            {
                rectangle1_1.Fill = Brushes.Black;
            }
            if (pocetcernych > 2)
            {
                rectangle1_2.Fill = Brushes.Black;
            }
            if (pocetcernych > 3)
            {
                rectangle1_3.Fill = Brushes.Black;
                MessageBox.Show("win");
            }
        }

        
    }
}

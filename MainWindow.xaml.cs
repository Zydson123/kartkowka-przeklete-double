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

namespace kartkoweczka08
{
    /*
     Kalkulator potęg
     Podaj podstawę potęgi (input)
     podaj wykładnik (input)
     przycisk oblicz
     message box z wynikiem
     */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private double mypower(double a, double b){
            double pow = a;
            if (b == 0.5)
            {
                double x = 1;
                while (((a/x)-x)> 0.000000001)
                {
                        x+=0.0001;
                }
                pow = x;
            }
            else if (b == 0)
            {
                pow = 1;
            }
            else if(b>0)
            {
                for (int i = 1; i < b; i++)
                {
                    pow = pow * a;
                }
            }
            else if (b < 0)
            {
                b = b * -1;
                pow = b / a;
            }
            return pow;
        }
        private void oblicz(object sender,RoutedEventArgs e)
        {
            if(double.TryParse(podstawa.Text, out double a) && a > 0 && double.TryParse(wykladnik.Text, out double b))
            {
                String result = (mypower(a,b)).ToString();
                MessageBox.Show("liczba " + a + " podniesiona do potęgi: " + b + " to: " + result, "Wynik", MessageBoxButton.OK);            
            }
        }
    }
}

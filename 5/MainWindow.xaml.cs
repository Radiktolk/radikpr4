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

namespace _5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void compute()
        {

            try
            {

                double p = double.Parse(P.Text);

                if (0 < p && p < 50) { }

                else { throw new ArgumentOutOfRangeException(); }


                double q = 1 + p / 100;


                double S_(int n)
                {
                    return (10 * (1 - Math.Pow(q, n)) / (1 - q));
                }


                int k = 0;

                for (int i = 1; S_(i) <= 200; i++)
                {
                    k = i + 1;
                }

                K.Content = $"{k}";

                S.Content = $"{S_(k + 1)}";



            }

            catch
            {
                K.Content = "-";
                S.Content = "-";
            }

        }


        private void P_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }
    }
}

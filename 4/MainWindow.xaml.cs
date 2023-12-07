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

namespace _4
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

                int n = int.Parse(N.Text);

                if (n > 0) { }

                else { throw new ArgumentOutOfRangeException(); }


                int i = 1;

                if (n == 1)
                {
                    K.Content = "2";
                }

                else
                {
                    do {

                        if (i * i > n)
                        {
                            K.Content = $"{i}";
                            break;
                        }

                        i++;

                    } while (i <= n);

                }




            }

            catch
            {
                K.Content = "-";
            }

        }


        private void N_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }
    }
}

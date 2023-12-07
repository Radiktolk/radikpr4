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

namespace _6
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


                bool result = false;

                foreach (char symbol in N.Text)
                {
                    if (int.Parse($"{symbol}") % 2 == 0)
                    {
                        result = true;
                    }
                }

                Result.Content = $"{result}";

            }

            catch
            {
                Result.Content = "-";
            }

        }


        private void N_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }
    }
}

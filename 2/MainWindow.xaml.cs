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

namespace _2
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
                int m = int.Parse(M.Text);

                string result = "";

                switch (m)
                {
                    case 6:
                        result += "Шестёрка";
                        break;

                    case 7:
                        result += "Семёрка";
                        break;

                    case 8:
                        result += "Восьмёрка";
                        break;

                    case 9:
                        result += "Девятка";
                        break;

                    case 10:
                        result += "Десятка";
                        break;

                    case 11:
                        result += "Валет";
                        break;

                    case 12:
                        result += "Дама";
                        break;

                    case 13:
                        result += "Король";
                        break;

                    case 14:
                        result += "Туз";
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                switch (n)
                {
                    case 1:
                        result += " пики";
                        break;

                    case 2:
                        result += " треф";
                        break;

                    case 3:
                        result += " бубен";
                        break;

                    case 4:
                        result += " червей";
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                Result.Content = result;

            }

            catch
            {
                Result.Content = "-";
            }

        }


        private void M_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }

        private void N_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }
    }
}

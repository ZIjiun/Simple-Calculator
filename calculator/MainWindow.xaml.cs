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

namespace calculator
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                textDisplay.Text = number1.ToString();
            }
            else 
            {
                number2 = (number2 * 10) + 1;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                textDisplay.Text = number2.ToString();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            textDisplay.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            textDisplay.Text = "0";
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            textDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            textDisplay.Text = "0";
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "+":
                    textDisplay.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    textDisplay.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    textDisplay.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    textDisplay.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else 
            {
                number2 = 0;
            }
            textDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            textDisplay.Text = "0";
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                textDisplay.Text = number2.ToString();
            }
        }

        private void btnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                textDisplay.Text = number2.ToString();
            }
        }
    }
}

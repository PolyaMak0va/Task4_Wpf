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

namespace Example1_Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Dollar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double rateDollar = Convert.ToDouble(rate.Text);
                double sumDollar = Convert.ToDouble(sum.Text);

                if (rateDollar > 0 && sumDollar > 0)
                {
                    double resDoubleDollar = rateDollar * sumDollar;
                    resSum.Text = resDoubleDollar.ToString();
                }
                else
                {
                    resSum.Text = "Значение должно быть положительным";
                }
            }
            catch (FormatException ex)
            {
                resSum.Text = ex.Message;
            }
        }

        private void Euro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double rateEuro = Convert.ToDouble(rate2.Text);
                double sumEuro = Convert.ToDouble(sum2.Text);

                if (rateEuro > 0 && sumEuro > 0)
                {
                    double resDoubleEuro = rateEuro * sumEuro;
                    resSum2.Text = resDoubleEuro.ToString();
                }
                else
                {
                    resSum2.Text = "Значение должно быть положительным";
                }
            }
            catch (FormatException ex)
            {
                resSum2.Text = ex.Message;
            }
        }

        private void Hryvnia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double rateHryvnia = Convert.ToDouble(rate3.Text);
                double sumHryvnia = Convert.ToDouble(sum3.Text);

                if (rateHryvnia > 0 && sumHryvnia > 0)
                {
                    double resDoubleHryvnia = rateHryvnia * sumHryvnia;
                    resSum3.Text = resDoubleHryvnia.ToString();
                }
                else
                {
                    resSum3.Text = "Значение должно быть положительным";
                }
            }
            catch (FormatException ex)
            {
                resSum3.Text = ex.Message;
            }
        }

        private void Dram_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double rateDram = Convert.ToDouble(rate4.Text);
                double sumDram = Convert.ToDouble(sum4.Text);

                if (rateDram > 0 && sumDram > 0)
                {
                    double resDoubleDram = rateDram * sumDram;
                    resSum4.Text = resDoubleDram.ToString();
                }
                else
                {
                    resSum4.Text = "Значение должно быть положительным";
                }
            }
            catch (FormatException ex)
            {
                resSum4.Text = ex.Message;
            }
        }

        private void Inches_Click(object sender, RoutedEventArgs e)
        {
            const double inches = 0.0254;

            try
            {
                double valueInches = Convert.ToDouble(value1.Text);

                if (valueInches > 0)
                {
                    double resDoubleInches = inches * valueInches;
                    resMultiplication1.Text = resDoubleInches.ToString();
                }
                else
                {
                    resMultiplication1.Text = "Значение должно быть положительным";
                }
            }
            catch (FormatException ex)
            {
                resMultiplication1.Text = ex.Message;
            }
        }

        private void Foot_Click(object sender, RoutedEventArgs e)
        {
            const double foot = 0.3048;

            try
            {
                double valueFoot = Convert.ToDouble(value2.Text);

                if (valueFoot > 0)
                {
                    double resDoubleFoot = foot * valueFoot;
                    resMultiplication2.Text = resDoubleFoot.ToString();
                }
                else
                {
                    resMultiplication2.Text = "Значение должно быть положительным";
                }
            }
            catch (FormatException ex)
            {
                resMultiplication2.Text = ex.Message;
            }
        }

        private void Miles_Click(object sender, RoutedEventArgs e)
        {
            const double miles = 1609.34;

            try
            {
                double valueMiles = Convert.ToDouble(value3.Text);

                if (valueMiles > 0)
                {
                    double resDoubleMiles = miles * valueMiles;
                    resMultiplication3.Text = resDoubleMiles.ToString();
                }
                else
                {
                    resMultiplication3.Text = "Значение должно быть положительным";
                }
            }
            catch (FormatException ex)
            {
                resMultiplication3.Text = ex.Message;
            }
        }

        private void Verst_Click(object sender, RoutedEventArgs e)
        {
            const double verst = 1066.8;

            try
            {
                double valueVerst = Convert.ToDouble(value4.Text);

                if (valueVerst > 0)
                {
                    double resDoubleVerst = verst * valueVerst;
                    resMultiplication4.Text = resDoubleVerst.ToString();
                }
                else
                {
                    resMultiplication4.Text = "Значение должно быть положительным";
                }
            }
            catch (FormatException ex)
            {
                resMultiplication4.Text = ex.Message;
            }
        }
    }
}

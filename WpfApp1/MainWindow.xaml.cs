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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar =Convert.ToDouble (rate.Text); // обращаемся к первому textbox, там значение в строковом формате, переводим в число
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            ressum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate2.Text); 
            double sumEuro = Convert.ToDouble(sum2.Text);
            double resDouble2 = rateEuro * sumEuro;
            ressum2.Text = resDouble2.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateHrivnia = Convert.ToDouble(rate3.Text); 
            double sumHrivnia = Convert.ToDouble(sum3.Text);
            double resDouble3 = rateHrivnia * sumHrivnia;
            ressum3.Text = resDouble3.ToString();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDramas = Convert.ToDouble(rate4.Text); 
            double sumDramas = Convert.ToDouble(sum4.Text);
            double resDouble4 = rateDramas * sumDramas;
            ressum4.Text = resDouble4.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double Len1 = Convert.ToDouble(len1.Text);
            
            double Len1_Metr = Len1 * 0.025;// перевод дюймов в метры 
            result1.Text = Len1_Metr.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double Len2 = Convert.ToDouble(len2.Text);

            double Len2_Metr = Len2 * 0.3;// перевод футов в метры 
            result2.Text = Len2_Metr.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double Len3 = Convert.ToDouble(len3.Text);

            double Len3_Metr = Len3 * 1609.34;// перевод мили в метры 
            result3.Text = Len3_Metr.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double Len4 = Convert.ToDouble(len4.Text);

            double Len4_Metr = Len4 * 1066.8;// перевод верст в метры 
            result4.Text = Len4_Metr.ToString();
        }
    }
}

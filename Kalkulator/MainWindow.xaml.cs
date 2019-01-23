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

namespace Kalkulator
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

        int a;
        int b;
        int c;

        private void BT_Dodawanie_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TXB_1.Text);
            b = int.Parse(TXB_2.Text);

            c = a + b;
            MessageBox.Show(c.ToString());
        }

        private void BT_Odejmowanie_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TXB_1.Text);
            b = int.Parse(TXB_2.Text);

            c = a - b;
            MessageBox.Show(c.ToString());
        }

        private void BT_Mnozenie_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TXB_1.Text);
            b = int.Parse(TXB_2.Text);

            c = a * b;
            MessageBox.Show(c.ToString());
        }

        private void BT_Dzielenie_Click(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TXB_1.Text);
            b = int.Parse(TXB_2.Text);

            c = a / b;
            MessageBox.Show(c.ToString());
        }
    }
}

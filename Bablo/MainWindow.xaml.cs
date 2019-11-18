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


namespace Bablo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(in1.Text);
            double b = double.Parse(mn1.Text);
            double c = double.Parse(in2.Text);
            double d = double.Parse(mn2.Text);
            double i = double.Parse(in3.Text);
            double f = double.Parse(mn3.Text);
            double g = double.Parse(in4.Text);
            double h = double.Parse(mn4.Text);

           
            ou1.Text = (a * b).ToString();
            ou2.Text = (c * d).ToString();
            ou3.Text = (i * f).ToString();
            ou4.Text = (g * h).ToString();





        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double sum;
            sum = Convert.ToDouble(ou1.Text) + Convert.ToDouble(ou2.Text) + Convert.ToDouble(ou3.Text) + Convert.ToDouble(ou4.Text);
            summ.Text = "Ваш бюджет складає "+Convert.ToString(sum);
        }

        private void in1_MouseEnter(object sender, MouseEventArgs e)
        {
            in1.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Bablo.Close();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            this.Close();

        }
    }
}

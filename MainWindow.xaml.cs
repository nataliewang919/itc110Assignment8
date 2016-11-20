

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


namespace Assignment8
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


        private void buttonSumbit_Click(object sender, RoutedEventArgs e)
        {
            Bill b = new Assignment8.Bill();          
            b.Amount = double.Parse(textBoxMeal.Text);
            
            double tip;
            if (radioButtonTen.IsChecked == true)
            {
                tip = 10;
            }
            else if (radioButtonFifteen.IsChecked == true)
            {
                tip = 15;
            }
            else if (radioButtonTwenty.IsChecked == true)
            {
                tip = 20;
            }
            else
            {
                tip = double.Parse(textBoxOther.Text);
            }

            labelResult.Content = "The total tax is " + b.GetTax().ToString() + " Your tip is " + b.GetTips(tip).ToString() + " Your total amount is " + b.GetTotalAmount(tip);
        }
    }
}
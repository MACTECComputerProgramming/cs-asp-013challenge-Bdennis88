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

namespace CS_ASP_013
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
               
        private void labelButton_Click(object sender, RoutedEventArgs e)
        {
            double orderTotal = 0;
            if (radioButtonSixInch.IsChecked == true)
            {
                orderTotal += 3.50;
                txtBlockSubs.Text = " Six Inch, ";
            }
            else
            {
                orderTotal += 5.00;
                txtBlockSubs.Text = " Foot Long, ";
            }

            if (radioButtonWheat.IsChecked == true)
            {
                orderTotal += 0;
                txtBlockSubs.Text += " Wheat Bread, ";
            }
             if(radioButtonItalian.IsChecked == true)

                txtBlockSubs.Text += " Italian Bread,";

            else if (radioButtonFlatBread.IsChecked == true)
            {
                orderTotal += 0.50;
                txtBlockSubs.Text += " Flat bread,";
            }
            else if (radioButtonRoastedChicken.IsChecked == true)

                txtBlockSubs.Text += "Roasted Chicken,";

            else if (radioButtonHam.IsChecked == true)

                txtBlockSubs.Text += " Ham, ";

            else if (radioButtonMeatBall.IsChecked == true)
            {
                orderTotal += 1.00;
                txtBlockSubs.Text += " " + "Meatball,";
            }
            else if (radioButtonSteak.IsChecked == true)
            {
                orderTotal += 1.50;
                txtBlockSubs.Text += " " + "Steak,";
            }
            if (checkBoxAmerican.IsChecked == true)
            {
                orderTotal += 0.25;
                txtBlockSubs.Text += " " + "American Cheese,";
            }
            if (checkBoxSwiss.IsChecked == true)
            {
                orderTotal += 0.30;
                txtBlockSubs.Text += " " + "Swiss Cheese,";
            }
             if (checkBoxPepperJack.IsChecked == true)
            {
                orderTotal += 0.75;
                txtBlockSubs.Text += " " + " PeperJack Cheese,";
            }
            if (checkBoxCucumber.IsChecked == true)

                txtBlockSubs.Text += " " + " Cucumber,";

             if (checkBoxGreenPepper.IsChecked == true)
            {
                orderTotal += 0.25;
                txtBlockSubs.Text += " " + " Green Pepper,";
            }
             if (checkBoxLettuce.IsChecked == true)
            {
                orderTotal += 0.15;
                txtBlockSubs.Text += " " + " Lettuce,";
            }
             if (checkBoxRedOnion.IsChecked == true)
            {
                orderTotal += 0.10;
                txtBlockSubs.Text += " " + "Red Onion";
            }
             if (checkBoxAllVeggies.IsChecked == true)
            {
                orderTotal += 0.25;
                txtBlockSubs.Text += " " + "Cucumber, Green Peper, Lettuce, Red Onion";
            }
            if (radioButtonFootLong.IsChecked == true &&
                radioButtonWheat.IsChecked == true &&
                radioButtonMeatBall.IsChecked == true &&
                checkBoxAmerican.IsChecked == true)
            {
                
                orderTotal -= 2.00;
                txtBlockSubs.Text += " Special *** $2.00 Off " + orderTotal.ToString("C");
            }

            else
                    txtBlockSubs.Text += " " + orderTotal.ToString("C");

            




        }

        
    }
}

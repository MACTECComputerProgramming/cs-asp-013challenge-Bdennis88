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
                labelSubs.Content = " Six Inch, ";
            }
            else
            {
                orderTotal += 5.00;
                labelSubs.Content = " Foot Long, ";
            }

            if (radioButtonWheat.IsChecked == true)
            {
                orderTotal += 0;
                labelSubs.Content += " Wheat Bread, ";
            }
             if(radioButtonItalian.IsChecked == true)

                labelSubs.Content += " Italian Bread,";

            else if (radioButtonFlatBread.IsChecked == true)
            {
                orderTotal += 0.50;
                labelSubs.Content += " Flat bread,";
            }
            else if (radioButtonRoastedChicken.IsChecked == true)

                labelSubs.Content += "Roasted Chicken,";

            else if (radioButtonHam.IsChecked == true)

                labelSubs.Content += " Ham, ";

            else if (radioButtonMeatBall.IsChecked == true)
            {
                orderTotal += 1.00;
                labelSubs.Content += " " + "Meatball,";
            }
            else if (radioButtonSteak.IsChecked == true)
            {
                orderTotal += 1.50;
                labelSubs.Content += " " + "Steak,";
            }
            if (checkBoxAmerican.IsChecked == true)
            {
                orderTotal += 0.25;
                labelSubs.Content += " " + "American Cheese,";
            }
            if (checkBoxSwiss.IsChecked == true)
            {
                orderTotal += 0.30;
                labelSubs.Content += " " + "Swiss Cheese,";
            }
             if (checkBoxPepperJack.IsChecked == true)
            {
                orderTotal += 0.75;
                labelSubs.Content += " " + " PeperJack Cheese,";
            }
            if (checkBoxCucumber.IsChecked == true)

                labelSubs.Content += " " + " Cucumber,";

             if (checkBoxGreenPepper.IsChecked == true)
            {
                orderTotal += 0.25;
                labelSubs.Content += " " + " Green Pepper,";
            }
             if (checkBoxLettuce.IsChecked == true)
            {
                orderTotal += 0.15;
                labelSubs.Content += " " + " Lettuce,";
            }
             if (checkBoxRedOnion.IsChecked == true)
            {
                orderTotal += 0.10;
                labelSubs.Content += " " + "Red Onion";
            }
             if (checkBoxAllVeggies.IsChecked == true)
            {
                orderTotal += 0.25;
                labelSubs.Content += " " + "Cucumber, Green Peper, Lettuce, Red Onion";
            }
            if (radioButtonFootLong.IsChecked == true &&
                radioButtonWheat.IsChecked == true &&
                radioButtonMeatBall.IsChecked == true &&
                checkBoxAmerican.IsChecked == true)
            {
                
                orderTotal -= 2.00;
                labelSubs.Content += " Special *** $2.00 Off " + orderTotal.ToString("C");
            }

            else
                    labelSubs.Content += " " + orderTotal.ToString("C");

            




        }

        
    }
}

/* Main form for Piecework Pay Calculator
 * Author: Yu Ting Lin
 * Created: 2022-10-03
 * Updated: 2022-10-07
 * Description: A form to calculate the wages of employee and create a summary for the overall employee information.
 */




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

namespace PieceworkPayCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor for the form
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clear all fields
        /// </summary>
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtWorkersName.Clear();
            txtMessagesSent.Clear();
            txtWorkersPay.Clear();
            txtWorkersName.Focus();
        }
        /// <summary>
        /// Attempt to calculate the employee's wage, and then add the data to the overall summary
        /// </summary>
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //double payRate = 0;
            double workersPayCheck = 0;

            IDictionary<string, double> messageRate = new Dictionary<string, double>();
            messageRate.Add("level1", 0.02);
            messageRate.Add("level2", 0.024);
            messageRate.Add("level3", 0.028);
            messageRate.Add("level4", 0.034);
            messageRate.Add("level5", 0.04);


            if (txtWorkersName.Text != String.Empty)
            {
                int enteredMessagesSent;

                if (int.TryParse(txtMessagesSent.Text, out enteredMessagesSent) && enteredMessagesSent > 0)
                {
                    switch (messageRate)
                    {
                        case messageRate["level1"]:
                            if (enteredMessagesSent > 0 && enteredMessagesSent <= 1249)
                            {
                                workersPayCheck = enteredMessagesSent * messageRate["level1"];
                                txtWorkersPay.Text = workersPayCheck.ToString();
                            }
                            break; 
                        case 1:
                            if (enteredMessagesSent > 1249 && enteredMessagesSent <= 2499)
                            {
                                workersPayCheck = enteredMessagesSent * messageRate["level2"];
                                txtWorkersPay.Text = workersPayCheck.ToString();
                            }
                            break;
                        case 2:
                            if (enteredMessagesSent >= 2500 && enteredMessagesSent <= 3749)
                            {
                                workersPayCheck = enteredMessagesSent * messageRate["level3"];
                                txtWorkersPay.Text = workersPayCheck.ToString();
                            }
                            break;
                        case 3:
                            if (enteredMessagesSent >= 3750 && enteredMessagesSent <= 4999)
                            {
                                workersPayCheck = enteredMessagesSent * messageRate["level4"];
                                txtWorkersPay.Text = workersPayCheck.ToString();
                            }
                            break;
                        case 4:
                            if (enteredMessagesSent >= 5000)
                            {
                                workersPayCheck = enteredMessagesSent * messageRate["level5"];
                                txtWorkersPay.Text = workersPayCheck.ToString();
                            }
                            break;
                    }
                }              
            }

        }
    }
}

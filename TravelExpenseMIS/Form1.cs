using System;
using System.Windows.Forms;

/*****************************************/
/*  Project 5:   Travel Expense MIS      */
/*  Author:      Lynn Eades              */
/*  Date:        11/12/2018              */
/*****************************************/

namespace TravelExpenseMIS
{
    public partial class travelExpenseForm : Form
    {
        // This is the object that will be set to the current auto chosen
        AutoMilageCalculator selectedAutoMileageCalculator;

        // The distance for the city and freeway routes
        const int FREEWAY_DISTANCE_IN_MILES = 33;
        const int CITY_DISTANCE_IN_MILES = 21;
        
        // Keeps track of auto and route selected
        string currentAutoSelected;
        string currentRouteSelected;
        int    currentRouteDistance;

        public travelExpenseForm()
        {
            InitializeComponent();

            // Set starting auto and route to Buick and freeway
            currentAutoSelected = buickRadioButton.Text;
            currentRouteSelected = freewayRadioButton.Text;
            currentRouteDistance = FREEWAY_DISTANCE_IN_MILES;

            // Set the current auto mileage calculator for the Buick Electra
            selectedAutoMileageCalculator = new AutoMilageCalculator("Buick Electra");

            // Update display values for the default Buick and city route
            UpdateMileageAndTotalMilesLabels();

            gasPriceTextBox.Text = "0.00";
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Get price from user input
            decimal gasPrice = Convert.ToDecimal(gasPriceTextBox.Text);
            decimal cost = 0.0M;

            // Calculate using current route, distance for route, and price of gas entered
            cost = selectedAutoMileageCalculator.CalculateCost(currentRouteSelected, currentRouteDistance, gasPrice);
            totalCostValueLabel.Text = String.Format(cost.ToString("C2"));
        }

        private void buickRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (buickRadioButton.Checked)
            {
                currentAutoSelected = "Buick Electra";
                selectedAutoMileageCalculator = new AutoMilageCalculator(currentAutoSelected);

                UpdateMileageAndTotalMilesLabels();
            }
        }

        private void chevyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (chevyRadioButton.Checked)
            {
                currentAutoSelected = "Chevy Lumina";
                selectedAutoMileageCalculator = new AutoMilageCalculator(currentAutoSelected);

                UpdateMileageAndTotalMilesLabels();
            }
        }

        private void freewayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (freewayRadioButton.Checked)
            {
                currentRouteSelected = "Freeway";
                currentRouteDistance = FREEWAY_DISTANCE_IN_MILES;

                UpdateMileageAndTotalMilesLabels();
            }
        }

        private void cityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cityRadioButton.Checked)
            {
                currentRouteSelected = "City";
                currentRouteDistance = CITY_DISTANCE_IN_MILES;

                UpdateMileageAndTotalMilesLabels();
            }
        }
        
        private void gasPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            totalCostValueLabel.ResetText();
        }

        // Update values displayed when user changes auto or route; clear total price
        private void UpdateMileageAndTotalMilesLabels()
        {
            totalMilesValueLabel.Text = currentRouteDistance.ToString();
            mileageValueLabel.Text = selectedAutoMileageCalculator.GetMileageForRoute(currentRouteSelected).ToString();
            totalCostValueLabel.ResetText();
        }

        private void gasPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get the ascii value of the key pressed
            int pressedKey = (int)e.KeyChar;

            // Allow only numbers, decimal point and backspace
            if ((pressedKey < 48 || pressedKey > 57) && pressedKey != 46 && pressedKey != 8)
            {
                e.Handled = true;
                return;
            }
            
            // Allow only one decimal point to be entered
            if (pressedKey == 46)
            {
                // Check for decimal point in the textbox contents
                if (gasPriceTextBox.Text.Contains(e.KeyChar.ToString()))
                {
                    e.Handled = true;
                    return;
                }
            }
        }
    }
}

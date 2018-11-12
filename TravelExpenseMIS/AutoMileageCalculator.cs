using System;

/*****************************************/
/*  Project 5:   Travel Expense MIS      */
/*  Author:      Lynn Eades              */
/*  Date:        11/12/2018              */
/*****************************************/

namespace TravelExpenseMIS
{
    // A calculator object defined by the 'make and model' string passed when instantiated
    public class AutoMilageCalculator : object
    {
        // Current MPG ratings for the Buick Electra and Chevy Lumina
        const decimal BUICK_ELECTRA_CITY_MPG = 15.5M;
        const decimal BUICK_ELECTRA_FREEWAY_MPG = 23.7M;
        const decimal CHEVY_LUMINA_CITY_MPG = 19.8M;
        const decimal CHEVY_LUMINA_FREEWAY_MPG = 29.3M;

        private decimal _cityMilesPerGallon;
        private decimal _freewayMilesPerGallon;
        
        // Constructor takes a make and model string. Will throw if string does not match the expected choices
        public AutoMilageCalculator(string makeAndModel)
        {
            switch (makeAndModel)
            {
                case "Buick Electra":
                    _cityMilesPerGallon = BUICK_ELECTRA_CITY_MPG;
                    _freewayMilesPerGallon = BUICK_ELECTRA_FREEWAY_MPG;
                    break;
                case "Chevy Lumina":
                    _cityMilesPerGallon = CHEVY_LUMINA_CITY_MPG;
                    _freewayMilesPerGallon = CHEVY_LUMINA_FREEWAY_MPG;
                    break;
                default:
                    throw new ArgumentException("No data available for make-and-model = {0}", makeAndModel);
            }
        }

        // Given a route string, returns the MPG for the make and model; returns 0 if route not matched
        public decimal GetMileageForRoute(string route)
        {
            decimal milesPerGallon = 0.0M;

            if (route == "City")
            {
                milesPerGallon = _cityMilesPerGallon;
            }
            else if (route == "Freeway")
            {
                milesPerGallon = _freewayMilesPerGallon;
            }
            return milesPerGallon;
        }

        // Given a route, total miles travelled, and price of gas, returns total cost of trip
        // Returns 0 if route not matched
        public decimal CalculateCost(string route, decimal totalMiles, decimal gasPrice)
        {
            decimal cost = 0.0M;

            if (route == "Freeway")
                cost = (totalMiles / _freewayMilesPerGallon) * gasPrice;
            else if (route == "City")
            {
                cost = (totalMiles / _cityMilesPerGallon) * gasPrice;
            }
            return cost;
        }
    }
}

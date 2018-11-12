using System;

namespace TravelExpenseMIS
{
    public class AutoMilageCalculator : object
    {
        const decimal BUICK_CITY_MPG = 15.5M;
        const decimal BUICK_FREEWAY_MPG = 23.7M;
        const decimal CHEVY_CITY_MPG = 19.8M;
        const decimal CHEVY_FREEWAY_MPG = 29.3M;

        private decimal _cityMilesPerGallon;
        private decimal _freewayMilesPerGallon;

        public AutoMilageCalculator(string makeAndModel)
        {
            switch (makeAndModel)
            {
                case "Buick Electra":
                    _cityMilesPerGallon = BUICK_CITY_MPG;
                    _freewayMilesPerGallon = BUICK_FREEWAY_MPG;
                    break;
                case "Chevy Lumina":
                    _cityMilesPerGallon = CHEVY_CITY_MPG;
                    _freewayMilesPerGallon = CHEVY_FREEWAY_MPG;
                    break;
                default:
                    throw new ArgumentException("No data available for make-and-model = {0}", makeAndModel);
            }
        }

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

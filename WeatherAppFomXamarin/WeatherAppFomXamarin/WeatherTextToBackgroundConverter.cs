﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace WeatherAppFomXamarin
{
    class WeatherTextToBackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string result = "sunny.jpg";

            if (value != null)
            {
                string weatherText = value.ToString();
               


                if (weatherText.Contains("rainy"))
                    result = "rainy.jpg";
                else if (weatherText.Contains("sunny"))
                    result = "sunny.jpg";

            }





            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace HMI_DIGITAL_SAMPLE
{
    public class StringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string result = string.Format("{0}", value);
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
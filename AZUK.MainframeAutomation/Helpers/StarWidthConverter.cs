﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Controls;

namespace AZUK.MainframeAutomationRobot.Helpers
{
    public class StarWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            ListView listview = value as ListView;
            double width = listview.Width;
            GridView gv = listview.View as GridView;
            for (int i = 0; i < gv.Columns.Count; i++)
            {
                if (!Double.IsNaN(gv.Columns[i].Width))
                    width -= gv.Columns[i].Width;
            }
            return width - 5;// this is to take care of margin/padding
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }

}

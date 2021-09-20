using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace supX.Converters
{
    public class IntegerToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int result = (int)value;
            switch (result)
            {
                case 0:
                    return new Uri(@"\Assets\Images\Fighters\FighterLobster.png", UriKind.Relative);
                case 1:
                    return new Uri(@"\Assets\Images\Fighters\FighterKangaroo.png", UriKind.Relative);
                case 2:
                    return new Uri(@"\Assets\Images\Fighters\FighterTheHulk.png", UriKind.Relative);
                case 3:
                    return new Uri(@"\Assets\Images\Fighters\FighterHuman.png", UriKind.Relative);
                case 4:
                    return new Uri(@"\Assets\Images\Fighters\FighterFrog.png", UriKind.Relative);
                case 5:
                    return new Uri(@"\Assets\Images\Fighters\FighterSloth.png", UriKind.Relative);

                default:
                    break;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

using Sportclub.Model;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Sportclub.UI.Converters
{
    public class SessionStatusToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is SessionStatus status)
            {
                string iconPath = string.Empty;

                switch (status)
                {
                    case SessionStatus.Scheduled:
                        iconPath = @"\Images\SessionStatus\Status_Scheduled.png"; 
                        break;
                    case SessionStatus.Running:
                        iconPath = @"\Images\SessionStatus\Status_Running.png"; 
                        break;
                    case SessionStatus.Completed:
                        iconPath = @"\Images\SessionStatus\Status_Completed.png"; 
                        break;
                    case SessionStatus.Canceled:
                        iconPath = @"\Images\SessionStatus\Status_Canceled.png";
                        break;
                }

                if (!string.IsNullOrEmpty(iconPath))
                {
                    return new BitmapImage(new Uri(iconPath, UriKind.Relative));
                }
            }
            return null; 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

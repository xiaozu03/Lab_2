using System.Globalization;

namespace Lab_2_layout.Converters
{
    public class GenderToImageConverter : IValueConverter
    {
        // Add '?' to object? value and object? parameter
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is string gender)
            {
                return gender.ToLower() == "male" ? "male_icon.png" : "female_icon.png";
            }
            return null;
        }

        // Add '?' to object? value and object? parameter
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
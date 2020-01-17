using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace Cities
{
    public class DoubleConversion : DoubleConverter
    {
        public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            if (text == "")
            {
                double value = 0;
                return value;
            }
            else
            {
                System.Console.WriteLine("====>"+text);
                double value = System.Convert.ToDouble(text);
                return value;
            }
        }
    }
}
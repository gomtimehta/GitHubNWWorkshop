using System.Xml.Linq;

namespace WebApp.Utilities
{
    public class MyUtilities
    {

        public static int CalculateDaysBetweenDates(DateTime startDate, DateTime endDate)
        {
            return (endDate - startDate).Days;
        }

        public static void FindAllImages()
        {

            var doc = XDocument.Load("index.xhml");

            // find all images
            var images = doc.Descendants("img");
        }

    }
}

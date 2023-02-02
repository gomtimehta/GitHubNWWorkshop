using System.Xml.Linq;

namespace WebApp.Utilities
{
    public class MyUtilities
    {
        //FindAllImagesInGivenDirectory
        public static void FindAllImagesInGivenDirectory(string directory)
        {
            var files = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".jpg") || s.EndsWith(".png"));
        }

        //CalculateAverageOfNumbers
        public static double CalculateAverageOfNumbers(List<int> numbers)
        {
            double average = numbers.Average();
            return average;
        }
        



    }
}

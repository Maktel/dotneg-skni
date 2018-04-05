using System;

namespace NumberBaseConverter
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //            converter.TestCorrectRepresentationInBase11();
            //            converter.TestCorrectRepresentationInBase16();
            //            converter.TestCorrectRepresentationInBase2();
            //            converter.TestTooLargeBase();

            ConvertFromUserInput();
        }

        private static void ConvertFromUserInput()
        {
            Converter converter = new Converter();

            int linesCount = Convert.ToInt32(Console.ReadLine());
            while (linesCount-- > 0)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("base 10: {0}", number);
                Console.WriteLine("base  2: {0}", converter.ConvertToTextRepresentationInAnyBase(number, 2));
                Console.WriteLine("base 11: {0}", converter.ConvertToTextRepresentationInBase11(number));
                Console.WriteLine("base 16: {0}", converter.ConvertToTextRepresentationInBase16(number));
            }
        }
    }
}
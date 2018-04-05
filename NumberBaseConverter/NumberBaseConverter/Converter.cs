using System;
using System.Diagnostics;
using System.Linq;

namespace NumberBaseConverter
{
    internal class Converter
    {
        private string Digits { get; set; }

        public Converter(string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ")
        {
            Digits = digits;
        }

        public string ConvertToTextRepresentationInAnyBase(int number, int @base)
        {
            if (@base > Digits.Length)
            {
                throw new Exception(
                    $"The given base: {@base} is too large to be represented with digits + letters of the English alphabet.");
            }

            if (@base < 2)
            {
                throw new Exception($"The given base: {@base} must be equal or greater than 2.");
            }

            if (number < 0)
            {
                throw new Exception("Converting negative numbers is not supported for the time being.");
            }

            if (number == 0)
            {
                return "0";
            }

            string representation = "";


            while (number > 0)
            {
                representation += Digits[number % @base];
                number /= @base;
            }

            // the most upvoted answer from SO
            //            char[] reverse = representation.ToCharArray();
            //            Array.Reverse(reverse);
            //            return new String(reverse);

            // one-liner
            return new string(representation.Reverse().ToArray());
        }

        public string ConvertToTextRepresentationInBase16(int number)
        {
            return ConvertToTextRepresentationInAnyBase(number, 16);
        }

        public string ConvertToTextRepresentationInBase11(int number)
        {
            return ConvertToTextRepresentationInAnyBase(number, 11);
        }


        /* Unit tests */
        public void TestCorrectRepresentationInBase11()
        {
            const int number = 1263;

            string representation = ConvertToTextRepresentationInBase11(number);

            Debug.Assert(representation.Equals("A49"));
        }

        public void TestCorrectRepresentationInBase16()
        {
            const int number = 1263;

            string representation = ConvertToTextRepresentationInBase16(number);

            Debug.Assert(representation.Equals("4EF"));
        }

        public void TestCorrectRepresentationInBase2()
        {
            const int number = 1263;

            string representation = ConvertToTextRepresentationInAnyBase(number, 2);

            Debug.Assert(representation.Equals("10011101111"));
        }

        public void TestTooLargeBase()
        {
            const int number = 0;
            const int @base = 56;

            try
            {
                string representation = ConvertToTextRepresentationInAnyBase(number, @base);
                Debug.Assert(false);
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}

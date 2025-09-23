/*
 * Aaron Belschner
 * CST-150
 * Activity 5 Part 1
 * 9/18/25
 * This is my own work
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_DogClass.BusinessLayer
{
    internal class Utility
    {
        /// <summary>
        /// Utility that returns false if the parameter string is null, empty,
        /// or just contains white spaces.
        /// </summary>
        /// <param name="textToTest"></param>
        /// <returns></returns>
        public bool NotNull(string textToTest)
        {
            // Check if the string is empty, null, or contains
            // only whitespaces
            if (String.IsNullOrWhiteSpace(textToTest))
            {
                return false;
            }
            return true;

        }

        /// <summary>
        /// Tests to determine if a valid double was entered.
        /// If true the string is parsed to double and true is returned.
        /// If false -1 is returned and false for bool
        /// This return type is called a Tuple.
        /// </summary>
        /// <param name="valueToTest"></param>
        /// <returns></returns>
        public (double doublValue, bool isConverted) ValidDouble(string valueToTest)
        {
            // Declare and Initialize
            double convertValue = 0.00D;
            // Test to see if the string can be parsed to a double
            if (Double.TryParse(valueToTest, out convertValue))
            {
                return (convertValue, true);
            }
            // If parse fails return false and -1
            return (-1D, false);
        }

        /// <summary>
        /// Convert Yes to bool true and No to bool false
        /// </summary>
        /// <param name="YesOrNo"></param>
        /// <returns></returns>
        public bool ConvertToBool(string YesOrNo)
        {
            if(YesOrNo == "Yes")
            {
                return true;
            }
            return false;
        }
    }
}

using System;

namespace DataValidation {
    internal class InputValidator {
        public static int Validate(string input) {
            return int.Parse(input);
        }
        public static int Validate(string input, bool isPositive) {
            int result = int.Parse(input);
            if (result == 0) {
                throw new ArgumentException("Input string is zero.");
            } else if (isPositive && result < 0) {
                throw new ArgumentException("Input string is negative integer.");
            } else if (!isPositive && result > 0) {
                throw new ArgumentException("Input string is positive integer.");
            }

            return result;
        }
        public static int Validate(string input, int rangeBegin, int rangeEnd) {
            if (rangeBegin > rangeEnd) {
                throw new ArgumentException("Range begin greater than range end.");
            }

            int result = int.Parse(input);
            if (result < rangeBegin) {
                throw new ArgumentException("Input string is below the range.");
            }
            if (result > rangeEnd) {
                throw new ArgumentException("Input string is above the range.");
            }

            return result;
        }
    }
}

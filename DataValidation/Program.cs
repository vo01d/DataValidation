using System;
using DataValidation;

namespace Application {
    internal class Program {
        static void Main(string[] args) {
            do {
                Console.Clear();

                Console.Write("Enter string to validate: ");
                string input = Console.ReadLine();

                Console.WriteLine("Types of validation:");
                Console.WriteLine("1. Is input Int32 value?");
                Console.WriteLine("2. Is input positive Int32 value?");
                Console.WriteLine("3. Is input negative Int32 value?");
                Console.WriteLine("4. Is input Int32 value and within the range?");

                Console.Write("Enter type of validation: ");
                string typeOfValidation = Console.ReadLine();
                try {
                    int validationResult;
                    switch (typeOfValidation) {
                        case "1": {
                            validationResult = InputValidator.Validate(input);
                            Console.WriteLine("Validation result: Pass");
                            Console.WriteLine($"Parsed value: {validationResult}");
                            break;
                        }
                        case "2": {
                            validationResult = InputValidator.Validate(input, isPositive: true);
                            Console.WriteLine("Validation result: Pass");
                            Console.WriteLine($"Parsed value: {validationResult}");
                            break;
                        }
                        case "3": {
                            validationResult = InputValidator.Validate(input, isPositive: false);
                            Console.WriteLine("Validation result: Pass");
                            Console.WriteLine($"Parsed value: {validationResult}");
                            break;
                        }
                        case "4": {
                            int rangeBegin, rangeEnd;
                            try {
                                Console.Write("Enter range begin: ");
                                rangeBegin = InputValidator.Validate(Console.ReadLine());
                                Console.Write("Enter range end: ");
                                rangeEnd = InputValidator.Validate(Console.ReadLine());
                            }
                            catch (Exception ex) {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Press <ESC> to exit or any other key to continue...");
                                continue;
                            }

                            validationResult = InputValidator.Validate(input, rangeBegin, rangeEnd);
                            Console.WriteLine("Validation result: Pass");
                            Console.WriteLine($"Parsed value: {validationResult}");
                            break;
                        }
                        default: {
                            Console.WriteLine("Unknown type of validation!");
                            break;
                        }
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine($"Validation result: Fail");
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine("Press <ESC> to exit or any other key to continue...");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}

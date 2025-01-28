using System;

namespace tempConverter
{
    class temps
    {
        public static void Main(string[] args)
        {
            int intNumToConvert, intCelsius = 0, intFahrenheit = 0;
            double dblNumToConvert, dblCelsius = 0, dblFahrenheit = 0;
            bool stop = false;
            do
            {
                try
                {
                    intNumToConvert = 0;
                    dblNumToConvert = 0;

                    Console.WriteLine("Enter the temp you want converted");
                    var numberToConvert = Console.ReadLine();
                    while (!double.TryParse(numberToConvert, out dblNumToConvert) & !int.TryParse(numberToConvert, out intNumToConvert))
                    {
                        Console.WriteLine("You must enter a valid number, please try again");
                        numberToConvert = Console.ReadLine();
                    }
                    if (intNumToConvert > 0)
                    {
                        convertTemp(intNumToConvert, ref intCelsius, ref intFahrenheit);
                        Console.WriteLine($"{intNumToConvert} degrees Fahrenheit would be {intCelsius} degrees Celsius");
                        Console.WriteLine($"{intNumToConvert} degrees Celsius would be {intFahrenheit} degrees Fahrenheit");
                        intCelsius = 0;
                        intFahrenheit = 0;
                    }
                    else
                    {
                        convertTemp(dblNumToConvert, ref dblCelsius, ref dblFahrenheit);
                        Console.WriteLine($"{dblNumToConvert} degrees Fahrenheit would be {dblCelsius} degrees Celsius");
                        Console.WriteLine($"{dblNumToConvert} degrees Celsius would be {dblFahrenheit} degrees Fahrenheit");
                        dblCelsius = 0;
                        dblFahrenheit = 0;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You need to enter a number");
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("The number you entered is too big");
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred, please try again.");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Do you want to convert another temp? (Y for yes, any key for no)");
                    char more;
                    while (!char.TryParse(Console.ReadLine(), out more))
                    {
                        Console.WriteLine("Pleaase enter a valid character, try again...");
                    }
                    if (Char.ToLower(more) == 'n')
                        stop = true;
                }
            } while (!stop);

        }
        private static void convertTemp(int intNumToConvert, ref int celsius, ref int fahrenheit)
        {
            try
            {
                celsius = (intNumToConvert - 32) * 5 / 9;
                fahrenheit = (intNumToConvert * 9 / 5) + 32;
            }
            catch (ArithmeticException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Could not convert temperature!");
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An error has occured!");
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally
            {
                if (celsius == 0 && fahrenheit == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Temperature could not be converted!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        private static void convertTemp(double intNumToConvert, ref double celsius, ref double fahrenheit)
        {
            try
            {
                celsius = (intNumToConvert - 32) * 5 / 9;
                fahrenheit = (intNumToConvert * 9 / 5) + 32;
            }
            catch (ArithmeticException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Could not convert temperature!");
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An error has occured!");
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally
            {
                if (celsius == 0 && fahrenheit == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Temperature could not be converted!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}

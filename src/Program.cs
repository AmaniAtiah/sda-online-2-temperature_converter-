class Program
{
    public static string TempConvert(double tempValue, string unit)
    {
        switch (unit)
        {
            case "C":
                double fahrenheit = (tempValue * 9 / 5) + 32;
                return $"{fahrenheit} F";

            case "F":
                double celsius = (tempValue - 32) * 5 / 9;
                return $"{celsius} C";

            default:
                return "Invalid unit. Please Enter'C' for Celsius or 'F' for Fahrenheit.";
        }
    }
    public static void Main(string[] args)
    {
        try
        {
            while (true)
            {
                Console.WriteLine("Enter a temprature Value and its unit (C or F) or type Quit to exit the app");
                string input = Console.ReadLine() ?? "";

                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Program is terminated");
                    break;
                }


                string[] parts = input.Split(" ");
                if (parts.Length != 2)
                {
                    Console.WriteLine("Invalid input . please Enter a temperature Value and its unit (C or F)");
                    continue;
                }


                string tempUnit = parts[1].ToUpper();
                if (tempUnit != "C" && tempUnit != "F")
                {
                    Console.WriteLine("Invalid unit. please Enter C or F as temperature unit.");
                    continue;
                }
                if (!double.TryParse(parts[0], out double temperatureValue))
                {
                    Console.WriteLine("Invalid unit. please Enter C or F as temperature unit.");
                    continue;

                }


                Console.WriteLine($"Converted :  {TempConvert(temperatureValue, tempUnit)}");


            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadKey();


    }
}
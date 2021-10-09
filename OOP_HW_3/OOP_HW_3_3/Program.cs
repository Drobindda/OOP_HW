using System;

namespace OOP_HW_3_3
{
    class Program
    {   
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter currency rates: ");
            Console.WriteLine("USD: ");
            double USDtoUAH_Rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("EUR: ");
            double EURtoUAH_Rate = Convert.ToDouble(Console.ReadLine());
            Converter converter = new Converter(USDtoUAH_Rate, EURtoUAH_Rate);

            while (true)
            {
                int opt = Menu();
                switch (opt)
                {
                    case 1:
                        converter.ConverterOutput("USD", "UAH");
                        break;
                    case 2:
                        converter.ConverterOutput("EUR", "UAH");
                        break;
                    case 3:
                        converter.ConverterOutput("UAH", "USD");
                        break;
                    case 4:
                        converter.ConverterOutput("UAH", "EUR");
                        break;
                    default: return;
                }
            }
        }
        static int Menu()
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to convert?");
            Console.WriteLine("Enter an option: ");
            Console.WriteLine("1 -- USD to UAH");
            Console.WriteLine("2 -- EUR to UAH");
            Console.WriteLine("3 -- UAH to USD");
            Console.WriteLine("4 -- UAH to EUR");
            Console.WriteLine("other number -- Exit");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
    

    class Converter
    {
        public Converter(double usd, double eur)
        {
            ExchangeRateUSDtoUAH = usd;
            ExchangeRateEURtoUAH = eur;
        }
        public double ExchangeRateUSDtoUAH = 0;
        public double ExchangeRateEURtoUAH = 0;
        public double Convert(string CurrencyFromName, string CurrencyToName, double currencyFromAmount)
        {
            if (CurrencyFromName == "USD" && CurrencyToName == "UAH")
                return USDtoUAH(currencyFromAmount);
            else if (CurrencyFromName == "EUR" && CurrencyToName == "UAH")
                return EURtoUAH(currencyFromAmount);
            else if (CurrencyFromName == "UAH" && CurrencyToName == "USD")
                return UAHtoUSD(currencyFromAmount);
            else if (CurrencyFromName == "UAH" && CurrencyToName == "EUR")
                return UAHtoEUR(currencyFromAmount);
            else 
                return double.NaN;
        }
        public void ConverterOutput(string CurrencyFromName, string CurrencyToName)
        {
            Console.WriteLine("Enter {0} :", CurrencyFromName);
            double currencyFromAmount = System.Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} {1} will be {2} {3} ", currencyFromAmount, CurrencyFromName, Convert(CurrencyFromName, CurrencyToName, currencyFromAmount), CurrencyToName);
        }
        public double UAHtoUSD(double uah)
        {
            return uah / ExchangeRateUSDtoUAH;
        }
        public double UAHtoEUR(double uah)
        {
            return uah / ExchangeRateEURtoUAH;
        }
        public double USDtoUAH(double usd)
        {
            return usd * ExchangeRateEURtoUAH;
        }
        public double EURtoUAH(double eur)
        {
            return eur * ExchangeRateEURtoUAH;
        }
    }
}

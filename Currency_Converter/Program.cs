﻿using System;


namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculation part
            try
            {                
            decimal givenCurrency = 20, productPrice = 5.5m;
            decimal price = (givenCurrency - productPrice);
            CurChange change = new CurChange(price);
            Console.WriteLine("Given changes are given below:");
            Console.WriteLine($"Fifty Pound : {change.FiftyPound}");
            Console.WriteLine($"Twenty Dollar Bills: {change.TwentyPound}");
            Console.WriteLine($"Ten Pound : {change.TenPound}");
            Console.WriteLine($"Five Pound : {change.FivePound}");
           // Console.WriteLine($"Two Pound: {change.TwoPound}");
            Console.WriteLine($"One Pound: {change.OnePound}");
             Console.WriteLine($"One Pound: {change.OnePound}");
                Console.WriteLine($"Fify Pence: {change.FifyPence}");
            Console.Read();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
    }

}
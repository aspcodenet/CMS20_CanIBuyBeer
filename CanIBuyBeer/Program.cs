/*
 * om ålder > 17 OCH location == "krogen" OCH om leg == "J" OCH promille < 1.0 JA
 * om ålder > 19 och location == "systemet" OCH om leg == "J" OCH promille < 1.0 JA
 */

using System;

namespace CanIBuyBeer
{
    class Program
    {

        static bool CanIBuyBeer(int age, string location, decimal promille, string legg)
        {
            if (legg != "J")
                return false;
            if (promille > 1.0m)
                return false;
            if (age > 17 && location == "krogen")
                return true;
            if (age > 19 && location == "systemet")
                return true;
            return false;
        }



        //static bool CanIBuyBeer(int age, string location, decimal promille, string legg)
        //{
        //    bool canIBuyBeer = false;
        //    if (legg == "J" && promille < 1.0m)
        //    {
        //        if (location == "krogen" && age > 17)
        //        {
        //            canIBuyBeer = true;
        //        }
        //        else if (location == "systemet" && age > 19)
        //        {
        //            canIBuyBeer = true;
        //        }
        //    }

        //    return canIBuyBeer;

        //}

        static void Main(string[] args)
        {
            //bool 
            //string inmatning upper etc

            Console.Write("Hur gammal är du:");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Location (systemet eller krogen):");
            string location = Console.ReadLine();
            location = location.ToLower();

            Console.Write("Har du legg med dig (J/N):");
            string legg = Console.ReadLine();
            Console.Write("Vilken promillehalt:");
            decimal promille = Convert.ToDecimal(Console.ReadLine());

            bool canIBuyBeer = CanIBuyBeer(age,location,promille,legg);
            //if (legg == "J" && promille < 1.0m)
            //{
            //    if (location == "krogen" && age > 17)
            //    {
            //        canIBuyBeer = true;
            //    }
            //    else if (location == "systemet" && age > 19)
            //    {
            //        canIBuyBeer = true;
            //    }
            //}

            if (canIBuyBeer)
                Console.WriteLine("Du får köpa öl");
            else
                Console.WriteLine("Du får inte köpa öl");







            //if (legg == "J" && promille < 1.0m)
            //{
            //    if (location == "krogen" && age > 17)
            //    {
            //        Console.WriteLine("Japp du får köpa öl");
            //    }
            //    else if (location == "systemet" && age > 19)
            //    {
            //        Console.WriteLine("Japp du får köpa öl");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nejnej ingen öl för dig");
            //    }

            //}
            //else
            //    Console.WriteLine("Nejnej ingen öl för dig");


            //if( age > 17 && location == "krogen" && legg == "J" && promille < 1.0m)
            //    Console.WriteLine("Japp du får köpa öl");
            //else if (age > 19 && location == "systemet" && legg == "J" && promille < 1.0m)
            //    Console.WriteLine("Japp du får köpa öl");
            //else
            //    Console.WriteLine("Nejnej ingen öl för dig");
        }
    }
}

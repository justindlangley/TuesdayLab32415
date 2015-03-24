using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuesdaylab32415
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bank deposit example

            //var yearTotal = 35 * 365;
            //var beginningBalance = 0;
            //int[] year = new int[] { 1, 2, 5, 10 };

            //var totalDepositsperYear = beginningBalance + (yearTotal);



            //Console.WriteLine(string.Format("After 1 year of depositing $35.00 per day the total amount deposited is {0:C}", totalDepositsperYear));
            //Console.WriteLine(string.Format("After 2 years of depositing $35.00 per day the total amount deposited is {0:C}", totalDepositsperYear));
            //Console.ReadLine();



            //Land area problem


            //Console.WriteLine("Please enter the width of the relevant land parcel in yards: ");

            //    var userWidth = Console.ReadLine();
            //    var width = int.Parse(userWidth); 

            //Console.WriteLine("Please enter the length of the relevant land parcel in yards: ");         

            //    var userLength = Console.ReadLine();
            //    var length = int.Parse(userLength);
            //    var userArea = (width * length);                    

            //    var userPerimeter = (2 * width) + (2 * length);
            //    var totalCost = (userArea * 5) + (userPerimeter * 0.75);

            //Console.WriteLine(string.Format ("The area of the parcel you entered is {0} and the perimeter is {1}.", userArea, userPerimeter));
            //Console.WriteLine(string.Format("The total cost of the land parcel you wish to purchase is {0:C}", totalCost));
            //Console.ReadLine();


            //int userPerimeter = (2 * userWidth) + (2 * userLength);   
            //int totalCost = (userArea * 5) + (userPerimeter * 0.75);


            //Space problem

            //Console.WriteLine("How many minutes will the space ship booster fire for?");
            //var firstAnswer = Console.ReadLine();
            //var duration = int.Parse(firstAnswer);
            //var time = 2 * duration;
            //var initialVelocity = 10000;
            //var currentVelocity = initialVelocity * Math.Pow(1.05, duration);

            //Console.WriteLine(string.Format("After {0} minutes of flight, the final velocity of the ship is {1} miles per hour.", duration, currentVelocity));
            //Console.ReadLine();

            //var velaftertwoHours = 8 * currentVelocity;
            //Console.WriteLine(string.Format("After two hours of firing the boosters for 5 minutes, then coasting for ten, the final velocity would be {0}", velaftertwoHours));
            //Console.ReadLine();

            //return;

            //extra credit

            Console.WriteLine("Enter in a value for a in the quadratic equation");
            var a = Console.ReadLine(); 
            var A = int.Parse(a);
            Console.WriteLine("Enter in a value for b in the quadratic equation");
            var b = Console.ReadLine();
            var B = int.Parse(b);
            Console.WriteLine("Enter in a value for c in the quadratic equation");
            var c = Console.ReadLine();
            var C = int.Parse(c);

            var q = ((B * B) - (4 * A * C));
            var Q = Math.Pow(q, 0.5);
            
            var posroot = ((-(B) + Q) / (2 * A));
            var negroot = ((-(B) - Q) / (2 * A));
            Console.WriteLine(string.Format("The positive root of this quadratic equation is: {0}"), posroot);
            Console.WriteLine(string.Format("The negative root of this qquadraticc equation is: {0}"), negroot);
            Console.ReadLine();




            //String Lecture and afternoon lab

            //string hello = "This is some text";
            //Console.WriteLine(hello);
            //Console.WriteLine(upperHello);




            //if (string.IsNullOrWhiteSpace(hello));
            //Console.WriteLine("Nothing here.");


            //int wordCount = args.Count();
            //string output = null;
            //for (int i = wordCount - 1; i >= 0; i--)
            //{
                
            //    output = string.Concat(output, args[i], " ");
            //}

            
            //string output2 = null;
            //for (int i = 0; i < wordCount; i++)
            //{

            //    output2 = string.Concat(output2, args[i].ToUpper(), " ");
            //}
            //string output3 = null;
            //for (int i = 0; i < wordCount; i++)
            //{

            //    output3 = string.Concat(output3, args[i], " , ");
            //}
            //Console.WriteLine(output);
            //Console.WriteLine(output2);
            //Console.WriteLine(output3);
            //Console.ReadLine();


        }
    }
}

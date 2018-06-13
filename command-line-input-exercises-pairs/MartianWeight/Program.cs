using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartianWeight
{
	class Program
	{
		/*
        In case you've ever pondered how much you weight on Mars, here's the calculation:
 	    Wm = We* 0.378
 	    where 'Wm' is the weight on Mars, and 'We' is the weight on Earth

        Write a command line program which accepts a series of Earth weights from the user  
        and displays each Earth weight as itself, and its Martian equivalent.


        C:\Users> MartianWeight  
        Enter a series of Earth weights (space-separated): 98 235 185
            
        98 lbs.on Earth, is 37 lbs.on Mars.
        235 lbs.on Earth, is 88 lbs.on Mars.
        185 lbs.on Earth, is 69 lbs.on Mars. 
        */
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter your weight on Earth in pounds: ");
			string userWeight = Console.ReadLine();

			char[] splitWeight = { ' ' };
			string[] weight = userWeight.Split(splitWeight);
			double earthWeight = 0;
			int marsWeightWhole = 0;

			for (int i = 0; i < weight.Length; i++)
			{
				earthWeight = double.Parse(weight[i]);

				double marsWeight = 0;
				marsWeight = earthWeight * 0.378;
				marsWeightWhole = (int)marsWeight;

				Console.WriteLine(weight[i] + "lbs. on Earth, is " + marsWeightWhole + "lbs. on Mars.");
			}

			Console.ReadKey();

		}
	}
}
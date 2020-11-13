/*Program to calculate the average of the numbers entered by the
 *user until he types "end".
 *Corrected by Jesus Sanchez.
 */
using System;

public class Average
{
	public static void Main()
	{
		double userNumber, summedNumber = 0, counter = 0, average;
		string input;
		try
		{
			Console.Write("Insert a mark: ");
			input = Console.ReadLine();
			while((input != "end") && (input != "END") 
				&& (input != "End"))
			{  
				userNumber = Convert.ToDouble(input);
				counter ++;   
				summedNumber += userNumber;  
				
				Console.Write("Insert another mark or \"END\": ");
				input = Console.ReadLine();
			}
			average = summedNumber / counter;
			Console.WriteLine("The average is {0}",average);
		}
		catch(FormatException)
		{
			Console.Write("Type a valid number or END");
		}
	}	
}

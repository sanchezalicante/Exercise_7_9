/* Program to calculate the numbers of digits from a list of numbers
 * entered by the user until he types "end".
 * Corrected by Jesus Sanchez.
 */
using System;

class digits
{
	static void Main()
	{
		int oneDigitCount = 0, twoDigitCount = 0,
		  threeDigigCount = 0, upThreeCount = 0;
		string input;
		try
		{
			Console.WriteLine("Insert the numbers, when finish type \"end\": ");
			input = Console.ReadLine();
					
			while( input != "end")
			{
				int userNumber = Convert.ToInt32(input);
				
				if( userNumber != 0 )
				{
					if(userNumber / 10 == 0)
					{ 
						oneDigitCount ++;
					}
					else if(userNumber / 100 == 0)
					{ 
						twoDigitCount ++;
					} 
					else if(userNumber / 1000 == 0) 
					{
						threeDigigCount ++; 
					}
					else
						upThreeCount++;  
				}
				input = Console.ReadLine();
			}
		}
		catch(FormatException)
		{
			Console.WriteLine("Type a valid number or \"end\" in lower case");
		}
		Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", 
		oneDigitCount, twoDigitCount, threeDigigCount, upThreeCount);
	}
}

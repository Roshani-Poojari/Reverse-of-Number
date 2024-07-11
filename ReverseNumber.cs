using System;

class ReverseNumber{
	public static void Main(String [] args){
		int myNumber, reverseNumber=0, remainder;
		Console.WriteLine("Enter a number:");
		myNumber = Convert.ToInt32(Console.ReadLine());
		while(myNumber > 0){
			remainder = myNumber % 10;
			reverseNumber = reverseNumber * 10 + remainder;
			myNumber = myNumber/10;
		}
		Console.WriteLine("Reversed Number:"+reverseNumber);
	}
}
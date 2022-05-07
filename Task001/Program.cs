/*string[] arrString = { "hello", "2", "world", ":-)" };

for (int i = 0; i < arrString.Length; i++)
{
    string text = String.Empty;
    text = arrString[i];

    int length = text.Length;

    string result = String.Empty;
    for (int j = 0; j < length; j++)
    {
        if (length < 4)
        {
            result = result + $"{text[j]}";

        }
        else break;
    }
    System.Console.Write($"{result}" + " ");

}*/

/*string [][] myArr =
{
    new string [0]  {hello},
    new string [1]  {2},
    new string [2]  {world},
    new string [3]  {:-)},

};


string [][] Arr = new string [4][];
Arr[0] = new string [] {hello};
Arr[1] = new string []  {2};
    Arr[2] = new string []  {world};
   Arr[3] =  new string []  {:-)};
*/

// C# program to illustrate the declaration
// and Initialization of Jagged Arrays
using System;

class GFG {
	
	// Main Method
	public static void Main()
	{
		
		// Declare the Jagged Array of four elements:
		string [][] jagged_arr = new string [4][];

		// Initialize the elements
		jagged_arr[0] = new string[] {"hello"};
		jagged_arr[1] = new string[] {"2"};
		jagged_arr[2] = new string[] {"world"};
		jagged_arr[3] = new string[] {":-)"};

		// Display the array elements:
		for (int n = 0; n < jagged_arr.Length; n++) {

			// Print the row number
			System.Console.Write("Слово({0}): ", n);

			for (int k = 0; k < jagged_arr[n].Length; k++) {

				// Print the elements in the row
				System.Console.Write("{0} ", jagged_arr[n][k]);
			}
			System.Console.WriteLine();
		}
	}
}

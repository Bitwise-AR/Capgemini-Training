// A computer science instructor is designing a tool to help students understand ASCII values and string manipulation. The utility removes characters with even ASCII codes from a word and reverses the remaining ones, offering a hands-on way to explore how data can be transformed for security or encoding purposes.
// In the class Program, implement the below-given method.  
// Method	Description
// public string CleanseAndInvert(string input)	This method takes a word as input and performs a series of transformations and return a customized format of string. The transformation logic includes:
// 1) The input must not be null, and it must contain at least 6 characters long. If it is shorter or null, the function should return an empty string.
// 2)The input must not contain any space, digit or special characters. If not, the function should return an empty string.
// Password Generation Logic:
// •	Convert the input to lowercase.
// •	Remove all characters whose ASCII values are even numbers.
// •	Reverse the remaining characters.
// •	In the reversed string, convert characters that have even positioned character (0 based index) to uppercase. Refer to the sample input and output.
// Return the generated key. 

// In the Program class, the Main method,
// - Prompt the user to enter a string input.
// - Call the CleanseAndInvert method if the input is valid and print the output as "The generated key is - <generated key>".
// - If the method returns empty string, then display "Invalid Input".  Refer to the sample inputs/outputs.

// Note:
// •	Do not edit the existing code template.
// •	In the Sample Input / Output provided, the highlighted text in bold corresponds to the input given by the user, and the rest of the text represents the output.
// •	Implement the business requirements within the main method. Please do not change the class name.
// •	Do not use the Environment.Exit() to terminate the program.


// Sample Input 1:
// Enter the word
// Aeroplane


// Sample Output 1:
// The generated key is - EaOeA
// (Explanation: Input contains even ASCII characters.)


// Sample Input 2:
// Enter the word
// Cowages


// Sample Output 2:
// The generated key is - SeGaWoC
// (Explanation : Input doesn't contain even ASCII character. )



// Sample Input 3:
// Enter the word
// Magic


// Sample Output 3:
// Invalid Input
// (Explanation : Length of the input is less than 6.)



// Sample Input 4:
// Enter the word
// Kinder World

// Sample Output 4:
// Invalid Input
// (Explanation : Input contains space.)



// Sample Input 5:
// Enter the word
// B@rbie

// Sample Output 5:
// Invalid Input
// (Explanation : Input contains special character.)



public class FlipKey
{
    public string CleanseAndInvert(string input)
    {
        if (input == null || input.Length < 6 || input.Contains(" "))
        {
            return "";
        }

        foreach (char c in input)
        {
            if (!char.IsLetter(c))
            {
                return "";
            }
        }

        input = input.ToLower();

        for (char c = 'a'; c <= 'z'; c++)
        {
            if ((int)c % 2 == 0)
            {
                input = input.Replace(c.ToString(), "");
            }
        }

        char[] cInput = input.ToCharArray();
        Array.Reverse(cInput);
        string reversed = new string(cInput);
        
        for (int i = 0; i < cInput.Length; i++)
        {
            if (i % 2 == 0)
            {
                cInput[i] = char.ToUpper(cInput[i]);
            }
        }
        
        reversed = new string(cInput);

        return reversed;
    }
}
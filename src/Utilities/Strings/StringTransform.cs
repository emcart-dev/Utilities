//      TRANSFORMING STRINGS
//      This class consists of two methods; Reverse & ToTitleCase.
public class StringTransform {
    //  Reverses a given string //
    public static string Reverse(string input) {
        //  Create a char array for reversed characters to be added to
        char[] revStr = new char[input.Length];
        int range = input.Length - 1;
        //  Loop through the string to add each char to the new array in reverse order
        for (int i = 0; i < input.Length; i++) {
            revStr[i] = input[range];
            range--;
        }
        //  Convert the char array into a new string
        string reversedString = new string(revStr);
        return reversedString;
    }

    //  Converts a given string to Title Case //
    public static string ToTitleCase(string input) {
        //  Create an array and split the string into respective words
        string[] words = input.Split(" ");
        
        //  Loop through each word to convert the first character to uppercase
        for (int i = 0; i < words.Length; i++) {
            //  Convert whole word to lowercase
            words[i] = words[i].ToLower();
            //  Get the first character and convert to uppercase, then join to the rest of the lowercase word
            words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
        }
        //  Join the words to rejoin into one single string
        string toTitle = string.Join(" ", words);
        //  Output the converted string
        return toTitle;
    }
}   
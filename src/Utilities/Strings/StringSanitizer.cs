//  STRING SANITIZER
//    This class consists of one method; CollapseWhiteSpace.
using System.Text;

namespace Utilities.Strings;

public class StringSanitizer {
    //    Turns more than 1 spaces/tabs/newlines in a row within a string into single spaces. 
    public static string CollapseWhiteSpace(string str) {
        //    Create a string array for the new grammatically correct string
        var chs = new StringBuilder(str.Length);
        //    Create a boolean variable for deciphering same previous character
        bool prevCharSame = false;
        //    Iterate through the string to find where there is more than 1 consecutive space, tab or newline 
        //    character and append/skip accordingly 
        for (int i = 0; i < str.Length; i++) {
            if (char.IsWhiteSpace(str[i])) {
                //    If char is same as previous char, append to var chs                
                if (!prevCharSame) {
                    chs.Append(' ');
                    prevCharSame = true;
                }
            }
            else {
                //    Add the remaining chars in the string to var chs
                chs.Append(str[i]);
                prevCharSame = false;
            }
        }
        //    Trim and convert to string and return
        return chs.ToString().Trim();
    }
}

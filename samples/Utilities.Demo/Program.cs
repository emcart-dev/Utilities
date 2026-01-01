//  Demo console for testing classes and calling methods
using System;
using Utilities.Strings;

class Program {
    static void Main(string[] args) {
            /*  Transforming Strings  |  Reverse String
            StringTransform.Reverse("hello");
            //  Transforming Strings  |  Convert String to Title Case
            StringTransform.ToTitleCase("Epiphany"); */
            //  Sanitizing Strings  |  Convert String Into A Single Space String
            Console.WriteLine(StringSanitizer.CollapseWhiteSpace("   \n\n Hi There, I'm Emmy!   \t\t\t\t"));
    }
}


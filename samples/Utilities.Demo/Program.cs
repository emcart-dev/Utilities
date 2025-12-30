//  Demo console for testing classes and calling methods
using Utilities.Strings;

class Program {
    static void Main(string[] args) {
        //  Transforming Strings  |  Reverse String
        Console.WriteLine(StringTransform.Reverse("hello"));
        
        //  Transforming Strings  |  Convert String to Title Case
        Console.WriteLine(StringTransform.ToTitleCase("Epiphany"));
    }
}



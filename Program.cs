using System.Linq;
class Program{

    static DataLibrary data;
    static string inputmenu;

    static void Main(){
        data = new DataLibrary();
        SelectedMenuText();
    }

    public static void SelectedMenuText(){
        Console.WriteLine("Input Menu");
        Console.WriteLine("A = Academia Data");
        Console.WriteLine("B = Academia Instance");
        Console.WriteLine("C = Minimun FT");
        SelectedMenu();
    }

    public static void SelectedMenu(){
        inputmenu = Console.ReadLine();
        if(InputA()) data.AcademiaData(); 
        if(InputB()) data.AcademiaInstance(); 
        if(InputC()) data.MinimumFT(); 
    }

    public static bool InputA(){
        if(inputmenu == "A" || inputmenu == "a") return true;
        return false;
    }

    public static bool InputB(){
        if(inputmenu == "B" || inputmenu == "b") return true;
        return false;
    }

    public static bool InputC(){
        if(inputmenu == "C" || inputmenu == "c") return true;
        return false;
    }
}
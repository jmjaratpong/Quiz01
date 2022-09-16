using System.Linq;
public class DataLibrary{
    float minimumft;
    public DataLibrary(){

    }
    
    public void AcademiaData(){
        Console.WriteLine("School Name : Library Name : Address : Phone Number");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Chulalonkorn : Rukdee : Pratumwan Bkk : 02-215-3555");
        Console.WriteLine("Mahidol : Rukrok : Saraya Nakornpratom: 02-849-6211");
        Console.WriteLine("KMITL : Gayge : Ladkrabang : 02-329-8000");
        Console.WriteLine("Khonkan : Wattana : Mueng Khonkan : 043-002539");
        Console.WriteLine("KMUTT : Ahthan : Thungkru Bkk : 02-470-8000");
    }

    public void AcademiaInstance(){
        Console.WriteLine("School Name : Instance FirstName : Instance LastName : ID Number");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Chulalonkorn : Mr.Chaidee : Rakdee : 153-698-4561237");
        Console.WriteLine("Mahidol : Mr.Nondee : Jaidee : 742-112-5687412");
        Console.WriteLine("KMITL : Mr.Apaidee : Reandee : 541-772-3215689");
        Console.WriteLine("Khonkan : Mr.Tumdee : Ngandee : 777-772-4578923");
        Console.WriteLine("KMUTT : Mr.Nondee : Reabdee : 003-852-4752000");
    }

    public void MinimumFT(){
        ElectricCalculate calculate = new ElectricCalculate();
        calculate.Calculate();
        minimumft = (from x in ElectricCalculate.FtList select x).Min();
        Console.WriteLine(CheckAcademy() + " : " + minimumft);
    }

    public string CheckAcademy(){
        if (minimumft == ElectricCalculate.FtList[0]) return "Chulalonkorn : Rukdee";
        else if(minimumft == ElectricCalculate.FtList[1]) return "Mahidol : Rukrok";
        else if(minimumft == ElectricCalculate.FtList[2]) return "KMITL : Gayge";
        else if(minimumft == ElectricCalculate.FtList[3]) return "Khonkan : Wattana";
        else if(minimumft == ElectricCalculate.FtList[4]) return "KMUTT : Ahthan";
        else return default;

    }
}
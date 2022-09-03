namespace LeapYear;

public class Program {
    public Program(){
    }

    public static void Main(){
        Console.WriteLine("Type in a year:");
        int year = Convert.ToInt32(Console.ReadLine());
        if(IsLeapYear(year)){
            Console.WriteLine("yay");
        } else {
            Console.WriteLine("nay");
        }
    }
    
    public static bool IsLeapYear(int year){
        if(year%4 == 0){
            if(year%100 == 0){
                if(year%400 == 0){
                    return true;
                }
                return false;
            }
            return true;
        }
        return false;
    }
}
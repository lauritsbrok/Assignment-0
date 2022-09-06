namespace MyApp;

public class LeapYear {
    
    public static bool IsLeapYear(int year) {
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

    public static void PrintIsLeapYear(string year){
        try{
            int yearInt = Convert.ToInt32(year);
            if(IsLeapYear(yearInt)){
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            }
        } catch {
            Console.WriteLine("You must enter a valid number!");  
        }
    }
}
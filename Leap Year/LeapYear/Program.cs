﻿namespace LeapYear;

public class Program {
    public Program(){
    }

    public static void Main(){
            
    }
    
    public bool IsLeapYear(int year){
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
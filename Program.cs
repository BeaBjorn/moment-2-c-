/*

Studnet: Beatrice Björn
Asssignment: Moment 2 - DT071G -  Programmering i C#.NET
Last updated: 

*/

namespace moment2
{
    class Program
    {
        static void Main(string[] args)
        {
//try is used to try en run the code, if the code cant't run the code block inside "catch" will run to prevent the program from crashing.             
            try{

//The sentence inside the brackets below will show when the command dotnet run is used in the console. 
Console.WriteLine("Skriv in ditt födelsedatum (åååå-mm-dd)");

//The data entered in the console is collected by using console.readline and then stored in a variable named "date"
    var date = Console.ReadLine();

//The data stored in the variable "date" is split into four different sections using substring and then stored in variables
    string cen = date.Substring(0, 2);
    string year = date.Substring(2, 2);
    string month = date.Substring(5, 2);
    string day = date.Substring(8, 2);

//The data is converted from string to int
    int c = Convert.ToInt16(cen);
    int y = Convert.ToInt16(year);
    int m = Convert.ToInt16(month);
    int d = Convert.ToInt16(day);

//An if-statement is used to check if "m" is smaller than 3. If so, 12 is added to "m" and 1 is subtracted from "y"
        if (m < 3)
        {
            m = m + 12;
            y--;
        }

//A variable named "id" that stores the number retrived after the calculation in zellers algorithm
        int id = (d + ((13*(m+1))/5) + y + (y/4) + (c/4) + 5*c ) % 7;

//An array named "weekDayArr" with the names of the weekdays
        string[] weekDayArr = {"Lördag", "Söndag", "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag"};

//A string named "dayOfWeek" that uses the number stored in variable "id" to get the string in the array with the index stored in "id"
        string dayOfWeek = weekDayArr[id];

//Console.writeline is used to print the day of the week someone was born in the console
    Console.WriteLine($"{Environment.NewLine}Du föddes på en {dayOfWeek}");

//Console.write is used to print a message in the console
    Console.Write($"{Environment.NewLine}Tryck på valfri tanget för att avsluta...");
//Console.Readkey is set to true to quit the program when any key is pressed
    Console.ReadKey(true);
    }
//The "catch" will run if the script in "try" can't run without crashing
        catch{
         Console.WriteLine($"{Environment.NewLine}Datumet du fyllt i är inkorrekt. Skriv in ditt föelsedatum i följande format: 1992-09-19");
        }
    }
}
}
/*

Studnet: Beatrice Björn
Asssignment: Moment 2 - DT071G -  Programmering i C#.NET
Last updated: 

*/

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
Console.WriteLine("Skriv in ditt födelsedatum (åååå-mm-dd)");
    var date = Console.ReadLine();

    string cen = date.Substring(0, 2);
    string year = date.Substring(2, 2);
    string month = date.Substring(5, 2);
    string day = date.Substring(8, 2);

    int c = Convert.ToInt16(cen);
    int y = Convert.ToInt16(year);
    int m = Convert.ToInt16(month);
    int d = Convert.ToInt16(day);

        if (m < 3)
        {
            m = m + 12;
            y--;
        }

        int id = (d + ((13*(m+1))/5) + y + (y/4) + (c/4) + 5*c ) % 7;

        string[] weekDayArr = {"Lördag", "Söndag", "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag"};

        string dayOfWeek = weekDayArr[id];

    Console.WriteLine($"{Environment.NewLine}Du föddes på en {dayOfWeek}");
    Console.Write($"{Environment.NewLine}Tryck på valfri tanget för att avsluta...");
    Console.ReadKey(true);
    //
    }
        catch{
         Console.WriteLine($"{Environment.NewLine}Datumet du fyllt i är inkorrekt. Skriv in ditt föelsedatum i följande format: 1992-09-19");
        }
    }
}
}
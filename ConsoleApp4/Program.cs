// See https://aka.ms/new-console-template for more information

using System.Globalization;

public class Program 
{
    public static void Main(string[] args)
    {
      DateTime datetime = DateTime.ParseExact("06/07/2023" , "dd/MM/yyyy" , CultureInfo.InvariantCulture);
        TimeSpan timespan = new TimeSpan(30, 6, 17);
        var newdatetime = datetime.Add(timespan);
        Console.WriteLine("Current datetime:" + datetime);
        Console.WriteLine("1 month later datetime:" + newdatetime);






        Console.Read();
    }

    
}

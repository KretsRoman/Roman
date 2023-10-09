using System;
using System.text;
using System.Globalization;

class Programm {
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        CultureInfo ukrainianCulture = new CultureInfo("uk-UA");
        System.Threading.Thread.CurrentCulture = ukrainianCulture;
        System.Threading.Thread.CurrentUICulture = ukrainianCulture;

        int price1 = 25;
        string ProductName1 = "Хліб";

        int price2 = 34;
        string ProductName2 = "Молоко";

        int price3 = 45;
        string ProductName3 = "Яйця";

        int price4 = 15;
        string ProductName4 = "Чай";

        int price5 = 30;
        string ProductName5 = "Кава";

        ConsoleWriteLine ("Продукт: " + ProductName1 + ", ціна: " + price1 + " грн"),
        ConsoleWriteLine ("Продукт: " + ProductName2 + ", ціна: " + price2 + " грн"),
        ConsoleWriteLine ("Продукт: " + ProductName3 + ", ціна: " + price3 + " грн"),
        ConsoleWriteLine ("Продукт: " + ProductName4 + ", ціна: " + price4 + " грн"),
        ConsoleWriteLine ("Продукт: " + ProductName5 + ", ціна: " + price5 + " грн"),
    }
}

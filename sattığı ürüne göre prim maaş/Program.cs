//  salary = 200
//  Sales = print gross sales
//  LastSales = Sales + gross*9/100
//  print Your Sales = LastSales
//  if ( Sales == -1)
//  break


using System.Globalization;

while (true)
{
    int salary = 200;
    
    Console.Write(" please enter your sale = ");
   float sale = Convert.ToSingle(Console.ReadLine()); 

    if (sale == -1)
    {
        break;
    }

    float gross = salary + sale * 9 / 100;

    Console.WriteLine($"your gross is = {gross}");
}









//  maaş = 200
//  satış = brüt satışı giriniz
//  sonmaaş = maaş + brüt*9/100
//  print maaşınız = sonmaaş
//  if ( satış == -1)
//  break


while (true)
{
    int salary = 200;
    
    Console.Write(" please enter your sale(satış) = ");
   float sale = Convert.ToSingle(Console.ReadLine()); 

    if (sale == -1)
    {
        break;
    }

    float brüt = salary + sale * 9 / 100;

    Console.WriteLine($"your brüt is = {brüt}");
}






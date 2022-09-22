Console.Write("ваш рост: ");
double   height = Convert.ToInt32(Console.ReadLine());
Console.Write("Ваш вес:  ");
double   mass = Convert.ToInt32(Console.ReadLine());
double   IMT = Math.Round(mass/((height*height)/10000),2);
Console.Write($"индекс массы вашего тела составляет - {IMT} ");
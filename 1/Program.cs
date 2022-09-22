Console.Write("ваш рост: ");
double   height = Convert.ToInt32(Console.ReadLine());
Console.Write("Ваш вес:  ");
double   mass = Convert.ToInt32(Console.ReadLine());
double   IMT = mass/((height*height)/10000);
Console.Write($"индекс массы вашего тела составляет - {IMT} ");// необходимо округлить это число до сотых
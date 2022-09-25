Console.Write("ваш рост: ");
double   height = Convert.ToInt32(Console.ReadLine());
Console.Write("Ваш вес:  ");
double   mass = Convert.ToInt32(Console.ReadLine());

double ImtMass (double height, double mass) // метод вычисления ИМТ
{
double   IMT = Math.Round(mass/((height*height)/10000),2);
return IMT;
}


string ConditionMass(double a) // метод определения состояния здоровья

{
    if (a < 16)
        return ("дефецит веса");
    if (a < 18.5 )
        return ("недостаточная масса тела");
    if (a < 24.99)
        return("нормальная масса тела");
    if (a < 30)
        return ("избыватная масса тела");
    if (a < 35 )
        return ("ожирение");
    if (a < 40 )
        return ("резкое ожирение ");
    else
        return ("полный ппц");
    
}
double a = ImtMass (height, mass);
string b = ConditionMass(a);
Console.WriteLine($"Индекс массы тела составляет {a} и это {b}");
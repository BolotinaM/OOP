 interface iStatistic 
 {  double Calc(double a, double b);
    string Title();
 }

 class Sum : iStatistic 
 {
    public double Calc(double a, double b)
 {
    return a + b;
 }
 public string Title()
 {
    return "Сумма";
 }
 }
 class Avg : iStatistic 
 {
    public double Calc(double a, double b)
 {
    return (a + b) / 2;
 }
public string Title()
 {
    return "Среднее арифметическое: ";
 }
 }

 class Disp : iStatistic 
 {
    public double Calc(double a, double b)
 {
        return ((a*a)*2 + (b*b)*2) / 5;
 }
public string Title()
 {
    return "Дисперсия: ";
 }
 }

 class Calculator
 {
 public List<iStatistic > operations;
 public Calculator()
 {
    operations = new List<iStatistic >(); //- создание списка операций
    operations.Add(new Sum());// -добавление объекта класса операции сложения к списку операций
    operations.Add(new Avg());// -добавление объекта класса операции среднего арифметического
    operations.Add(new Disp()); // - добавление объекта класса операции нахождения дисперсии
 }
 }

 class Program
 {
    static void Main(string[] args)
    {
        Calculator clc = new Calculator();
 //вывод списка меню:
        for (int i = 0; i < clc.operations.Count; i++)
        {
            Console.WriteLine("{0}: {1}", i, clc.operations[i].Title());
        }
 //обработчик исключительных ситуаций:
        try
        {
            Console.Write("Укажите номер операции: ");
            int cnt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Укажите значение 1-го операнда: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите значение 2-го операнда: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат: {0}", clc.operations[cnt].Calc(a, b));
        }
        catch
        {
            Console.WriteLine("Ошибка ввода!!!");
        }
        Console.ReadKey();
        }
 }

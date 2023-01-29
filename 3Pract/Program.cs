using System;
 
namespace temp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var MyPair = new Pair();
            MyPair.p1=138;
            MyPair.p2=85;
            Console.WriteLine(MyPair.DoComparison());
            
            var MyFraction=new Fraction();
            MyFraction.p1=100.123;
            MyFraction.p2=10.12233;
            Console.WriteLine(MyFraction.DoComparsion());
            
            Console.ReadKey();
        }
    }
}

namespace temp
{
    
    public class Pair
    {
        public double p1,p2;
        public Pair()
        {
            p1=0;
            p2=0;   
        }
        
        public string DoComparison()
        {
            if (p1>p2) return "p1 больше p2";
            if (p1<p2) return "p1 меньше p2";
            if (p1==p2) return "p1 равно p2";
            return "";
        }
    }
}

namespace temp
{
    /// <summary>
    /// Description of Fraction.
    /// </summary>
    public class Fraction:Pair
    {
        
        public Fraction()
        {
            
        }
        
        public string DoComparsion()
        {
            if (Math.Floor(p1)>Math.Floor(p2)) return "целая часть p1 больше целой части p2";
            if (Math.Floor(p1)<Math.Floor(p2)) return "целая часть p1 меньше целой части p2";
            if (Math.Floor(p1)==Math.Floor(p2)) return "целая часть p1 равна целой части p2";
            return"";
        }
    }
}
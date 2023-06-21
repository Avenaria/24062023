using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24062023
{
     public delegate double AnanimDel(double x, double y); 
     public delegate int AnanimDel1(int x, int y); 
     public delegate void AnanimDel2(); 

    class Dispetcher
    {
        public event AnanimDel evenDouble;
        public event AnanimDel1 oddDouble;
        public event AnanimDel2 kjbk;

        public double OnEvenDouble(double x, double y)
        {
             if(evenDouble != null) {  return evenDouble(x,y); }
            throw new DivideByZeroException();
        }
        public int OnEvenint(int x, int y)
        {
            if (oddDouble != null) { return oddDouble(x, y); }
            throw new DivideByZeroException();
        }
    }

    internal class Program
    {
         
        static void Main(string[] args)
        {
            Dispetcher dispetcher = new Dispetcher();
            dispetcher.evenDouble+= delegate(double x, double y)
            {
                if (y != 0)
                {
                    return x / y;
                }
                throw new DivideByZeroException();
            };

            Console.WriteLine(dispetcher.OnEvenDouble(56, 5.2));
            AnanimDel p = delegate { Console.WriteLine("OK"); };
            AnanimDel ananimDel = new AnanimDel(p);
            
            
            //лямбда выражение => delegate (параметры){ код реализиции }; ()=>{}
            // void лямбда new An (() => {djghsldfhlasjf}
        }
    }
}

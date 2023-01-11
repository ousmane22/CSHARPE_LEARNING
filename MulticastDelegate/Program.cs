using System;

namespace MulticastDelegate
{
    delegate void CustomDel(string s);
    public  class Program
    {

        public static void Hello(string s)
        {
            Console.WriteLine("Hello");
        }

        public static void GoodBye(string s)
        {
            Console.WriteLine("Good Bye");
        }
        public  static void Main()
        {
            CustomDel hiDel, byeDel, multiDel, MultiMinusHidel;

            hiDel = Hello;
            byeDel = GoodBye;

            multiDel = hiDel + byeDel;

            MultiMinusHidel = multiDel - hiDel;


            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("A");
            Console.WriteLine("Invoking delegate byeDel:");
            byeDel("B");
            Console.WriteLine("Invoking delegate multiDel:");
            multiDel("C");
            Console.WriteLine("Invoking delegate multiMinusHiDel:");
            MultiMinusHidel("D");
        }



       
    }

}

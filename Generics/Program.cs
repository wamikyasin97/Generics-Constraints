using System;

namespace Generics
{
    class KeyInfo<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    class NotInt<Tstring, Tage> where Tstring : class
    {
        public Tstring name { get; set; }
        public Tage age { get; set; }
        public Tstring email { get; set; }


    }

    class Program
    {
        static void Main(string[] args)
        {
            KeyInfo<string, int> myKeyInfo = new KeyInfo<string, int>();
            KeyInfo<string, string> myKeyInfo1 = new KeyInfo<string, string>();

            NotInt<string, int> myNotInt = new NotInt<string, int>();

            myKeyInfo.Key = "ICT";
            myKeyInfo.Value = 100;

            myKeyInfo1.Key = "SQA";
            myKeyInfo1.Value = "Computer Science";

            myNotInt.name = "Wamik Yasin";
            myNotInt.age = 23;
            myNotInt.email = "wamikyasin@gmail.com";

            Console.WriteLine(myKeyInfo.Key);
            Console.WriteLine(myKeyInfo.Value);

            Console.WriteLine(myKeyInfo1.Key);
            Console.WriteLine(myKeyInfo1.Value);

            Console.WriteLine(myNotInt.name);
            Console.WriteLine(myNotInt.age);
            Console.WriteLine(myNotInt.email);
        }
    }
}

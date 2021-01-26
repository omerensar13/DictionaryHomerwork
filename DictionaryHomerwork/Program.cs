using System;

namespace DictionaryHomerwork
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string> ();
            myDictionary.Add("Adem");
            myDictionary.Add("Halil");
            myDictionary.Add("Ömer");
            Console.WriteLine(myDictionary.Lenght);
            foreach (var isimler in myDictionary.Items)
            {
                Console.WriteLine(isimler);
            }
            
        }
    }
}

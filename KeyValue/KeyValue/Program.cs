using System;
using System.Collections.Generic;

namespace KeyValues
{
    public struct KeyValues<T>
    {
        public readonly string Key;
        public readonly T Value;
        public KeyValues(string key, T value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
    public class MyDictionary<T>
    {
        KeyValues<T>[] structArray = new KeyValues<T>[5];
        public T this[string index]
        {
            get
            {
                for (int i = 0; i < structArray.Length; i++)
                {
                    if (structArray[i].Key == index)
                    {
                        Console.WriteLine("From the indexer");
                        Console.WriteLine(structArray[i].Value);
                        Console.WriteLine(structArray[i].Key + "\n");
                        return structArray[i].Value;
                    }
                }
                throw new KeyNotFoundException(index);
            }
            set
            {
                for (int i = 0; i < structArray.Length; i++)
                {
                    if (structArray[i].Key == index)
                    {
                        structArray[i] = new KeyValues<T>(index, value);
                        return;
                    }
                    else if (structArray[i].Key == null)
                    {
                        structArray[i] = new KeyValues<T>(index, value);
                        return;
                    }
                }
            }
        }
        class Program
        {
            public static void Main(string[] args)
            {
                var d = new MyDictionary<object>();
                try
                {
                    Console.WriteLine(d["Cats"]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                d["Cats"] = 42;
                d["Dogs"] = 17;
                Console.WriteLine($"From the main method \n {(int)d["Cats"]}, {(int)d["Dogs"]}\n \n");
            }
        }
    }
}

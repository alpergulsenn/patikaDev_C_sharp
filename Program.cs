using System;

namespace degisken
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5; //1 byte
            sbyte sb = 5; //1 byte

            short s = 5; //2 byte
            ushort us = 5; //2 byte

            int i = 123411; //4 byte
            uint ui = 45413; //4 byte
            long l = 56123; //8 byte
            ulong ul = 87123; //8 byte

            float fl = 1.487f; //4 byte
            double d = 5.7986; //8 byte
            decimal dc = 12.5m; //16 byte

            char c = 'A';  //2 byte
            string str = "I can write whatever I want."; // sınırsız

            bool b1 = false; //1 byte

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = 'X';
            object o2 = 'y';
            object o3 = 5;

            string str1 = string.Empty;
            str1 = "str1 is not empty anymore..";
            Console.WriteLine(str1);

            //adding integer together

            int i1 = 1, i2 = 65;
            int i3 = i1 + i2;  // Output = 67

            //boolean

            bool bool2 = 10 > 2;
            Console.WriteLine(bool2); // Output = True

            //Casting and type conversions

            string str20 = "20";
            int int20 = Convert.ToInt32(str20);

            int int22 = int20 + int.Parse(str20); //total- 22

            //datetime

            string datetime = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime);


        }
    }
}
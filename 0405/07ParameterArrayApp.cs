using System;


namespace Basic
{
    

    class ParameterArrayApp { 

        static void ParameterArray(params object[] obj)
        {
            for (int i = 0; i < obj.Length; i++)
                Console.WriteLine(obj[i]);
        }
        static void Main(string[] args)
        {
            ParameterArray(123, "Hello", true, 'A');
        }



    }

}
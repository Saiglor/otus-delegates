using System;
using System.Collections;
using System.Collections.Generic;
using Otus.Delegates.Application.Extensions;

namespace Otus.Delegates.Application
{
    class Program
    {
        static void Main()
        {
            IEnumerable items = new List<string> { "52", "448", "12" };

            try
            {
                var res = items.GetMax<string>(float.Parse);

                Console.WriteLine(res);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат входных данных");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
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
            var res = items.GetMax<string>(float.Parse);
            Console.WriteLine(res);
        }
    }
}
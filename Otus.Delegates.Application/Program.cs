using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Otus.Delegates.Application.Extensions;
using Otus.Delegates.Application.Services;

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

            var fileStorageService = new FileStorageService();
            fileStorageService.FileFound += DisplayMessage;
            fileStorageService.FileSearch($"{GetSolutionPath()}\\Для теста");
            fileStorageService.FileFound -= DisplayMessage;
        }

        public static string GetSolutionPath()
        {
            return Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.Parent?.FullName;
        }

        public static void DisplayMessage(object sender, FileArgs e)
        {
            Console.WriteLine($"Найден файл {e.FileName}");
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Excercises.Chapter02.Examples;
using static System.Console;

namespace FPC.Console
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var shoppingList = new List<string>() {"coffee beans", "BANANAS", "Dates"};
            new ListFormatter().Format(shoppingList).ForEach(WriteLine);

            var size = 100000;
            var list = Enumerable.Range(1, size).Select(i => $"item{i}").ToList();

            list.Select(StringExt.ToSentenceCase).ToList().ForEach(WriteLine);
            list.AsParallel().Select(StringExt.ToSentenceCase).ToList().ForEach(WriteLine);


            new ListFormatter().Impure(list).ToList().ForEach(WriteLine);
            new ListFormatter().ImpureParalell(list).ToList().ForEach(WriteLine);
        }
    }
}
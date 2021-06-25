using System.Collections.Generic;
using System.Linq;

namespace Excercises.Chapter02.Examples
{
    using static Enumerable;

    public static class StringExt
    {
        public static string ToSentenceCase(this string s) => s.ToUpper()[0] + s.ToLower().Substring(1);
    }

    public class ListFormatter
    {
        private int counter;

        public string PrependCounter(string s) => $"{++counter}. {s}";

        public List<string> Format(List<string> list) =>
            list.Select(StringExt.ToSentenceCase).Select(PrependCounter).ToList();

        public List<string> Impure(List<string> list) =>
            list.Select(StringExt.ToSentenceCase).Select(PrependCounter).ToList();

        public List<string> ImpureParalell(List<string> list) =>
            list.Select(StringExt.ToSentenceCase).AsParallel().Select(PrependCounter).ToList();

        public static List<string> FormatZip(List<string> listl)
        {
            var left = listl.Select(StringExt.ToSentenceCase);
            var right = Range(1, listl.Count);
            var zipped = Enumerable.Zip(left, right, (s, i) => $"{i}. {s}");
            return zipped.ToList();
        }
    }
}
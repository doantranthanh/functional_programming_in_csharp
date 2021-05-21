using System;

namespace Excercises.Chapter01
{
    public static class Solutions
    {
        /*
        2. Write a function that negates a given predicate: whenever the give predicate evaluates to true, then resulting function evaluates to
        false, and vice versa
         */
        public static Func<T, bool> Negate<T>(this Func<T, bool> pred) => t => !pred(t);
    }
}

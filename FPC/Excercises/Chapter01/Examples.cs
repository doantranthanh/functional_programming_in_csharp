using System;

namespace Excercises.Chapter01
{
    public static class Examples
    {
        public static Func<T2, T1, R> SwapArgs<T1, T2, R>(this Func<T1, T2, R> func) => (t2, t1) => func(t1, t2);
    }
}
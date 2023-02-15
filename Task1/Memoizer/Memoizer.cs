using System;

namespace MemoizerLib
{
    public static class Memoizer
    {
        public static Func<R> Memoize<R>(Func<R> func)
        {
            bool filled = false;
            R cache = default(R);
            return () =>
            {
                if (!filled) 
                { 
                    cache = func();
                    filled = true;
                }
                return cache;
            };
        }
    }
}

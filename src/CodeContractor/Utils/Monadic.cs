﻿using System;

namespace CodeContractor.Utils
{
    public static class Monadic
    {
        public static U As<T, U>(this T t, Func<T, U> convertor) where U : class
        {
            return convertor(t);
        }
    }
}
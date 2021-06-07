﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApi.Extensions
{
    public static class StringExtension
    {
        public static string ToSnakeCase(this string o) =>
            Regex.Replace(o, @"(\w)([A-Z])", "$1_$2").ToLower();
        public static string ToDashCase(this string o) =>
            Regex.Replace(o, @"(\w)([A-Z])", "$1-$2").ToLower();
    }
}

using SimpleTesting.Model;
using System;
using System.Security.Cryptography;

namespace SimpleTesting
{
    public static class Utils
    {
        public static readonly TestsContext dbContext = new TestsContext();
        public const int minFieldLength = 2;
    }
}

using System;

namespace RedmineTaskListPackage
{
    static class Guids
    {
        public const string guidRedminePkgString = "97535913-77a4-4d2a-ba30-6c4702d8ec5c";
        public const string guidRedmineCmdSetString = "9c14cb93-71d4-4508-9135-d5486cc72147";

        public static readonly Guid guidRedmineCmdSet = new Guid(guidRedmineCmdSetString);
    };
}
using System;

namespace HarmonyMod
{
    public static class LogHelper
    {
        private static int logInt = 0;

        public static void GremyLogger(String message)
        {
            logInt++;
            Console.WriteLine("Gremy Log " + logInt + ": " + message);
        }
    }
}
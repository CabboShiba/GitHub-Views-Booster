using System;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Linq;
using System.IO;

namespace ProfileViews_Botter
{
    internal class Utils
    {
        public static string Time()
        {
            DateTime time = DateTime.Now;
            return time.ToString();
        }
        public static void Leave()
        {
            Console.WriteLine($"[{Utils.Time()}] Finished. Press enter to leave...");
            Console.ReadLine();
            Process.GetCurrentProcess().Kill();
        }
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void SaveCamoLink()
        {
            string path = Environment.CurrentDirectory + @"\CamoLink.txt";
            try
            {
                File.WriteAllText(path, Program.camolink);
                Console.WriteLine($"[{Utils.Time()}] Camo GH Link succesfully saved here: {path}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{Utils.Time()}] Could not save your Camo GH Link. Error: {ex.Message}");
            }
        }
    }
}

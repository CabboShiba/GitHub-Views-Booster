using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ProfileViews_Botter
{
    internal class Program
    {
        public static string Title = $"[{Utils.Time()}] GitHub Views Botter by Cabbo";
        public static string camolink;
        static void Main(string[] args)
        {
            Console.Title = Title;
            Console.WriteLine($"[{Utils.Time()}] Please provide a valid Camo GH Link:");
            Console.Write($"[{Utils.Time()}] ");
            camolink = Console.ReadLine();
            Utils.SaveCamoLink();
            Console.WriteLine($"[{Utils.Time()}] Please provide a valid amount of views to send (0 = infinite):");
            Console.Write($"[{Utils.Time()}] ");
            int viewsnum;
            bool InfOrNot;
            try
            {
                viewsnum = Convert.ToInt32(Console.ReadLine());
                if (viewsnum == 0)
                {
                    UniversalClient.Client(viewsnum, InfOrNot = true);
                }
                else
                {
                    UniversalClient.Client(viewsnum, InfOrNot = false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{Utils.Time()}] This it not a valid number. Error: {ex.Message}");
            }
            Utils.Leave();
        }
    }
}

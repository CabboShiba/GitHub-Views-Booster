using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ProfileViews_Botter
{
    internal class UniversalClient
    {
        public static int ViewsSent = 0;
     
        public static void Client(int viewsnum, bool InfOrNot = true)
        {
            Console.Clear();
            if (InfOrNot)
            {
                while (true)
                {
                    Botter();
                }
            }
            else
            {
                for (int i = 0; i < viewsnum; i++)
                {
                    Botter();
                }
            }
        }
        public static void Botter()
        {
            try
            {
                var req = (HttpWebRequest)WebRequest.Create(Program.camolink);
                req.KeepAlive = true;
                req.Method = "GET";
                req.Headers.Add("Name", "camo.githubusercontent.com");
                var httpResponse = (HttpWebResponse)req.GetResponse();
                httpResponse.Close();
                req.Abort();
                Console.WriteLine($"[{Utils.Time()}] Succesfully sent view. REQ Status Code: {httpResponse.StatusCode}");
                Console.Title = Program.Title + $" | Views sent: {ViewsSent + 1}";
                ViewsSent = ViewsSent + 1;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[{Utils.Time()}] Error during botting process: {ex.Message}");
                Console.Title = Program.Title + $" | Views sent: {ViewsSent}";
                Console.ResetColor();
            }
        }
    }
}


using System;
using System.Text;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string image = @"C:\Users\Dian\Desktop\D-A-Cenov.png"; //Enter image adress.

            Console.WriteLine(ReturnUrl(image));
            Console.Write("Pres any key...");
            Console.ReadLine();
        }

        private static string ReturnUrl(string image) 
        {
            string ClientId = "0ad329854c9fb71";
            WebClient w = new WebClient();
            w.Headers.Add("Authorization", "Client-ID " + ClientId);
            System.Collections.Specialized.NameValueCollection Keys = new System.Collections.Specialized.NameValueCollection();
            try
            {
                Keys.Add("image", Convert.ToBase64String(File.ReadAllBytes(image)));
                byte[] responseArray = w.UploadValues("https://api.imgur.com/3/image", Keys);
                dynamic result = Encoding.ASCII.GetString(responseArray);
                System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("link\":\"(.*?)\"");
                Match match = reg.Match(result);
                string url = match.ToString().Replace("link\":\"", "").Replace("\"", "").Replace("\\/", "/");
                return url;
            }
            catch (Exception s)
            {

                Console.WriteLine("Something went wrong. " + s.Message);
                return "Failed!";
            }
        }
    }
}

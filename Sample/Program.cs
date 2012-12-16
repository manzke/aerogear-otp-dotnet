using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Org.Jboss.Aerogear.Security.Otp.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Please type your name: ");
            string name = System.Console.ReadLine();
            System.Console.Write("Please type your secret: ");
            Org.Jboss.Aerogear.Security.Otp.Totp totp = new Org.Jboss.Aerogear.Security.Otp.Totp(System.Console.ReadLine());
            System.Console.WriteLine("uri " + totp.Uri(name));

            while (true)
            {
                string Now = totp.Now;
                System.Console.WriteLine("pin " + Now + " verified: " + totp.Verify(Now));
                
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}

using System;
using System.Security.Cryptography;

namespace MyLibrary
{
    public class MyCryptoClass
    {
        static void Main()
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024); // Noncompliant
            // ...
        }
    }
}

using System;
using System.Collections;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;
using System.Xml;
using System.Xml.Schema;


namespace Lesson_4;
class Swichcase
{  

    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        #region 
        Console.Write("Enter your number:");
        int number = Convert.ToInt32( Console.ReadLine());

        switch (number)
        {
            case 1 :
            Console.Write("Thứ 2");
            break;

            case 2 :
            Console.Write("Thứ 3");
            break;

            case 3 :
            Console.Write("Thứ 4");
            break;

             case 4 :
            Console.Write("Thứ 5");
            break;

             case 5 :
            Console.Write("Thứ 6");
            break;

             case 6 :
            Console.Write("Thứ 7");
            break;



            default:
            Console.Write("Invalid number");

            break;
        }
        #endregion 


    }

}
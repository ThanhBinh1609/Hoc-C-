using System;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;
using System.Xml;
using System.Xml.Schema;


namespace Lesson_4;


class Program
{  

    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;


      // Console.Write("Mời bạn nhập ngày sinh: " );   
      // Console.WriteLine("Ngày sinh là:" + Console.ReadLine());

      // Console.Write ("Mời bạn nhập tuổi:");
      // Console.WriteLine ("Tuổi của bạn là:" + Console.ReadLine());

      // Console.ReadKey();

     
      
      // Console.Write("Enter your height:");
      // var height = Convert.ToDouble(Console.ReadLine());
      // Console.Write("Enter your weight:");
      // var weight = Convert.ToDouble(Console.ReadLine());
      
      // Console.WriteLine($"Your BMI: {weight/(height*height)}" );
      
      // bool gender = true;
      // bool married = true;
      // string name = Binh

      // if (gender)
      // {Console.WriteLine ("Mr")}
      // else
      // {
      //   if (married)
      //    {Console.WriteLine ("Mrs")}
      // }


    //   Console.Write("Enter number_1:");
    //   int number_1 = Convert.ToInt32(Console.ReadLine());
    //   Console.Write("Enter number_2:");
    //   int number_2 = Convert.ToInt32(Console.ReadLine());
    //   Console.Write("Enter number_3:");
    //   int number_3 = Convert.ToInt32(Console.ReadLine());

    //   if (number_1>number_2)
    //  {
    //   if(number_1>number_3)
    //   {Console.WriteLine (${number_1} La so lon nhat)
      
    //   }
    //  }

    // 

    // Console.Write("Enter weight:");
    // double weight = Convert.ToDouble(Console.ReadLine());

    // Console.Write("Enter height:");
    // double height = Convert.ToDouble(Console.ReadLine());

    // Console.WriteLine($"Chỉ số BMI của bạn là: {weight/(height*height)}");


    // Đề bài: Nhập tên và check đúng sai. 
    // bool gender =false;
    // bool married= false;
    // string name = "BinhLee";

    // if(gender)
    // {Console.WriteLine($"Mr{name}");    
    // }
    // else{
    //     if(married)
    //     {
    //         Console.WriteLine($"Mrs{name}");
    //     }
    //     else{
    //        Console.WriteLine($"Ms{name}"); 
    //     }
    // }

    // bài tập nhập 3 số tìm số lớn nhất
    // Console.Write("Enter number_1:");
    // int number_1 = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Enter number_2:");
    // int number_2 = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Enter number_3:");
    // int number_3 = Convert.ToInt32(Console.ReadLine());

    // if(number_1>number_2&&number_1>number_3)
    // {
    //      Console.WriteLine($"{number_1} là số lớn nhất");
    // }

    // if(number_2>number_1&&number_2>number_3)
    // {
    //      Console.WriteLine($"{number_2} là số lớn nhất");
    // }

    //  if(number_3>number_1&&number_3>number_2)
    // {
    //      Console.WriteLine($"{number_3} là số lớn nhất");
    // }

    // Tính chỉ số BMI và hiển thị kết quả theo trạng thái========================BTVN1

    // Console.Write("Enter weight:");
    // double weight = Convert.ToDouble(Console.ReadLine());
    // Console.Write("Enter height:");
    // double height = Convert.ToDouble(Console.ReadLine());
    // double bmi = weight/(height*height);

    // if(bmi<18)
    // {
    //    Console.WriteLine($"Chỉ số BMI của lạn là {bmi}. Bạn bị gầy");
    // }

    // if(bmi>=18 && bmi<24.9)
    // {
    //    Console.WriteLine($"Chỉ số BMI của lạn là {bmi}. Bạn bình thường");
    // }

    // if(bmi>=24.9 && bmi<29.9)
    // {
    //    Console.WriteLine($"Chỉ số BMI của lạn là {bmi}. Bạn bị tăng cân");
    // }

    // if(bmi>=29.9 && bmi<34.9)
    // {
    //    Console.WriteLine($"Chỉ số BMI của lạn là {bmi}. Bạn bị béo phì độ 1");
    // }

    // if(bmi>=34.9 && bmi<39.9)
    // {
    //    Console.WriteLine($"Chỉ số BMI của lạn là {bmi}. Bạn bị béo phì độ 2");
    // }

    // if(bmi>=39.9)
    // {
    //    Console.WriteLine($"Chỉ số BMI của lạn là {bmi}. Bạn bị béo phì độ 3");
    // }
    
    // Viết chương trình giải phương trình bậc 2 ========================BTVN2

    Console.WriteLine("Chương trình giải phương trình bậc 2: ax2+bx+c=0");
    Console.Write("Enter number a:");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter number b:");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter number c:");
    double c = Convert.ToDouble(Console.ReadLine());
    double delta = (b*b)-(4*a*c);
    double squtDelta = Math.Sqrt(delta);

    if (a == 0)
    { 
        if (b==0 && c==0)
        {
           Console.WriteLine($"Phương trình có vô số nghiệm"); 
        }

        if(b==0 && c!=0)
        {
           Console.WriteLine($"Phương trình có vô nghiệm"); 
        }

        if(b!=0)
        {
           Console.WriteLine($"Phương trình có một nghiệm duy nhất là {-c/b}"); 
        }
    }
    else{
        if (delta<0)
        {
           Console.WriteLine($"Phương trình có vô nghiệm"); 
        }
        if (delta==0)
        {
           Console.WriteLine($"Phương trình có nghiệm kép là {-b/(2*a)}"); 
        }
         if (delta>0)
        {
           Console.WriteLine($"Phương trình có hai nghiệm phân biệt là x2= {(-b - squtDelta) / 2*a} và x2={(-b + squtDelta) / 2*a}"); 
        }
    }


    

        
    }
}

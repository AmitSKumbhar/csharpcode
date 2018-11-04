using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0; 
            String str = "India,Newzeland,Indonatia";
            char[] chararr = str.ToCharArray();

            ///////find out number of countries////


            var cnt = str.Split(',');
            Console.WriteLine(cnt.Length);


            ///////////////////remove country ending character with D//////////

           var del = str.Split(',');
           string[] str12 = new string[10];
           String mod = "";
           int chkcnt = 0;
           String s1 = "";
           
           for (int i = 0; i < del.Length; i++)
           {
               bool chk = del[i].EndsWith("d");
               if (chk != true)
               {

                   s1 = s1 + del[i] + ",";
               }
           }


           int com = s1.LastIndexOf(",");
           string sss=s1.Remove(com);
           //Console.WriteLine(sss);

            //////////////Add New Country////////////////////
           string[] str11 = str.Split(',', ' ');
           string newstr11 = "";
           for (int i = 0; i < str11.Length; i++)
           {
               bool chk = str11[i].StartsWith("In");
               if (chk==true)
               {
                   int index1 = (int)str11[i].LongCount();
                   newstr11 = newstr11 + str11[i].Insert(index1, ",SriLanka");
                   
               }
               else if(chk!=true)
               {
                   newstr11 = newstr11 +","+str11[i]+",";
               }
           }
            Console.WriteLine(newstr11);

            //////////swap///////////////

            string str6 = "code for c# development";
            string temp = "";
            string stringop = "";
            string sample = "";
            string[] str111 = str6.Split(' ');

            temp=str111[0];

            stringop = str111[str111.Length-1];

            for (int i = 1; i < str11.Length; i++)
            {
                sample = sample + str111[i] + " ";
            }

            sample=stringop+" "+sample+" "+temp;

            Console.WriteLine(sample);
            

            /////// Reverse String//////////

            string output = string.Join(" ",str6.Split(' ').Select(x=>new string(x.Reverse().ToArray())));
            Console.WriteLine(output);



            //////insert///////
            string str2 = "code for c# development";
            var index = str2.LastIndexOf("#")+1;
            Console.WriteLine("\nOld String : " + str2);
            Console.WriteLine("\nNew String : "+str2.Insert(index," java"));
            Console.WriteLine("\nput new word : " + str2.Replace("#", "Sharp"));
            Console.WriteLine();
            var cntspace =  str2.Split(' ');
            Console.WriteLine(cntspace.Length);

            /////////////////ascending Order////////////

             string str9 = "IN12DIA34AMIT";
            List<char> li = str9.ToList();

            li.Sort();
            foreach (var item in li)
            {
                Console.Write(item);
            }

            Console.WriteLine("\n");


            ///////////////ascending order without function/////////


            byte[] bytearr11 = Encoding.ASCII.GetBytes(str9);
            var temp1 = 0;

            for (int i = 0; i < bytearr11.Length; i++)
            {
                for (int j = i+1; j < bytearr11.Length; j++)
                {
                    if (bytearr11[i]>bytearr11[j])
                    {
                        temp1 = bytearr11[i];
                        bytearr11[i] = bytearr11[j];
                        bytearr11[j] = (byte)temp1;
                    }
                }
               
            }

            string result = System.Text.Encoding.UTF8.GetString(bytearr11);
            Console.WriteLine("Sorted string are: " + result);

            //////////////remove integer number////////
            Console.WriteLine("\n\n\n");
            string str4 = "IN12DIA";
            Console.WriteLine(str4);
            string[] str5 = str4.Split('0','1', '2', '3', '4', '5', '6', '7', '8', '9');
            foreach (var item in str5)
            {
                Console.Write(item);
            }
            
            ///////////////////// file path///////////////
            Console.WriteLine();
            string pathName = @"G:\study\abc.js";

            Console.WriteLine("full path of file: "+pathName);
           String filename = Path.GetFileNameWithoutExtension(pathName);
          String dname = Path.GetDirectoryName(pathName);


            ////////calculate age of////////

          string str7 = "31/10/1990";
            DateTime dt=Convert.ToDateTime(str7);
            int dob=dt.Year;
          int tod = DateTime.Now.Year;
          int age = tod - dob;
          Console.WriteLine("Age is : "+age);


          int ageindays = age * 365;
          Console.WriteLine("age in days:"+ageindays);

            ////////calculate age as year/month/day///////////

            Console.ReadLine();
        }
    }
}

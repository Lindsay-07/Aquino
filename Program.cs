using System;
using System.Security.Cryptography.X509Certificates;
using cmd;
using DSact;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace act
{
    internal class programming
    {
        static void Main(string[] args)
        {

            Data data = new Data();

            List<data> Info = data.datainfo();

            //linq /filter/count
            List<data> Datainfo = Info.Where(x => x.Age == 1).ToList();

            Console.WriteLine($"Age is {Datainfo.Count}");

            foreach (var info in Info)
            {
                Console.WriteLine($"Name :{info.Name}\n Age: {info.Age}\n BirthPlace: {info.BirthPlace}");
            }

            //order by
            List<data> Order = Info.OrderBy(x => x.Age).ToList();

            foreach (var info in Datainfo)
            {
                Console.WriteLine($"Name: {info.Name}\n Age: {info.Age}\n BirthPlace: {info.BirthPlace}");
            }

            //group
            var grouped = Info.GroupBy(x => x.Age);

            foreach (var info in grouped)
            {
                Console.WriteLine($"Age: {info.Key}");
            }

            //Default

            List<data> Age = Info.OrderBy(x => x.Age).ToList();

            var youngest = Age.OrderBy(x => x.Age).ToList().FirstOrDefault();

            Console.WriteLine($"Youngest is {youngest.Age}"); 

        
      













            //data Data1 = new data();
            //Data1.Name = "Lindsay";
            //Data1.BirthYear = 2004;
            //Data1.Age = 20;
            //Data1.BirthPlace = "Binan City";

            //data Data2 = new data();
            //Data2.Name = "Mari";
            //Data2.BirthYear = 2004;
            //Data2.Age = 20;
            //Data2.BirthPlace = "Binan City";

            //data Data3 = new data();
            //Data3.Name = "Ethan";
            //Data3.BirthYear = 2004;
            //Data3.Age = 20;
            //Data3.BirthPlace = "Bulacan";

            //List<data> list = new List<data>();
            //list.Add(Data1);
            //list.Add(Data2);
            //list.Add(Data3);

            //foreach (data data in list)
            //{
            //    Console.WriteLine($"Name :{data.Name}\n Birthyear : {data.BirthYear}\n Age: {data.Age}\n Birthplace : {data.BirthPlace}");
            //}
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using static Lab6.Users;
namespace Lab6
{
    class Program
    {
      

        static void Main(string[] args)
        {
            //ZAPYTANIE 1
            Console.WriteLine("ZAPYTANIE 1\n"); 
            var myusers1 = Users.Get().Count();
            Console.WriteLine("Liczba użytkowników : "+myusers1+"\n");
            Console.WriteLine("-----------------------------------\n");

            

            //ZAPYTANIE 2
            Console.WriteLine("ZAPYTANIE 2\n");
            var myusers2 = Users.Get();
            var query2 =
                from myuser in myusers2
                select myuser.Name;

        
            foreach (var names in query2)
            {
                Console.WriteLine("User: "+ names);
            }
            
            Console.WriteLine("-----------------------------------\n");


            //ZAPYTANIE 3 
            Console.WriteLine("ZAPYTANIE 3\n");
            var myusers3 = Users.Get().GroupBy(names=>names.Name).OrderBy(names=>names.Key);
           

            foreach (var sortNames in myusers3)
            {
                Console.WriteLine("User: " + sortNames.Key);
            }

            Console.WriteLine("-----------------------------------\n");


            //ZAPYTANIE 4
            Console.WriteLine("ZAPYTANIE 4\n");
            var myusers4 = Users.Get();
            var queryfour =
                from myuser in myusers4

                select myuser.Role;
            List<string> Roles = new();
            foreach (var element in queryfour) Roles.Add(element);
            var whithoutDuplicateRoles = Roles.Distinct().ToList();
            foreach(var role in whithoutDuplicateRoles)
            {
                Console.WriteLine("Available roles: " + role);
            }
            Console.WriteLine("-----------------------------------\n");




            //ZAPYTANIE 5
            Console.WriteLine("ZAPYTANIE 5\n");
            var myusers5 = Users.Get().OrderBy(role=>role.Role);
            foreach (var GroupRoles in myusers5)
            {
                Console.WriteLine("User: " + GroupRoles.Name+" Role: "+GroupRoles.Role);
            }
           
            Console.WriteLine("-----------------------------------\n");




            //ZAPYTANIE 6
            Console.WriteLine("ZAPYTANIE 6\n");
            var myusers6 = Users.Get().Where(mymarks => mymarks.Marks != null);
            var querysix =
                from myuser in myusers6
                let records = myuser.Marks.Count()
                where records > 0
                select records;

            Console.WriteLine("Amount of records: "+querysix.Count());

            foreach(var item in myusers6)
            {
                Console.Write(item.Name + ", " + item.Role + ", "); 
                foreach(var marks in item.Marks)
                {
                    Console.Write("["+marks.ToString()+"]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------\n");




            //ZAPYTANIE 7

            Console.WriteLine("ZAPYTANIE 7\n");
            var myusers7 = Users.Get().Where(mymarks => mymarks.Marks != null );
            var queryseven1 =
                from myuser in myusers7
                let AVG = myuser.Marks.Average()
                select AVG;
            var queryseven2 =
               from myuser in myusers7
               let count = myuser.Marks.Count()
               select count;
            var queryseven3 =
               from myuser in myusers7
               let sum = myuser.Marks.Sum()
               select sum;

            Console.Write("Avg: " + queryseven1.Average());
            Console.WriteLine("Count: " + queryseven2.Sum());
            Console.WriteLine("Sum: " + queryseven3.Sum());


            Console.WriteLine("-----------------------------------\n");


            //ZAPYTANIE 8

            Console.WriteLine("ZAPYTANIE 8\n");
            var myusers8 = Users.Get().Where(mymarks => mymarks.Marks != null);
            var queryeight =
               from myuser in myusers8
               select myuser.Marks.Max();
            Console.WriteLine("The highest mark: " + queryeight.Max());

            Console.WriteLine("-----------------------------------\n");



            //ZAPYTANIE 9

            Console.WriteLine("ZAPYTANIE 9\n");
            var myusers9 = Users.Get().Where(mymarks => mymarks.Marks != null);
            var querynine =
              from myuser in myusers9
              select myuser.Marks.Min();
            Console.WriteLine("The lowest mark: " +querynine.Min());

            Console.WriteLine("-----------------------------------\n");

           
            
            //ZAPYTANIE 10 

            Console.WriteLine("ZAPYTANIE 10\n");
            var myusers10 = Users.Get().Where(mymarks => mymarks.Marks != null);
            var queryten =
                from myuser in myusers10
                 select myuser.Marks.Average();
            var queryten1 =
                from myuser in myusers10
                where myuser.Marks.Average() == queryten.Max()
                select myuser.Name +" Age: "+ myuser.Age+" ";

            foreach (var beststudent in queryten1)
            {
                Console.WriteLine("User: " + beststudent + "Average: " + queryten.Max());
            }
             



            Console.WriteLine("-----------------------------------\n");

            //ZAPYTANIE 11 

            Console.WriteLine("ZAPYTANIE 11\n");
     
            var myusers11 = Users.Get().Where(mymarks => mymarks.Marks != null);
            var queryeleven =
                from myuser in myusers11
                select myuser.Marks.Count()
                ;
            var queryeleven1 =
                from myuser in myusers11
                where myuser.Marks.Count() == queryeleven.Min()
                select "User: " + myuser.Name + " Amount of marks: " + myuser.Marks.Count();
            var queryeleven2 =
                from myuser in myusers11
                where myuser.Marks.Count() == queryeleven.Max()
                select "User: " + myuser.Name + " Amount of marks: " + myuser.Marks.Count();

            foreach (var countMark in queryeleven1)
            {
                Console.WriteLine(countMark.ToString());

            }
            Console.WriteLine("-----------------------------------\n");

            //ZAPYTANIE 12 

            Console.WriteLine("ZAPYTANIE 12\n");
            foreach (var countMark in queryeleven2)
            {
                Console.WriteLine(countMark.ToString());

            }


            Console.WriteLine("-----------------------------------\n");

            //ZAPYTANIE 13

            Console.WriteLine("ZAPYTANIE 13\n");

            var ObjAVG = Users.Get().Where(a => a.Marks != null).Select(a => new { Type = a.Name, avg = a.Marks.Average() }).ToList();

            foreach (var b in ObjAVG) Console.WriteLine(b);







            Console.WriteLine("-----------------------------------\n");


            //ZAPYTANIE 14

            Console.WriteLine("ZAPYTANIE 14\n");
            var myusers14 = Users.Get().Where(mymarks => mymarks.Marks != null);
            var queryfourteen =
                from myuser in myusers14
                select myuser.Marks.Average();
            var queryfourteen1 =
                from myuser in myusers14
                orderby queryfourteen
                select "User: " + myuser.Name + " Age: " + myuser.Age + " Average: " + myuser.Marks.Average();


            foreach (var sortedstudent in queryfourteen1) Console.WriteLine(sortedstudent.ToString());




            Console.WriteLine("-----------------------------------\n");


            //ZAPYTANIE 15

            Console.WriteLine("ZAPYTANIE 15\n");
            var myusers15 = Users.Get().Where(mymarks => mymarks.Marks != null);
           



                var queryfifteen =
               from myuser in myusers7
               let sum = myuser.Marks.Sum()
               select sum;

            var queryfifteen1 =
               from myuser in myusers7
               let count = myuser.Marks.Count()
               select count;

            double myavg = queryfifteen.Sum() / queryfifteen1.Sum();
            Console.WriteLine("Średnia ocena: "+myavg);


            Console.WriteLine("-----------------------------------\n");


            //ZAPYTANIE 16

            Console.WriteLine("ZAPYTANIE 16\n");
            var myusers16 = Users.Get().Where(createdDate => createdDate.CreatedAt >=new DateTime(2020,01,20) && createdDate.CreatedAt<= new DateTime(2020, 07, 20));
            foreach (var users in myusers16) Console.WriteLine("User: " + users.Name + " Age: " + users.Age + " Created Date: " + users.CreatedAt);

            Console.WriteLine("-----------------------------------\n");



            //ZAPYTANIE 17

            Console.WriteLine("ZAPYTANIE 17\n");
            var myusers17 = Users.Get().Where(deleteDate =>deleteDate.RemovedAt == null);

            foreach (var user in myusers17) { Console.WriteLine("User: " + user.Name + " Age: " + user.Age + " Role: " + user.Role); }




            Console.WriteLine("-----------------------------------\n");





            //ZAPYTANIE 18

            Console.WriteLine("ZAPYTANIE 18\n");
            var myusers18 = Users.Get().Where(mymarks => mymarks.Marks != null);
            var queryeighteen =
                from myuser in myusers18
                let datecreated = myuser.CreatedAt - DateTime.Today
                select datecreated;
            var queryeighteen1 =
                from myuser in myusers18
                let checkmin = myuser.CreatedAt - DateTime.Today
                where checkmin == queryeighteen.Max()
                select "User: "+myuser.Name+" Age: "+myuser.Age+" Created Date: "+myuser.CreatedAt;
            foreach(var mindate in queryeighteen1)
            {
                Console.WriteLine(mindate.ToString());
            }


            Console.WriteLine("-----------------------------------\n");





            //SERIALIZACJA JSON
            Console.WriteLine("SERIALIZACJIA JOSN");
            string json = JsonSerializer.Serialize(myusers18.Last());
            Console.WriteLine(json);

            Console.WriteLine("DEERIALIZACJIA JOSN");
           // string jsond = "{\"Name\":\"Jan Kowalski\",Role\":\"Student\",\"Age\":30\",\"Marks\":\"[2,2,2,2,2]\",\"CreatedAt\":2022-02-09T00:00:00\",\"RemoveAt\":\"null\"}";  
          
            User Myuser = JsonSerializer.Deserialize<User>(json);

           
            Console.WriteLine("Name: " + Myuser.Name);  
            Console.WriteLine("Role: " + Myuser.Role);    
            Console.WriteLine("Age: " + Myuser.Age);    
            Console.WriteLine("Marks: " + Myuser.Marks);    
            Console.WriteLine("CreatedAT: " + Myuser.CreatedAt);    
            Console.WriteLine("RemoveAt: " + Myuser.RemovedAt);

            //SERIALIZE BINARY
            var serbin = new BinaryFormatter();

            using var serbinstream = new MemoryStream();
            serbin.Serialize(serbinstream, myusers18.Last());
            serbinstream.Flush();
            serbinstream.Position = 0;

            var mybinuser = serbinstream.ToArray();


            //deserialize binary

            using var MybinList = new MemoryStream();
            serbin.Serialize(serbinstream, myusers18.Last());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
   internal class Users
    {
        public static IEnumerable<User> Get()
        {

      
         List<User> myusers = new ();
            myusers.Add(new User() { Name = "student1", Role = "Student", Age = 21, Marks = new int[] { 1, 2, 3, 6 }, CreatedAt = new DateTime(2020, 07, 12), RemovedAt = null });
            myusers.Add(new User() { Name = "student2", Role = "Student", Age = 21, Marks = new int[] { 1, 2, 1, 66 }, CreatedAt = new DateTime(2020, 06, 20), RemovedAt = null });
            myusers.Add(new User() { Name = "student3", Role = "Student", Age = 19, Marks = new int[] { 1, 2, 3, 6 }, CreatedAt = new DateTime(2022, 05, 23), RemovedAt = null });
            myusers.Add(new User() { Name = "student4", Role = "Student", Age = 22, Marks = new int[] { 1, 2, 3, 6 }, CreatedAt = new DateTime(2020, 04, 23), RemovedAt = null });
            myusers.Add(new User() { Name = "student5", Role = "Student", Age = 24, Marks = new int[] { 1, 2, 3, 6 }, CreatedAt = new DateTime(2020, 03, 21), RemovedAt = new DateTime(2022, 05, 01) });
            myusers.Add(new User() { Name = "student6", Role = "Student", Age = 22, Marks = new int[] { 1, 2, 3, 6 }, CreatedAt = new DateTime(2020, 11, 12), RemovedAt = new DateTime(2022, 04, 16) });
            myusers.Add(new User() { Name = "astudent7", Role = "Student", Age = 20, Marks = new int[] { 1, 2, 3, 6 }, CreatedAt = new DateTime(2020, 12, 19), RemovedAt = new DateTime(2022, 03, 10) });
            myusers.Add(new User() { Name = "student8", Role = "Student", Age = 15, Marks = new int[] { 1, 2, 3, 6 }, CreatedAt = new DateTime(2020, 10, 29), RemovedAt = null });
            myusers.Add(new User() { Name = "student9", Role = "Student", Age = 18, Marks = new int[] { 1, 2, 3, 6 }, CreatedAt = new DateTime(2020, 01, 10), RemovedAt = null });
            myusers.Add(new User() { Name = "student10",Role = "Student", Age = 21, Marks = new int[] { 1, 2, 3,6 ,7 }, CreatedAt = new DateTime(2014, 01, 09), RemovedAt = null });
            myusers.Add(new User() { Name = "Teacher1", Role = "Teacher", Age = 44, Marks = null, CreatedAt = new DateTime(2021, 07, 18), RemovedAt = null });
            myusers.Add(new User() { Name = "Teacher2", Role = "Moderator", Age = 55, Marks = null, CreatedAt = new DateTime(2020, 06, 06), RemovedAt = null });
            myusers.Add(new User() { Name = "Teacher3", Role = "Admin", Age = 64, Marks = null, CreatedAt = new DateTime(2009, 09, 02), RemovedAt = null });
            myusers.Add(new User() { Name = "Teacher4", Role = "Admin", Age = 53, Marks = null, CreatedAt = new DateTime(2010, 12, 11), RemovedAt =null });
            myusers.Add(new User() { Name = "Teacher5", Role = "Moderator", Age = 43, Marks = null, CreatedAt = new DateTime(2020, 02, 20), RemovedAt = null });
            myusers.Add(new User() { Name = "Teacher6", Role = "Teacher", Age = 38, Marks = null, CreatedAt = new DateTime(2020, 02, 16), RemovedAt = null });
            myusers.Add(new User() { Name = "Teacher7", Role = "Teacher", Age = 26, Marks = null, CreatedAt = new DateTime(2020, 05, 05), RemovedAt = null });
            myusers.Add(new User() { Name = "Teacher8", Role = "Teacher", Age = 75, Marks = null, CreatedAt = new DateTime(2020, 01, 10), RemovedAt = null });
            myusers.Add(new User() { Name = "Teacher9", Role = "Teacher", Age = 66, Marks = null, CreatedAt =new DateTime(2019,02,10), RemovedAt = new DateTime(2022, 06, 01) });
            myusers.Add(new User() { Name = "Teacher10", Role = "Teacher", Age = 52, Marks = null, CreatedAt = new DateTime(2018, 02, 10), RemovedAt = null });

            return myusers;

        }
        
    }
}

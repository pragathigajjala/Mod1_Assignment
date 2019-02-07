/* This Program displays details of Student,Teacher,Program,Degree and Course. */

using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Mod1_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable declaration
        string stu_firstName,stu_lastName,stu_addLine1,stu_addLine2,stu_city,stu_state,stu_country;
        string teacher_firstName, teacher_lastName, teacher_addLine1, teacher_addLine2, teacher_city, teacher_state, teacher_country;
        string programName, Dept_Head, Degrees, Degree_Name, Course_Name, Course_Teacher;
        DateTime stu_birthdate, teacher_birthdate;
        int stu_zipcode, teacher_zipcode, Degree_cred_reqd, course_credits, course_dura_weeks;

            // assigning values to student variables
            stu_firstName = "David";
            stu_lastName = "Graham";
            stu_addLine1 = "221st LN NE";
            stu_addLine2 = "unit 100";
            stu_city = "Redmond";
            stu_state = "WA";
            stu_country = "USA";

            //assigning values to teacher variables

            teacher_firstName = "Steve";
            teacher_lastName = "Graham";
            teacher_addLine1 = "10619";
            teacher_addLine2 = "east dr";
            teacher_city = "Sammamish";
            teacher_state = "WA";
            teacher_country = "USA";

            //assigning Uprogram values

            programName = "Information systems";
            Dept_Head = "Mr.Noel";
            Degrees = "Bachelor";

            //assigning degree variables

            Degree_Name = "MIS";
            Degree_cred_reqd = 50;

            //assigning course variables

            Course_Name = "Artificial Intelligence";
            course_credits = 5;
            course_dura_weeks = 5;
            Course_Teacher = "Mr.Kell";

            // Displaying students details
            Console.WriteLine("Student Details:");
            Console.WriteLine("Student Name:"+stu_firstName+" "+stu_lastName);
            Console.WriteLine("Student address:" +stu_addLine1 +"\n"+ "                "+stu_addLine2 +"\n" + "                "+stu_city +"\n" + "                "+stu_state +"\n" + "                "+stu_country +"\n");

            //Displaying teacher details
            Console.WriteLine("Teacher Details:");
            Console.WriteLine("Teacher Name is:" + teacher_firstName + " " + teacher_lastName);
            Console.WriteLine("Teacher address:" +teacher_addLine1 + "\n"+"                " + teacher_addLine2 + "                "+ "\n" + "                "+ teacher_city + "                "+
                "\n" + "                "+ teacher_state + "\n" + "                "+ teacher_country +"\n");

            //displaying program details
            Console.WriteLine("Program Details:");
            Console.WriteLine("Program Name:" + programName);
            Console.WriteLine("Department Head:" + Dept_Head);
            Console.WriteLine("Degrees:" + Degrees+"\n");

            //displaying degree information
            Console.WriteLine("Degree Information:");
            Console.WriteLine("Degree Name:" + Degree_Name);
            Console.WriteLine("Credits Required:" + Degree_cred_reqd + "\n");

            //displaying course details
            Console.WriteLine("Course Details:");
            Console.WriteLine("Course Name:" + Course_Name);
            Console.WriteLine("Course Credits:" +course_credits);
            Console.WriteLine("Duration of course:" + course_dura_weeks);
            Console.WriteLine("Course Teacher:" + Course_Teacher);



        }
    }
}

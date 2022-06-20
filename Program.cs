using System.Text.RegularExpressions;
using System;

/***
    Author: KhangNDCE160286
***/
namespace C_Lab
{
    class Program {
        static void Main(string[] args) {
            ManageStudent manageStudent = new ManageStudent();
            ManageTeacher manageTeacher = new ManageTeacher();
            ManageSubject manageSubject = new ManageSubject();
            ManageMarks manageMarks = new ManageMarks();
            while(true) {
                bool stop = false;
                System.Console.WriteLine("------- MAIN MENU -------");
                System.Console.WriteLine("|   1. Manage Student   |");
                System.Console.WriteLine("|   2. Manage Teacher   |");
                System.Console.WriteLine("|   3. Manage Subject   |");
                System.Console.WriteLine("|   4. Manage Marks     |");
                System.Console.WriteLine("|   5. Exit             |");
                System.Console.WriteLine("------- MAIN MENU -------");
                while(true) {
                    System.Console.Write("Please choose one (1-5): ");
                    string choice = Console.ReadLine();
                    if (!Regex.IsMatch(choice, @"^[1-5]{1}$")) {
                        System.Console.WriteLine("Please choose a valid option!");
                    } else {
                        if (choice.Equals("1")) 
                            manageStudent.Menu();
                        else if (choice.Equals("2"))
                            manageTeacher.Menu();
                        else if (choice.Equals("3"))
                            manageSubject.Menu();
                        else if (choice.Equals("4"))
                            manageMarks.Menu();
                        else
                            stop = true;
                        break;
                    }  
                }
                if (stop) break;  
            }
            System.Console.WriteLine("GOOD BYE !!!!!!!!");
        }
    }
}

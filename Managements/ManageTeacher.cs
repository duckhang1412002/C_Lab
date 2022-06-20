using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using C_Lab.Models;

/***
    Author: KhangNDCE160286
***/
namespace C_Lab
{
    class ManageTeacher {
        public static List<Teacher> teachers = new List<Teacher>();
        private void InputTeacher() {
            Teacher teacher = new Teacher();
            teacher.inputTeacher();
            teachers.Add(teacher);
        }

        private void DisplayWorkYear() {
            System.Console.WriteLine("\n---- Teacher List ----");
            int cnt = 0;
            foreach (var teacher in teachers) {
                System.Console.Write($"{++cnt}. ");
                System.Console.WriteLine($"Full name: {teacher.FullName} - Worked Years: {teacher.getWorkedYears()}");
            }  
            System.Console.WriteLine("----------------------\n");
        }

        private void DisplayTeacher() {
            System.Console.WriteLine("\n---- Teacher List ----");
            int cnt = 0;
            foreach (var teacher in teachers) {
                System.Console.Write($"{++cnt}. ");
                teacher.printInfo();
            } 
            System.Console.WriteLine("----------------------\n");
        }

        public void Menu() {
            Console.Clear();
            while(true) {
                bool stop = false;
                System.Console.WriteLine("----- Manage Teacher -----");
                System.Console.WriteLine("1. Input Teacher");
                System.Console.WriteLine("2. Display Work year");
                System.Console.WriteLine("3. Display Information");
                System.Console.WriteLine("4. Back");
                while(true) {
                    System.Console.Write("Please choose one (1-4): ");
                    string choice = Console.ReadLine();
                    if (!Regex.IsMatch(choice, @"^[1-4]{1}$")) {
                        System.Console.WriteLine("Please choose a valid option!");
                    } else {
                        if (choice.Equals("1")) 
                            InputTeacher();
                        else if (choice.Equals("2")) 
                            DisplayWorkYear();
                        else if (choice.Equals("3"))
                            DisplayTeacher();
                        else 
                            stop = true;
                        break;
                    }  
                }
                if (stop) break;  
            }        
        }
    }
}

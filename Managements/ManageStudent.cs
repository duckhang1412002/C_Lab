using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using C_Lab.Models;

/***
    Author: KhangNDCE160286
***/
namespace C_Lab
{
    class ManageStudent {
        public static List<Student> students = new List<Student>();
        private void InputStudent() {
            Student student = new Student();
            student.inputStudent();
            students.Add(student);
        }

        private void CalculateAvg() {
            //System.Console.WriteLine("CalculateAvg");      
            System.Console.WriteLine("\n---- Student List ----");
            int cnt = 0;
            foreach (var student in students) {
                System.Console.Write($"{++cnt}. ");
                System.Console.WriteLine($"Full name: {student.FullName} - Average Mark: {student.getAvgMark()}");
            }  
            System.Console.WriteLine("----------------------\n");
        }

        private void DisplayStudent() {
            //System.Console.WriteLine("Display Student");
            System.Console.WriteLine("\n---- Student List ----");
            int cnt = 0;
            foreach (var student in students) {
                System.Console.Write($"{++cnt}. ");
                student.printInfo();
            } 
            System.Console.WriteLine("----------------------\n");
        }

        public void Menu() {
            Console.Clear();
            while(true) {
                bool stop = false;
                System.Console.WriteLine("----- Manage Student -----");
                System.Console.WriteLine("1. Input Student");
                System.Console.WriteLine("2. Calculate the average marks");
                System.Console.WriteLine("3. Display student info");
                System.Console.WriteLine("4. Back");
                while(true) {
                    System.Console.Write("Please choose one (1-4): ");
                    string choice = Console.ReadLine();
                    if (!Regex.IsMatch(choice, @"^[1-4]{1}$")) {
                        System.Console.WriteLine("Please choose a valid option!");
                    } else {
                        if (choice.Equals("1")) 
                            InputStudent();
                        else if (choice.Equals("2"))
                            CalculateAvg();
                        else if (choice.Equals("3"))
                            DisplayStudent();
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

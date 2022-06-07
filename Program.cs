using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using C_Lab.Models;

/***
    Author: KhangNDCE160286
***/
namespace C_Lab {
    // 
    // static List<Teacher> teachers = new List<Teacher>();
    // static List<Subject> subjects = new List<Subject>();
    // static List<Marks> marks = new List<Marks>();
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

    class ManageTeacher {
        public void Menu() {
            while(true) {
                bool stop = false;
                System.Console.WriteLine("----- Manage Teacher -----");
                System.Console.WriteLine("1. Input Teacher");
                System.Console.WriteLine("2. Manage Teacher");
                System.Console.WriteLine("3. Manage Subject");
                System.Console.WriteLine("4. Manage Marks");
                System.Console.WriteLine("5. Exit");
                while(true) {
                    System.Console.Write("Please choose one (1-5): ");
                    string choice = Console.ReadLine();
                    if (!Regex.IsMatch(choice, @"^[1-5]{1}$")) {
                        System.Console.WriteLine("Please choose a valid option!");
                    } else {
                        if (choice.Equals("1")) 
                            System.Console.WriteLine("HI");
                        else 
                            stop = true;
                        break;
                    }  
                }
                if (stop) break;  
            }        
        }
    }

    class Program {
        
        static void Main(string[] args) {
            ManageStudent manageStudent = new ManageStudent();
            ManageTeacher manageTeacher = new ManageTeacher();
            while(true) {
                bool stop = false;
                System.Console.WriteLine("------- MAIN MENU -------");
                System.Console.WriteLine("| 1. Manage Student     |");
                System.Console.WriteLine("| 2. Manage Teacher     |");
                System.Console.WriteLine("| 3. Manage Subject     |");
                System.Console.WriteLine("| 4. Manage Marks       |");
                System.Console.WriteLine("| 5. Exit               |");
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

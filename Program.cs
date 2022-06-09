﻿using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using C_Lab.Models;

/***
    Author: KhangNDCE160286
***/
namespace C_Lab {
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

    class ManageSubject {
        public static List<Subject> subjects = new List<Subject>();
        private void InputSubject() {
            Subject subject = new Subject();
            subject.inputSubject();
            subjects.Add(subject);
        }

        private void DisplayTotalLessons() {
            System.Console.WriteLine("\n---- Subject List ----");
            int cnt = 0;
            foreach (var subject in subjects) {
                System.Console.Write($"{++cnt}. ");
                System.Console.WriteLine($"Subject name: {subject.SubjectName} - Total Lessons: {subject.getTotalLessons()}");
            }  
            System.Console.WriteLine("----------------------\n");
        }

        private void DisplaySubject() {
            System.Console.WriteLine("\n---- Subject List ----");
            int cnt = 0;
            foreach (var subject in subjects) {
                System.Console.Write($"{++cnt}. ");
                subject.printInfo();
            } 
            System.Console.WriteLine("----------------------\n");
        }

        public void Menu() {
            Console.Clear();
            while(true) {
                bool stop = false;
                System.Console.WriteLine("----- Manage Subject -----");
                System.Console.WriteLine("1. Input Subject");
                System.Console.WriteLine("2. Display Subject Total lessons");
                System.Console.WriteLine("3. Display Information");
                System.Console.WriteLine("4. Back");
                while(true) {
                    System.Console.Write("Please choose one (1-4): ");
                    string choice = Console.ReadLine();
                    if (!Regex.IsMatch(choice, @"^[1-4]{1}$")) {
                        System.Console.WriteLine("Please choose a valid option!");
                    } else {
                        if (choice.Equals("1")) 
                            InputSubject();
                        else if (choice.Equals("2")) 
                            DisplayTotalLessons();
                        else if (choice.Equals("3"))
                            DisplaySubject();
                        else 
                            stop = true;
                        break;
                    }  
                }
                if (stop) break;  
            }        
        }
    }

    class ManageMarks {
        public static List<Marks_Subject> marks = new List<Marks_Subject>();
        private void InputMarks() {
            Marks_Subject mark = new Marks_Subject();
            mark.inputMarks_Subject();
            marks.Add(mark);
        }

        private void DisplayMarks() {
            System.Console.WriteLine("\n---- Marks List ----");
            int cnt = 0;
            foreach (var mark in marks) {
                System.Console.Write($"{++cnt}. ");
                mark.printMarks();
            } 
            System.Console.WriteLine("----------------------\n");
        }

        private void DisplayPassStatus() {
            System.Console.WriteLine("\n---- Marks List ----");
            int cnt = 0;
            foreach (var mark in marks) {
                System.Console.Write($"{++cnt}. ");
                mark.printStatus();
            } 
            System.Console.WriteLine("----------------------\n");
        }

        public void Menu() {
            Console.Clear();
            while(true) {
                bool stop = false;
                System.Console.WriteLine("----- Manage Marks -----");
                System.Console.WriteLine("1. Input Marks");
                System.Console.WriteLine("2. Display Student Status");
                System.Console.WriteLine("3. Display Student Marks");
                System.Console.WriteLine("4. Back");
                while(true) {
                    System.Console.Write("Please choose one (1-4): ");
                    string choice = Console.ReadLine();
                    if (!Regex.IsMatch(choice, @"^[1-4]{1}$")) {
                        System.Console.WriteLine("Please choose a valid option!");
                    } else {
                        if (choice.Equals("1")) 
                            InputMarks();
                        else if (choice.Equals("2")) 
                            DisplayPassStatus();
                        else if (choice.Equals("3"))
                            DisplayMarks();
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

using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using C_Lab.Models;

/***
    Author: KhangNDCE160286
***/
namespace C_Lab
{
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
}

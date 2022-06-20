using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using C_Lab.Models;

/***
    Author: KhangNDCE160286
***/
namespace C_Lab
{
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
}

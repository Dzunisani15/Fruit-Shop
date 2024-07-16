using System.Diagnostics;
using System.IO;
using System;
using System.Net.Mail;
using System.Runtime.ExceptionServices;

namespace csharp {

    public class Program {

        //string first;
        public bool fruitIsThere;
        public static List<string> questions() {

            Console.WriteLine("How can I help you today");
            string first = Console.ReadLine();
            fruits(first);

            List<string> listOfFruitAsked = new List<string>();

            listOfFruitAsked.Append(first);


            return listOfFruitAsked;
        }


        public static bool fruits(string checking) {

            List<string> listOfFood = new List<string>();

            listOfFood = ["Apple","Orange","Banana","Grape", "Mango",
                         "Pineapple","Strawberry","Watermelon", "Kiwi", 
                         "Peach","Pear", "Plum","Cherry", "Blueberry", 
                         "Raspberry","Lemon","Grape","Avocado","Papaya"];


            for (int i = 0; true; i++ ) {

                if (checking == listOfFood[i]){
                    bool fruitIsThere = true;
                    break;
                }
            }

            
            return true;
        }

        public static void Main(string[] args){


        }
    
    }
}
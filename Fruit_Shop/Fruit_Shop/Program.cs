using System.Runtime.InteropServices.ComTypes;
using System.Text.Json;
using System.Text.RegularExpressions;
using System;
using System.IO;
//using Newtonsoft.Json;

namespace Fruit_Shop{

    public class Ptogram
    {
        public static string stringOfUsersFruits;
        //public static List<string> usersListOfFruits = new List<string>();

        public static void user_input() {

            Console.WriteLine("Welcome to [Your Fruit Shop's Name], where freshness meets flavor!" +
                              "We take pride in offering a vibrant selection of the finest fruits" +
                              "sourced locally and globally. Whether you're craving juicy tropical" +
                              "mangoes, crisp apples, or exotic dragon fruit, we have something to" +
                              "satisfy every palate.");


            Console.WriteLine("Please provide a list of fruits you're looking for ");
            stringOfUsersFruits = Console.ReadLine();

            input_filter();
        }

        public static void input_filter() {

            //string patterns = @"[^a-zA-Z0-9]";
            //string filteredString = Regex.Replace(stringOfUsersFruits, patterns, "");

            string[] usersListOfFruits = stringOfUsersFruits.Split();
            
            for (int i = 0; i < usersListOfFruits.Count(); i++){
                Console.WriteLine(usersListOfFruits[i]);
            }
        }

        public static void fruit_stock() {


            string jsonData = File.ReadAllText("C:\\Users\\Train\\source\\repos\\Fruit_Shop\\fruit_stock.json");

            MyDataObject dataObject = JsonSerializer.Deserialize<MyDataObject>(jsonData);
            //MyDataObject dataObject = JsonConvert.DeserializeObject<MyDataObject>(jsonData);

            //List<string> listOfFruits = new List<string>();

            //listOfFruits = ["Apple","Orange","Banana","Grape", "Mango",
            //             "Pineapple","Strawberry","Watermelon", "Kiwi",
            //             "Peach","Pear", "Plum","Cherry", "Blueberry",
            //             "Raspberry","Lemon","Avocado","Papaya"];

            //Dictionary <string, int> fruitAndStock = new Dictionary<string, int>();

            //fruitAndStock["Apple"] =1;


            Console.WriteLine($"{dataObject.fruit} \n {dataObject.numberOfFruit}");



        }

        public class MyDataObject
        {
            public string fruit { get; set; }
            public string numberOfFruit { get; set; }
        }


        static void Main(string[] args) {

            //user_input();
            fruit_stock();
         

        }
    }
}
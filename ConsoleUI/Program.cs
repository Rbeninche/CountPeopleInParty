using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static List<Person> people = new List<Person>();
        static void Main(string[] args)
        {
           

            Person person1 = new Person("Reginald", "Hi");
            AddPeopleInList(person1);

            Person person2 = new Person("Chauncey", "Thanks for inviting me");
            AddPeopleInList(person2);

            Person person3 = new Person("Roger", "What's up");

            AddPeopleInList(person3);

            int numberOfPeopleInParty = CountPeople(people);
            Console.WriteLine($"Number of people in party: {numberOfPeopleInParty}");
            Console.WriteLine();
            SayThankYou(people);
            Console.WriteLine();
            EachPersonMessage(people);

            Console.ReadLine();

            
        }


        public static void AddPeopleInList(Person person)
        {
            people.Add(person);
        }

        public static int CountPeople(List<Person> guests)
        {
            return guests.Count;
        }

        public static void SayThankYou (List<Person> peopleInMyParty)
        {
            foreach (Person person in peopleInMyParty)
            {
                if(person.Name == "Chauncey")
                {
                    Console.WriteLine($"It is good to have you here {person.Name}");
                }
                else
                {
                    Console.WriteLine($"Thank you for coming {person.Name}");

                }
                


            }
        }

        public static void EachPersonMessage(List<Person> peopleInMyPartyMessages)
        {
            foreach (Person person in peopleInMyPartyMessages)
            {
                Console.WriteLine($"{person.Name} : {person.Message}");


            }
        }
    }
}

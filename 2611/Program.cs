using _2611;
using System;
using System.Collections.Generic;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> allStudents = Instruments.CreateAListOfStudents("students_IVMIIT.txt");
            
            List<Event> events= new List<Event>();

            string command = "";

            while (!command.Equals("выход"))
            {
                Console.Clear();
                Console.WriteLine("команды: 1) создать мероприятие 2) принять участие в мероприятиях");
                switch (command)
                {
                    case "1":
                        events.Add(Instruments.CreateEvent());
                        break;
                    case "2":
                        Instruments.PrintAllEvents(events);
                        Instruments.ParticipateInActivities(ref events, allStudents);
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}

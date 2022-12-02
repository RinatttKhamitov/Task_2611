using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _2611
{
    static class Instruments
    {
        public static int CountEvent = 0;
        /// <summary>
        /// читает из файла студентов, и добавляет их в список
        /// </summary>
        /// <param name="nameFile">название файла</param>
        /// <returns></returns>
        public static List<Student> CreateAListOfStudents(string nameFile)
        {
            List<Student> students = new List<Student>();
            StreamReader f = new StreamReader(nameFile);
            while (!f.EndOfStream)
            {
                string[] s = f.ReadLine().Split(new char[] { ':' });
                students.Add(new Student(s[0], s[1]));
            }
            f.Close();
            return students;
        }
        /// <summary>
        /// создает мероприятие
        /// </summary>
        /// <returns></returns>
        public static Event CreateEvent()
        {
            Console.WriteLine("Введи название мероприятие");
            string name = Console.ReadLine();
            Console.WriteLine("Введи количество учасников");
            int count = int.Parse(Console.ReadLine());
            return new Event(name, count);
        }
        /// <summary>
        /// печатает все мероприятия
        /// </summary>
        /// <param name="events">мероприятия</param>
        public static void PrintAllEvents(List<Event> events)
        {
            Console.WriteLine("Все доступные мероприятия:");
            int k = 1;

            foreach (Event eventt in events)
            {
                Console.WriteLine($"{k}) <<{eventt.nameEvent}>> количество участников - {eventt.numberOfParticipants}");
                k++;
            }
        }

        /// <summary>
        /// Метод "участвовать в мероприятиях" 
        /// </summary>
        public static void ParticipateInActivities(ref List<Event> events, List<Student> allStudents)
        {
            Console.Write("Введи название мероприятие : ");
            string name = Console.ReadLine();
            int k = 1;
            Event eventt = events.Find(x => x.nameEvent == name); // lambda 
            if (eventt == null)
            {
                Console.WriteLine("Вы ввели неверное название мероприятия");
                return;
            }
            Console.WriteLine(eventt.nameEvent);
            Console.WriteLine("Введи тип заполнения 1) <<Cлучайный>>, 2) <<Выборочный>>)");
            string com = Console.ReadLine();
            if (com.Equals(1))
            {

            }
            Console.WriteLine($"Введи номера студентов которые будут участвовать  (количество {eventt.numberOfParticipants})");
            foreach (Student std in allStudents)
            {
                Console.WriteLine($"{k}) {std.name} {std.GetAttendance()}");
                k++;
            }
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' });
            if (numbers.Length == eventt.numberOfParticipants)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    allStudents[int.Parse(numbers[i]) - 1].ParticipateInTheEvent();
                    eventt.students.Add(allStudents[int.Parse(numbers[i]) - 1]);
                }
                foreach (Student std in allStudents)
                {
                    std.countEvent++;
                }


                eventt.Participate();
                events.Remove(eventt);
                
            }
            else
            {
                Console.WriteLine("Вы ввели неверное количество студентов");
                return;
            }


        }
        static public void RandomSort(Event eventt, List<Student> allStudents)
        {
            for (int i = 0; i < allStudents.Count; i++)
            {
                if (eventt.students.Count == eventt.numberOfParticipants)
                {
                    eventt.Participate();
                    return;
                }
                if (!allStudents[i].GetAttendance().Equals(""))
                {
                    eventt.students.Add(allStudents[i]);
                }
            }
            for (int i = 0; i < allStudents.Count; i++)
            {
                eventt.students.Add(allStudents[i]);
                if (eventt.students.Count == eventt.numberOfParticipants)
                {
                    eventt.Participate();
                    return;
                }
            }
        }
    }
}

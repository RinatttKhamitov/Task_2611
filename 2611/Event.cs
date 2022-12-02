using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2611
{
    class Event
    {
        public string nameEvent;
        /// <summary>
        /// Нужное количество студентов
        /// </summary>
        public int numberOfParticipants;
        /// <summary>
        /// Массив студентов
        /// </summary>
        public List<Student> students;

        public Event(string nameEvent, int numberOfParticipants)
        {
            this.nameEvent = nameEvent;
            this.numberOfParticipants = numberOfParticipants;
            students = new List<Student>();

        }
        /// <summary>
        /// Записать в файл
        /// </summary>
        public void Participate()
        {
            string path = $"{nameEvent}.txt";
            // полная перезапись файла 
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                for (int i = 0; i < students.Count; i++)
                {
                    writer.WriteLine($"{students[i].name} {students[i].group}");
                }
            }
            Console.WriteLine("Файл записан");

        }
    }
}

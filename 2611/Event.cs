using System;
using System.Collections.Generic;
using System.Text;

namespace _2611
{
    class Event
    {
        /// <summary>
        /// Нужное количество студентов
        /// </summary>
        int numberOfParticipants;
        /// <summary>
        /// Массив студентов
        /// </summary>
        Student[] students;
        /// <summary>
        /// добавить студентов если их не хватает 
        /// </summary>
        public void AddMoreStudents()
        {
            if (students.Length == numberOfParticipants)
            {

            }
            else if (students.Length < numberOfParticipants)
            {

            }
            else
            {

            }
        }
        /// <summary>
        /// Записать в файл
        /// </summary>
        public void Participate()
        {
            
        }
    }
}

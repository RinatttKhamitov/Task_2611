using System;
using System.Collections.Generic;
using System.Text;

namespace _2611
{
    class Student
    {
        /// <summary>
        /// имя студента
        /// </summary>
        public string name;
        /// <summary>
        /// группа
        /// </summary>
        public string group;
        /// <summary>
        /// количество его участий в мероприятиях
        /// </summary>
        int countOfParticipations;
        /// <summary>
        /// количество не участий в мероприятиях
        /// </summary>
        public int countEvent;

        /// <summary>
        /// добавить участие
        /// </summary>
        public Student(string name, string group)
        {
            this.name = name;
            this.group = group;
            countOfParticipations = 0;
        }
        /// <summary>
        /// Принять участие в мероприятии
        /// </summary>
        /// <param name="b"></param>

        public void ParticipateInTheEvent()
        {
            countOfParticipations++;
        }
        public string GetAttendance()
        {
            if (countOfParticipations - countEvent <= -3) 
            {
                return "<<Студент давно не участвовал в меропритях>>";
            }
            else
            {
                return "";
            }
        }
    }
}

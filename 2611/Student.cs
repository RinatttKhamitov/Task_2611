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
        string name;
        /// <summary>
        /// количество его участий в мероприятиях
        /// </summary>
        int countOfParticipations;

        /// <summary>
        /// добавить участие
        /// </summary>
        public void ParticipateInTheEvent()
        {
            countOfParticipations++;
        }
    }
}

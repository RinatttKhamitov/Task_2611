using System;
using System.Collections.Generic;
using System.Text;

namespace dz2
{
    class Hobby
    {
        public string nameOfHobby;
        public string[] topicsForConversation;
        public Hobby(string nameOfHobby)
        {
            this.nameOfHobby = nameOfHobby; // (Музыка, Фильмы, Игры, Спорт)
            switch (nameOfHobby)
            {
                case "музыка":
                    topicsForConversation = new string[] { "Вам нравится музыка?", "Вы слышали новый трек?", "Вы пойдете на следующий концерт?"};
                    break;
                case "фильмы":
                    topicsForConversation = new string[] { "Вам нравится фильмы?", "Мне нравится актер Леонардо Дикаприо", "Вы видели новый фильм?" };
                    break;
                case "игры":
                    topicsForConversation = new string[] { "Вам нравится игры?", "Пойдете в кс?", "Вы видели новую игру?" };
                    break;
                case "спорт":
                    topicsForConversation = new string[] { "Вам нравится спорт?", "Пойдете играть в волейбол?", "Вы смотрели чемпионат мира по футболу?" };
                    break;
            }
        }
        

    }
}

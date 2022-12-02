using System;
using System.Collections.Generic;

namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько человек хотите создать?");
            int count = int.Parse(Console.ReadLine());
            while (count != 0)
            {
                if (CreateCharacte())
                {
                    count--;
                }
            }
            string com = "";
            while (!com.Equals("выход"))
            {
                Console.WriteLine("__________________________________________________________________________");
                Console.WriteLine("Кто хочет рассказать о своих увлечениях?");
                string name = Console.ReadLine();
                for (int i = 0; i < Character.allCharacter.Count; i++)
                {
                    if (Character.allCharacter[i].name.Equals(name))
                    {
                        Character.allCharacter[i].SayHobby();
                    }
                }
            }

        }
        
        static bool CreateCharacte()
        {
            Console.WriteLine("Как ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Чем вы увлекаетесь? (Музыка, Фильмы, Игры, Спорт)");
            string hobby = Console.ReadLine().ToLower();
            switch (hobby)
            {
                case "музыка":
                    Character.allCharacter.Add(new Character(name, new Hobby(hobby)));
                    Console.Clear();
                    return true;
                    
                case "фильмы":
                    Character.allCharacter.Add(new Character(name, new Hobby(hobby)));
                    Console.Clear();
                    return true;
                case "игры":
                    Character.allCharacter.Add(new Character(name, new Hobby(hobby)));
                    Console.Clear();
                    return true;
                case "спорт":
                    Character.allCharacter.Add(new Character(name, new Hobby(hobby)));
                    Console.Clear();
                    return true;
                default:
                    Console.WriteLine("Вы не правильно ввели хобби");
                    Console.Clear();
                    return false;

            }
        }
    }
}

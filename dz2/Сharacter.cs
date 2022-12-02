using System;
using System.Collections.Generic;
using System.Text;

namespace dz2
{
    class Character
    {
        Hobby hobby;
        public string name;
        public static List<Character> allCharacter = new List<Character> { };
        public Character(string name, Hobby hobby)
        {

            this.name = name;
            this.hobby = hobby;
        }
        public void SayHobby()
        {
            Random rnd = new Random();
            Console.WriteLine($"{name} - <<{hobby.topicsForConversation[rnd.Next(0, 3)]}>>");
            for (int i = 0; i < allCharacter.Count; i++)
            {
                if (!allCharacter[i].name.Equals(name))
                {
                    allCharacter[i].Reply(hobby);
                }
            }
        }
        public void Reply(Hobby hobby)
        {
            if (hobby.nameOfHobby.Equals(this.hobby.nameOfHobby))
            {
                Console.WriteLine($"{name} - <<Да мне нравится {this.hobby.nameOfHobby}>>");
            }
            else 
            {
                Console.WriteLine($"{name} - <<Мне не нравится {hobby.nameOfHobby}>>");
            }
        }


    }
}

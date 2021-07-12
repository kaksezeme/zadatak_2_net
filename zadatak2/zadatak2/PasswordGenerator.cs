using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak2
{
    abstract class PasswordGenerator
    {
        protected readonly Random random = new Random();
        
        public abstract string generatePassword(int size);

        protected char getRandomCharacter()
        {
            if (random.Next() % 2 == 0)
            {
                return (char) random.Next('a', 'a' + 26);
            } else
            {
                if (random.Next() % 2 == 0)
                {
                    return (char)random.Next('A', 'A' + 26);
                } else
                {
                    return (char)random.Next('0', '0' + 10);
                }
            }
        }
    }
}

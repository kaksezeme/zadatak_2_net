using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak2
{
    class SpecificGenerator : PasswordGenerator
    {

        private readonly string ALLOWED_CHARS = "qwertzuiopasdfghjklyxcvbnm";

        public override string generatePassword(int size)
        {
            StringBuilder passwordBuilder = new StringBuilder();

            for (int i = 0; i < size; i++)
            {
                passwordBuilder.Append(generateAllowedCharacter());
            }

            return passwordBuilder.ToString();
        }

        private char generateAllowedCharacter()
        {
            char character = '0';

            do
            {
                character = this.getRandomCharacter();
            } while (!ALLOWED_CHARS.Contains(character));

            return character;
        }

    }
}

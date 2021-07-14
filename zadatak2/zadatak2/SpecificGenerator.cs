using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak2
{
    class SpecificGenerator : PasswordGenerator
    {
        public string ALLOWED_CHARS = "abcdefghijklmnoprstuvzxy";
        public override string generatePassword(int size)
        {
            StringBuilder passwordBuilder = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                var character = getRandomCharacter().ToString();

                if (ALLOWED_CHARS.Contains(character) || ALLOWED_CHARS.ToUpper().Contains(character))
                {
                    passwordBuilder.Append(character);
                }
                else
                {
                    var newChar = int.Parse(character);
                    passwordBuilder.Append((char)newChar);
                }
            }

            

            return passwordBuilder.ToString().ToLower();
        }
    }
}

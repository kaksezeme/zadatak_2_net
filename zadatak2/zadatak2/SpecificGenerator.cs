using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak2
{
    class SpecificGenerator : PasswordGenerator
    {

        public override string generatePassword(int size)
        {
            StringBuilder passwordBuilder = new StringBuilder();
            string letter;
            for (int i = 0; i < size; i++)
            {
                do
                {
                    letter = this.getRandomCharacter().ToString().ToLower();
                } while (letter == "0" && letter == "1" && letter == "2" && letter == "3" && letter == "4" &&
                    letter == "5" && letter == "6" && letter == "7" && letter == "8" && letter == "9");
                passwordBuilder.Append(this.getRandomCharacter().ToString().ToLower());
            }
            return passwordBuilder.ToString();
        }
    }
}

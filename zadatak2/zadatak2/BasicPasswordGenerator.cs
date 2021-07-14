using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak2
{
    class BasicPasswordGenerator : PasswordGenerator
    {
        public override string generatePassword(int size)
        {
            StringBuilder passwordBuilder = new StringBuilder();

            for (int i = 0; i < size; i++)
            {
                passwordBuilder.Append(this.getRandomCharacter());
            }

            return passwordBuilder.ToString();
        }
    }
}

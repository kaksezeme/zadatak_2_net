using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak2
{
    class SpecificGenerator : PasswordGenerator
    {
        public override string generatePassword(int size)
        {
            StringBuilder pass = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                char c;
                do
                {
                    c = this.getRandomCharacter();
                } while (Char.IsUpper(c));
                pass.Append(c);
            }

            return pass.ToString(); 
        }
    }
}

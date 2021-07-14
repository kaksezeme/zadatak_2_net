using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak2
{
    class BasicPasswordGenerator : PasswordGenerator
    {
        public override string generatePassword(int size)
        {
            StringBuilder pass = new StringBuilder();
            for (int i = 0; i < size; i++)
			{
                pass.Append(this.getRandomCharacter());
			}

            return pass.ToString();
        }
    }
}

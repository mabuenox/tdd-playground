using System;

namespace TDDPlayground
{
    public class PasswordValidator
    {
        public PasswordValidator()
        {
        }

        public bool Verify(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            var hasNumber = false;
            var chars = password.ToCharArray();
            foreach(var c in chars)
            {
                if(char.IsNumber(c))
                {
                    hasNumber = true;
                }
            }

            if(!hasNumber)
            {
                return false;
            }

            return true;

        }
    }
}
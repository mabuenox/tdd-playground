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

            if(!HasMinLenght(password))
            {
                return false;
            }
            if (!HasAtLeastOneaNumber(password))
            {
                return false;
            }

            return true;

        }

        private bool HasMinLenght(string password)
        {
            bool result;
            if (password.Length < 8)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        private bool HasAtLeastOneaNumber(string password)
        {
            var hasNumber = false;
            var chars = password.ToCharArray();
            foreach (var c in chars)
            {
                if (char.IsNumber(c))
                {
                    hasNumber = true;
                }
            }

            if (!hasNumber)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
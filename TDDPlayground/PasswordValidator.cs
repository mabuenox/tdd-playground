﻿using System;

namespace TDDPlayground
{
    public class PasswordValidator
    {
        public PasswordValidator()
        {
        }

        public bool Verify(string password)
        {
            if (password.Length >= 8)
            {
                return true;
            }
            return false;

        }
    }
}
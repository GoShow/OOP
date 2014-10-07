using System;

static class Validator
{
    public static bool IsValidString(string str)
    {
        if (String.IsNullOrEmpty(str))
        {
            return false;
        }
        return true;
    }

    public static bool IsValidAge(int num)
    {
        if (num < 1 || num > 100)
        {
            return false;
        }

        return true;
    }

}


using System;
using System.Collections.Generic;
using System.Text;

public static class StringBuilderExtensions
{
    public static StringBuilder Substring(this StringBuilder stringBuilder, int startIndex, int length)
    {
        StringBuilder resultSubstring = new StringBuilder();
        for (int i = startIndex; i < startIndex + length; i++)
        {
            resultSubstring.Append(stringBuilder[i]);
        }
        return resultSubstring;
    }

    public static StringBuilder RemoveText(this StringBuilder stringBuilder, string text)
    {
        int index = stringBuilder.ToString().IndexOf(text);
        while (index > -1)
        {
            stringBuilder.Remove(index, text.Length);
            index = stringBuilder.ToString().IndexOf(text);
        }

        return stringBuilder;
    }

    public static StringBuilder AppendAll<T>(this StringBuilder stringBuilder, IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            stringBuilder.Append(item.ToString());
        }

        return stringBuilder;
    }
}


using System.Linq;
using System.Text.RegularExpressions;

public class StripCommentsSolution
{
    public static string StripComments(string text, string[] commentSymbols)
    {
        var commentSigns = String.Join("", commentSymbols).ToCharArray();
        string[] lines = text.Split("\n");

        for (int i = 0; i < lines.Length; i++)
        {
            int commentIndex = lines[i].IndexOfAny(commentSigns);

            if (commentIndex >= 0)
                lines[i] = lines[i].Substring(0, commentIndex);

            lines[i] = lines[i].TrimEnd();
        }

        return String.Join("\n", lines);
    }


    //public static string StripComments(string text, string[] commentSymbols)
    //{
    //    char[] commentsSigns = String.Join("", commentSymbols).ToCharArray();

    //    while (true)
    //    {
    //        int indexOfCommentSymbol = text.IndexOfAny(commentsSigns);
    //        int indexOfNewLine = text.IndexOf('\n');

    //        if (indexOfCommentSymbol >= 0)
    //            indexOfNewLine = text.IndexOf('\n', indexOfCommentSymbol);

    //        if (indexOfCommentSymbol >= 0 && indexOfNewLine > indexOfCommentSymbol)
    //        {
    //            text = text.Remove(indexOfCommentSymbol, indexOfNewLine - indexOfCommentSymbol);
    //            continue;
    //        }

    //        if (indexOfCommentSymbol >= 0 && indexOfNewLine < 0)
    //        {
    //            text = text.Remove(indexOfCommentSymbol);
    //        }

    //        break;
    //    }

    //    text = text.Replace(" \n", "\n");

    //    return text.Trim();
    //}
}
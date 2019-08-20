using System.Collections.Generic;

namespace Section8Strings
{
    public class StringUtils
    {
        public static string summarizeText(string text, int maxLength = 50)
        {
            // SUMMARISING TEXT

            if (text.Length < maxLength)
                return text;

            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                // Adding 1 for the space.
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return string.Join(' ', summaryWords) + " ...";

        }
    }
}

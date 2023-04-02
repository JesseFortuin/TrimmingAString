using System.Text;

namespace TrimmingAString.BL
{
    public class StringLengthChecker : IStringLengthChecker
    {
        public string TrimString(string phrase, int len)
        {
            StringBuilder sb = new StringBuilder(phrase);

            if (phrase.Length > len) 
            {
                sb.Remove(len, phrase.Length - len).ToString();

                if (sb.Length > 3 ) 
                {
                    return sb.Remove(sb.Length - 3, 3).Append("...").ToString();               
                }

                if (sb.Length <= 3 ) 
                { 
                    return sb.Append("...").ToString();
                }
            }
            return phrase;
        }
    }
}
using System.Text;

namespace _75_blind_question.Arrays_Hashing;

public class Encode_Decode_Strings
{
    public string Encode(IList<string> strs)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var str in strs)
        {
            sb.Append(str.Length);
            sb.Append("#");
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        List<string> result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int delimiterIndex = s.IndexOf('#', i);
            
            int length = int.Parse(s.Substring(i, delimiterIndex - i));
            
            string str = s.Substring(delimiterIndex + 1, length);
            result.Add(str);
            i = delimiterIndex + 1 + length;
        }

        return result;
    }
}
namespace _75_blind_question.Arrays_Hashing;

public class GroupAngrams
{
    public List<List<string>> firstTry_GroupAngrams(string[] strs)
    {
        var map = new Dictionary<string, List<string>>();

        foreach (string s in strs)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }

            map[key].Add(s);
        }

        return new List<List<string>>(map.Values);
    }
}
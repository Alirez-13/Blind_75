namespace _75_blind_question.Arrays_Hashing;

public class Top_K_FrequentElement
{
    // Using Linq as output. 
    public int[] firstTry_TopKFrequent(int[] nums, int k)
    {
        var counts = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }
        
        return counts.OrderByDescending(pair => pair.Value)
            .Take(k)
            .Select(pair => pair.Key)
            .ToArray();
    }
    
}
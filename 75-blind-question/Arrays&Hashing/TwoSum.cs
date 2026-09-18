using System.Xml;

namespace _75_blind_question.Arrays_Hashing;

public class TwoSum
{
    public int[] firstTryTwoSum(int[] nums, int target)
    {
        if (nums.Length < 1)
        {
            if (nums[0] == target)
            {
                return nums;
            }
        }

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return Array.Empty<int>();
    }


    public int[] On_TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (seen.TryGetValue(complement, out int index))
            {
                return new[] { index, i };
            }

            seen[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
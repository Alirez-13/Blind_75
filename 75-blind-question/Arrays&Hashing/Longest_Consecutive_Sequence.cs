namespace _75_blind_question.Arrays_Hashing;

public class Longest_Consecutive_Sequence
{
    // Time limit exceed 
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (var num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (numSet.Contains(currentNum + 1))
                {
                    currentStreak++;
                    currentNum++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }

    public int secTry_LongestConsecutive(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        var numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;
                // Prevent overflow for Integer.
                while (currentNum < int.MaxValue && numSet.Contains(currentNum + 1))
                {
                    currentStreak++;
                    currentNum++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }
}
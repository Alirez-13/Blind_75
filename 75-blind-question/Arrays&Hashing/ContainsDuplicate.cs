using System.Net.ServerSentEvents;

namespace _75_blind_question.Arrays_Hashing;

// Green 
public class ContainsDuplicate
{
    public bool Time_On2_HasDuplicate(int[] nums)
    {
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            for (int j = i + 1; j <= nums.Length -1; j++)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }

        return false;
    }


    public bool Time_On_HasDuplicate(int[] nums)
    {
        var tmp = new HashSet<int>(nums);
        return tmp.Count < nums.Length;
    }

    public bool Time_OnLogn_HasDuplicate(int[] nums)
    {
        Array.Sort(nums);// n Log n
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1]) return true;

        }
        return false;
    }
}
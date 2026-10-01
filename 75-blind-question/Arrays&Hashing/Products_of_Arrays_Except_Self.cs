namespace _75_blind_question.Arrays_Hashing;

public class Products_of_Arrays_Except_Self
{
    // First try (Brute Force) *Time limit exceed 
    public int[] first_ProductExceptSelf(int[] nums)
    {
        int result = nums.Length;
        int[] output = new int[result];
        for (int i = 0; i < nums.Length; i++)
        {
            int currentProduct = 1;

            for (int j = 0; j < result; j++)
            {
                if (i != j)
                {
                    currentProduct *= nums[j];
                }
            }

            output[i] = currentProduct;
        }

        return output;
    }

    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] output = new int[n];

        output[0] = 1;
        for (int i = 1; i < n; i++)
        {
            output[i] = output[i - 1] * nums[i - 1];
        }

        int rightProduct = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            output[i] *= rightProduct;
            rightProduct *= nums[i];
        }

        return output;
    }
}


public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0, right = numbers.Length - 1;
        while (left < right)
    {
        int sum = numbers[left] + numbers[right];

        if (sum == target)
        {
            return new int[] { left + 1, right + 1 }; // 1-indexed
        }
        else if (sum < target)
        {
            left++;   // need a bigger sum, move left pointer up
        }
        else
        {
            right--;  // need a smaller sum, move right pointer down
        }
    }

    return new int[] { }; // or throw, depending on problem constraints
    }
}

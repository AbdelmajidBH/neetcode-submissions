public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var temp = new Dictionary<int,int>();
        var result = new int[2];

        for(int i=0; i < nums.Length; i++)
        {
            var difference  = target - nums[i];

            if(temp.ContainsKey(difference))
            {
                result[1]=i;
                result[0]=temp[difference];
                break;
            }          
            temp[nums[i]] = i;
        }

        return result;
    }
}

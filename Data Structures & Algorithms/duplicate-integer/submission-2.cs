public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> tmp = new HashSet<int>();

        foreach(int i in nums)
        {
            if(!tmp.Add(i)) return true;
        }
        return false;
    }
}
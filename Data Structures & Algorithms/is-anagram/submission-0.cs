public class Solution {
    public bool IsAnagram(string s, string t) {    

        if(s.Length != t.Length) return false;

        var dictiS = new Dictionary<char,int>();
        var dictiT = new Dictionary<char,int>();
        
        foreach(char ss in s)
        {
            if(dictiS.ContainsKey(ss))
            {
                dictiS[ss] = dictiS[ss] + 1;
            }
            else
            {
                dictiS.Add(ss,1);
            }
        }

        foreach(char tt in t)
        {
            if(dictiT.ContainsKey(tt))
            {
                dictiT[tt] = dictiT[tt] + 1;
            }
            else
            {
                dictiT.Add(tt,1);
            }
        }

        foreach(var kvp in dictiS)
        {
            if(!dictiT.ContainsKey(kvp.Key) || kvp.Value != dictiT[kvp.Key]) return false;
        }

        return true;
    }
}

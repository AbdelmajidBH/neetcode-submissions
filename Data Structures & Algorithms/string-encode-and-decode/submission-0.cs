public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder encoded_string = new StringBuilder();
        foreach(string str in strs)
        {
            encoded_string.Append(str.Length);
            encoded_string.Append("#");
            encoded_string.Append(str);
        }
        return encoded_string.ToString();
    }

    public List<string> Decode(string s) {        
        var decoded_strs = new List<string>();
        int start = 0;
        while (start < s.Length)
        {
            int delimiter = s.IndexOf('#', start);
            int length = int.Parse(s.Substring(start, delimiter - start));
            decoded_strs.Add(s.Substring(delimiter + 1, length));
            start = delimiter + 1 + length;
        }
        return decoded_strs;
   }
}

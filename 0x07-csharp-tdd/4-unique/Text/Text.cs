﻿using System;

namespace Text
{
	///<summary>Class for string operations</summary>
	public class Str
	{
        ///<summary>Determines index of first non-repeating character.</summary>
        public static int UniqueChar(string s)
        {
            ///<summary>qwrtqwrtqwrt</summary>
            List<char> reject = new List<char>();
            ///<summary>qwrtqwrtqwrt</summary>
            Dictionary<char, int> hold = new Dictionary<char, int>();
            ///<summary>qwrtqwrtqwrt</summary>
            int idx = -1;
            ///<summary>qwrtqwrtqwrt</summary>
            for (int i = 0; i < s.Length; i++)
            {
                if (reject.Contains(s[i]))
                    continue;
                if (hold.ContainsKey(s[i]))
                {
                    reject.Add(s[i]);
                    hold.Remove(s[i]);
                    continue;
                }
                hold.Add(s[i], i);
            }
            ///<summary>qwrtqwrtqwrt</summary>
            foreach (KeyValuePair<char, int> uniq in hold)
            {
                if (uniq.Value < idx || idx == -1)
                    idx = uniq.Value;
            }
            return (idx);
        }
	}
}

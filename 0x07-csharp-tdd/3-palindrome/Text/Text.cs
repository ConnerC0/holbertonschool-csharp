using System;
using System.Text.RegularExpressions;

namespace Text
{
	///<summary>Performs operations on text string inputs.</summary>
	public class Str
	{
        ///<summary>Determines if text is a palindrome.</summary>
		public static bool IsPalindrome(string s)
		{
			s = Regex.Replace(s, "[^A-Za-z]", "");

			char[] array = s.ToCharArray();
			Array.Reverse(array);

			return s.ToLower() == new string(array).ToLower();
		}
	}
}

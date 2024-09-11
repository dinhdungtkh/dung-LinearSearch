using Dung.Array;
namespace Dung.LinearSearch
{
    public class Bai25LinearSearch
    {
        /// <summary>
        /// s consists of parentheses only '()[]{}'.
        ///Given a string s containing just the characters '(', ')', '{', '}', '[' and ']',
        ///determine if the input string is valid.
        /// </summary>
        Stack<char> charStack = new Stack<char>();

        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '{' || c == '[' || c == '(')
                {
                    charStack.Push(c);
                }
                else if (c == '}' || c == ']' || c == ')')
                {
                    if (charStack.Count == 0 || charStack.Peek() != InvertOf(c))
                    {
                        return false;
                    }
                    charStack.Pop();
                }
                else
                {
                    return false;
                }
            }
            return charStack.Count == 0;
        }

        private char InvertOf(char c)
        {
            switch (c)
            {
                case '}': return '{';
                case ']': return '[';
                case ')': return '(';
                default: throw new ArgumentException("Invalid bracket");
            }
        }
       
    }

}
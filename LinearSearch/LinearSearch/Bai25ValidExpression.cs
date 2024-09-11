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
        StackLinkedList<char> charStack = new StackLinkedList<char>();

        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '{' || c == '[' || c == '(')
                {
                    charStack.push(c);
                }
                else if (c == '}' || c == ']' || c == ')')
                {
                    if (charStack.Count == 0 || charStack.Peek() != InvertOf(c))
                    {
                        return false;
                    }
                    charStack.get();
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

        static void Main(string[] args)
        {
            Bai25LinearSearch test = new Bai25LinearSearch();
            string s = "()";
            string s1 = "()[]{}";
            string s2 = "([])";
            string s3 = "([)]";

            Console.WriteLine($"Check Valid for '{s}': {test.IsValid(s)}");
            Console.WriteLine($"Check Valid for '{s1}': {test.IsValid(s1)}");
            Console.WriteLine($"Check Valid for '{s2}': {test.IsValid(s2)}");
            Console.WriteLine($"Check Valid for '{s3}': {test.IsValid(s3)}");

            Console.ReadLine();
        }
    }

}
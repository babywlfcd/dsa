namespace Practice.Course.Assignments.Queues_Stacks
{
    public class StackAssignment
    {
        /// <summary>
        /// 2. Balanced Parentheses
        /// T.C -> O(n)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ValidateBalancedParenthesis(string s)
        {
            if (s.Length == 0)
                return "balanced";

            var validBrackets = new Dictionary<char, char>
            {
                ['('] = ')'
            };

            var brackets = new Stack<char>();
            for (var i = 0; i < s.Length; i++)
            {
                // check if char is left bracket or right
                if (validBrackets.ContainsKey(s[i]))
                    brackets.Push(s[i]);

                else
                {
                    if (brackets.Count == 0) // no  left brackets stored
                        return "not balanced";

                    var lastChar = brackets.Pop();
                    var correctBracket = validBrackets[lastChar];
                    if (!s[i].Equals(correctBracket))
                        return "not balanced";
                }
            }

            if (brackets.Count != 0)
                return "not balanced";

            return "balanced";
        }

        /// <summary>
        /// 3. Sort stack using another stack
        /// T.C -> O(n^2)
        /// S.C -> O(n)
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>
        public Stack<int> SortStack(Stack<int> stack)
        {
            var result = new Stack<int>();

            if (stack.Count == 0)
                return stack;

            var current = stack.Pop();

            if(result.Count == 0)
                result.Push(current);

            while (stack.Count != 0)
            {
                current = stack.Pop();
                
                if (current > result.Peek())
                {
                    var temp = current;
                    while (result.Count != 0 && temp > result.Peek())
                    {
                        var x = result.Pop();
                        stack.Push(x);
                    }
                    result.Push(temp);
                }
                else
                {
                    result.Push(current);
                }
            }

            return result;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCoding
{
    public class ValidParenthesis
    {
        public readonly Dictionary<char, char> brackets = new Dictionary<char, char>{ {'(', ')'},  {'[', ']'},  {'{', '}'} };

        public bool IsValid(string s)
        {
            var endings = new Stack<char>();
            foreach (var current in s)
            {
                if (brackets.ContainsKey(current))
                {
                    endings.Push(brackets[current]);
                }
                else if (endings.Count == 0 || endings.Pop() != current)
                {
                    return false;
                }
            }
            return endings.Count == 0;
        }
      
    }
}

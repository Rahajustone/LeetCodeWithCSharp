using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    class NestedInteger
    {

         // @return true if this NestedInteger holds a single integer, rather than a nested list.
        public bool IsInteger() => true;

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        public int GetInteger() => 1;
 
          // @return the nested list that this NestedInteger holds, if it holds a nested list
          // Return null if this NestedInteger holds a single integer
        public IList<NestedInteger> GetList() => new List<NestedInteger>();
     }

    internal class NestedIterator
    {
        private List<int> flattened;
        private int index;

        public NestedIterator(IList<NestedInteger> nestedList)
        {
            flattened = new List<int>();
            index = 0;
            flattened = Flattened(nestedList);
            
        }

        private List<int> Flattened(IList<NestedInteger> nestedList)
        {
            List<int> result = new List<int>();
            foreach (var nested in nestedList) {
                if(nested.IsInteger())
                {
                    result.Add(nested.GetInteger());
                } else
                {
                    result.AddRange(Flattened(nested.GetList()));
                }
            }

            return result;
        }

        public int Next()
        {
            return flattened[index++];
        }

        public bool HasNext()
        {
            return index < flattened.Count;
        }
    }
}

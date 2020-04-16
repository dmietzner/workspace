using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given a list of strings, return a list that contains the distinct values. In other words, no value is to be
         included more than once in the returned list. (Hint: Think HashSet)
         DistinctValues( ["red", "yellow", "green", "yellow", "blue", "green", "purple"] ) -> ["red", "yellow", "green", "blue", "purple"]
         DistinctValues( ["jingle", "bells", "jingle", "bells", "jingle", "all", "the", "way"] ) -> ["jingle", "bells", "all", "the", "way"]
         */
        public List<string> DistinctValues(List<string> stringList)
        {
            List<string> result = new List<string>();
            Dictionary<string, bool> seen = new Dictionary<string, bool>();
            for (int i = 0; i < stringList.Count; i++)
            {
                if (!seen.ContainsKey(stringList[i]))
                {
                    seen.Add(stringList[i], true);
                }
            }
            
            foreach (string key in seen.Keys)
            {
                result.Add(key);
            }
            return result;
        }

    }
}

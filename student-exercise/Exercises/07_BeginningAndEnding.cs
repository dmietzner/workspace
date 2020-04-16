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
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array,
         * there is a key of its first character with the value of its last character.
         *
         * BeginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * BeginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * BeginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
            Dictionary<string, string> output = new Dictionary<string, string>();
            string x;
            for (int i = 0; i < words.Length; i++)
            {
                x = words[i];
                string key = x.Substring(0, 1);
                string value = x.Substring(x.Length - 1, 1);

                if (!output.ContainsKey(key))
                {
                    output.Add(key, value);
                }
                else
                {
                    output[key] = value;
                }
            }     return output;
        }
    }
}

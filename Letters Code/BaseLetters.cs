using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Code
{
    public class BaseLetters
    {
        public virtual int VowelChecker(string word)
        {
            int total = 0;
            var vowelList = new List<char>();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U')
                {
                    vowelList.Add(word[i]);
                    total += 1;
                }
            }

            if (vowelList.Count > 0)
            {
                var unique = new HashSet<char>(vowelList);
                int i = Convert.ToInt32(unique.Count);
                return i;
            }
            else
            {
                return 0;
            }

        }

        public virtual string DuplicateCheck(string word)
        {
            var duplicates = new List<char>();
            foreach (var item in word)
            {
                int charCount = 0;
                foreach (var chars in word)
                {
                    if (item == chars)
                    {
                        charCount++;
                    }
                }

                if (charCount > 1 && !duplicates.Contains(item))
                {
                    duplicates.Add(item);
                }
            }
            if (duplicates.Count > 0)
            {
                return string.Join(",", duplicates);
            }
            else
            {
                return "No duplicate values were found";
            }
        }

        public virtual string VowelsOrNonVowels(string word)
        {
            int vowels = 0;
            int nonVowels = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U')
                {
                    vowels += 1;
                }
                else
                {
                    nonVowels += 1;
                }
            }

            if (vowels == nonVowels)
            {
                return "The text has an equal amount of vowels and non vowels";
            }
            else if (vowels > nonVowels)
            {
                return "The text has more vowels than non vowels";
            }
            else
            {
                return "The text has more non vowels than vowels";
            }
        }
    }
}

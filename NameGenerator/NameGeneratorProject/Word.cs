using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGeneratorProject
{
    class Word
    {
        public List<Letter> wordLetters;

        Word()
        {
            wordLetters = new List<Letter>();
        }

        Word(string word)
        {
            foreach (var letter in word)
            {
                wordLetters.Add(new Letter(letter.ToString()));
            }
        }

        void UpperCaseAll()
        {
            foreach (var letter in wordLetters)
            {
                letter.ToUpperCase();
            }
        }

        void LowerCaseAll()
        {
            foreach (var letter in wordLetters)
            {
                letter.ToLowerCase();
            }
        }

        void UpperCaseBeginning()
        {
            wordLetters.First().ToUpperCase();
        }

        void LowerCaseBeginning()
        {
            wordLetters.First().ToLowerCase();
        }

        public string Value
        {
            get
            {
                string returnValue = null;
                foreach (var letter in wordLetters)
                {
                    returnValue += letter.letterValue;
                }

                return returnValue;
            }
        }


    }
}

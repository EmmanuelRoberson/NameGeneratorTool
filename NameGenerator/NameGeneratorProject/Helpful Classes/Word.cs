using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NameGeneratorProject
{
    class Word
    {
        public List<Letter> letterValues;

        public Word()
        {
            letterValues = new List<Letter>();
        }

        public Word(string word)
        {
            foreach (var letter in word)
            {
                letterValues.Add(new Letter(letter.ToString()));
            }
        }

        void UpperCaseAll()
        {
            foreach (var letter in letterValues)
            {
                letter.ToUpperCase();
            }
        }

        void LowerCaseAll()
        {
            foreach (var letter in letterValues)
            {
                letter.ToLowerCase();
            }
        }

        void UpperCaseBeginning()
        {
            letterValues.First().ToUpperCase();
        }

        void LowerCaseBeginning()
        {
            letterValues.First().ToLowerCase();
        }

        public string Value
        {
            get
            {
                string returnValue = null;
                foreach (var letter in letterValues)
                {
                    returnValue += letter.letterValue;
                }

                return returnValue;
            }
        }

        //The first letter in the word
        public Letter First
        {
            get => letterValues[0];

            set => letterValues[0] = value;
        }

        //The last letter in the word
        public Letter Last
        {
            get => letterValues.Last();

            set
            {
                letterValues.Remove(Last);
                letterValues.Add(value);
            }

        }

        //Any additional text to add meaning to an instance of a Word
        public string meaning;

        public void AddAtBeginning(string value)
        {
            List<Letter> tempWord = new List<Letter>();
            foreach (var letter in value)
            {
                tempWord.Add(new Letter(letter.ToString()));
            }

            foreach (var letter in letterValues)
            {
                tempWord.Add(letter);
            }

            letterValues.Clear();
            letterValues = tempWord;
        }

        public void AddAtEnd(string value)
        {
            foreach (var letter in value)
            {
                letterValues.Add(new Letter(letter.ToString()));
            }
        }

        public bool IsEmpty()
        {
            return letterValues.Count == 0;
        }
    }
}

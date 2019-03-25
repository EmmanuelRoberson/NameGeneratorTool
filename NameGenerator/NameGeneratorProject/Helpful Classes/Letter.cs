using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGeneratorProject
{
    class Letter
    {

        private List<string> consonants = new List<string>();
        private List<string> vowels = new List<string>();

        public Letter()
        {
            Utilities.ReadCSV("LetterClassifications.csv", consonants, vowels);
        }

        public Letter(string value)
        {
            letterValue = value;
            Utilities.ReadCSV("LetterClassifications.csv", consonants, vowels);
        }

        public string letterValue;
        public bool IsVowel()
        {
            return vowels.Contains(letterValue);
        }

        public bool IsConsonant()
        {
            return consonants.Contains(letterValue);
        }

        public void ToUpperCase()
        {
            letterValue = letterValue.ToUpper();
        }

        public void ToLowerCase()
        {
            letterValue = letterValue.ToLower();
        }

        public void ChangeCase()
        {
            if (letterValue == letterValue.ToUpper())
            {
                ToLowerCase();
            }
            else
            {
                ToUpperCase();
            }
        }

        bool IsUpperCase()
        {
            return letterValue == letterValue.ToUpper();
        }

        bool IsLowerCase()

        {
            return letterValue == letterValue.ToLower();
        }

        public static bool operator ==(Letter letterOne, Letter letterTwo)
        {
            return letterOne.letterValue == letterTwo.letterValue;
        }

        public static bool operator !=(Letter letterOne, Letter letterTwo)
        {
            return !(letterOne == letterTwo);
        }
    }
}

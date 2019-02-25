using System;

namespace IntroToCSharp
{
    public class BaseNameBuilder : IBaseNameBuildable
    {

        private string[] consonants = new string[157];
        private string[] vowels = new string[103];

        Random rand = new Random();

        //reference: https://docs.google.com/spreadsheets/d/1K0wAiYK7E9vOz3iQrcHnCfab6TBLh7GnjLx6tlPvZI0/edit?usp=sharing
        public BaseNameBuilder()
        {
            int consonantIndexesFilled = 0;
            int vowelIndexesFilled = 0;
            // loops with more than one assignment operations have letters the same frequency

            //vowel assignments
            {
                for (int i = vowelIndexesFilled; i < vowelIndexesFilled + 33; i++)
                    vowels[i] = "e";

                vowelIndexesFilled += 33;

                for (int i = vowelIndexesFilled; i < vowelIndexesFilled + 21; i++)
                    vowels[i] = "a";

                vowelIndexesFilled += 21;

                for (int i = vowelIndexesFilled; i < vowelIndexesFilled + 19; i++)
                    vowels[i] = "o";

                vowelIndexesFilled += 19;

                for (int i = vowelIndexesFilled; i < vowelIndexesFilled + 18; i++)
                    vowels[i] = "i";

                vowelIndexesFilled += 18;

                for (int i = vowelIndexesFilled; i < vowelIndexesFilled + 7; i++)
                    vowels[i] = "u";

                vowelIndexesFilled += 7;

                for (int i = vowelIndexesFilled; i < vowelIndexesFilled + 5; i++)
                    vowels[i] = "y";

                vowelIndexesFilled += 5;
            }

            //consonant assignments
            {
                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 23; i++)
                    consonants[i] = "t";

                consonantIndexesFilled += 23;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 18; i++)
                    consonants[i] = "n";

                consonantIndexesFilled += 18;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 16; i++)
                    consonants[i] = "s";

                consonantIndexesFilled += 16;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 16; i++)
                    consonants[i] = "h";

                consonantIndexesFilled += 16;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 16; i++)
                    consonants[i] = "r";

                consonantIndexesFilled += 16;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 11; i++)
                    consonants[i] = "d";

                consonantIndexesFilled += 11;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 10; i++)
                    consonants[i] = "l";

                consonantIndexesFilled += 10;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 7; i++)
                    consonants[i] = "c";

                consonantIndexesFilled += 7;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 6; i++)
                    consonants[i] = "m";

                consonantIndexesFilled += 6;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 6; i++)
                    consonants[i] = "w";

                consonantIndexesFilled += 6;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 6; i++)
                    consonants[i] = "f";

                    consonantIndexesFilled += 6;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 5; i++)
                    consonants[i] = "g";

                consonantIndexesFilled += 5;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 5; i++)
                    consonants[i] = "p";

                consonantIndexesFilled += 5;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 4; i++)
                    consonants[i] = "b";

                consonantIndexesFilled += 4;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 2; i++)
                    consonants[i] = "v";

                consonantIndexesFilled += 2;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 2; i++)
                    consonants[i] = "k";

                consonantIndexesFilled += 2;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 1; i++)
                    consonants[i] = "j";

                consonantIndexesFilled += 1;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 1; i++)
                    consonants[i] = "x";

                consonantIndexesFilled += 1;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 1; i++)
                    consonants[i] = "q";

                consonantIndexesFilled += 1;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 1; i++)
                    consonants[i] = "z";
            }
        }

        public string RandConsonant
        {
            get { return consonants[rand.Next(0, consonants.Length)]; }
        }

        public string RandVowel
        {
            get { return vowels[rand.Next(0, vowels.Length)]; }
        }

        string IBaseNameBuildable.GenerateBaseName(int length)
        {

            string baseName;

            int consonant = rand.Next(0, consonants.Length);

            int vowel = rand.Next(0, vowels.Length);

            //initializes baseName with wither a vowel or consonant
            baseName = (length % 2 == 0) ?
                consonants[consonant].ToUpper() :
                vowels[vowel].ToUpper();

            //i is set to length % 2 so it will follow it up with the alternate type of letter
            for (int i = length % 2; i < length; i++)
            {
                consonant = rand.Next(0, consonants.Length);
                vowel = rand.Next(0, vowels.Length);

                baseName += (i % 2 != 0) ? consonants[consonant] : vowels[vowel];
            }

            return baseName;
        }
    }
}
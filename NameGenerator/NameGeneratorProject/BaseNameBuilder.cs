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
                    vowels[i] = "E";

                vowelIndexesFilled += 33;

                for (int i = vowelIndexesFilled; i < vowelIndexesFilled + 21; i++)
                    vowels[i] = "A";

                vowelIndexesFilled += 21;

                for (int i = vowelIndexesFilled; i < vowelIndexesFilled + 19; i++)
                    vowels[i] = "O";

                vowelIndexesFilled += 19;

                for (int i = vowelIndexesFilled; i < vowelIndexesFilled + 18; i++)
                    vowels[i] = "I";

                vowelIndexesFilled += 18;

                for (int i = vowelIndexesFilled; i < vowelIndexesFilled + 7; i++)
                    vowels[i] = "U";

                vowelIndexesFilled += 7;

                for (int i = vowelIndexesFilled; i < vowelIndexesFilled + 5; i++)
                    vowels[i] = "Y";

                vowelIndexesFilled += 5;
            }

            //consonant assignments
            {
                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 23; i++)
                    consonants[i] = "T";

                consonantIndexesFilled += 23;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 18; i++)
                    consonants[i] = "N";

                consonantIndexesFilled += 18;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 16; i++)
                    consonants[i] = "S";

                consonantIndexesFilled += 16;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 16; i++)
                    consonants[i] = "H";

                consonantIndexesFilled += 16;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 16; i++)
                    consonants[i] = "R";

                consonantIndexesFilled += 16;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 11; i++)
                    consonants[i] = "D";

                consonantIndexesFilled += 11;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 10; i++)
                    consonants[i] = "L";

                consonantIndexesFilled += 10;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 7; i++)
                    consonants[i] = "C";

                consonantIndexesFilled += 7;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 6; i++)
                    consonants[i] = "M";

                consonantIndexesFilled += 6;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 6; i++)
                    consonants[i] = "W";

                consonantIndexesFilled += 6;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 6; i++)
                    consonants[i] = "F";

                    consonantIndexesFilled += 6;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 5; i++)
                    consonants[i] = "G";

                consonantIndexesFilled += 5;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 5; i++)
                    consonants[i] = "P";

                consonantIndexesFilled += 5;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 4; i++)
                    consonants[i] = "B";

                consonantIndexesFilled += 4;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 2; i++)
                    consonants[i] = "V";

                consonantIndexesFilled += 2;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 2; i++)
                    consonants[i] = "K";

                consonantIndexesFilled += 2;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 1; i++)
                    consonants[i] = "J";

                consonantIndexesFilled += 1;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 1; i++)
                    consonants[i] = "X";

                consonantIndexesFilled += 1;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 1; i++)
                    consonants[i] = "Q";

                consonantIndexesFilled += 1;

                for (int i = consonantIndexesFilled; i < consonantIndexesFilled + 1; i++)
                    consonants[i] = "Z";

                consonantIndexesFilled += 1;
            }
        }


        string IBaseNameBuildable.GenerateBaseName(int length)
        {

            string baseName;

            // '+' is because the second argument in next is exclusive
            int consonant = rand.Next(0, consonants.Length);

            // add a "+ 1" to the end of vowels.Length so the name has a chance to start with w
            int vowel = rand.Next(0, vowels.Length);

            //initializes baseName with wither a vowel or consonant
            baseName = (length % 2 == 0) ?
                consonants[consonant] :
                vowels[vowel];

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
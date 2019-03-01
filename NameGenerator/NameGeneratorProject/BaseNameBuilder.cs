using System;

namespace IntroToCSharp
{
    public class BaseNameBuilder : IBaseNameBuildable
    {

        private string[] consonants = new string[157];
        private string[] vowels = new string[103];

        Random rand = new Random(DateTime.Now.Millisecond);

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

            //i is set to length % 2 so it will follow it up with the alternate type of letterToBePaired
            for (int i = length % 2; i < length; i++)
            {
                consonant = rand.Next(0, consonants.Length);
                vowel = rand.Next(0, vowels.Length);

                baseName += (i % 2 != 0) ? consonants[consonant] : vowels[vowel];
            }

            return baseName;
        }

        private string LetterPair(string letterToBePaired)
        {
            int chanceToPair = rand.Next(0, 1);

            if (chanceToPair == 0)
                return letterToBePaired;
            else
            {
                foreach (string vowel in vowels)
                {
                    if (letterToBePaired == vowel)
                    {
                        int vowelsIndex = rand.Next(0, vowels.Length);
                        letterToBePaired += vowelsIndex;
                        return letterToBePaired;
                    }
                }
                //B, C, D, F, G, H, J, K, L, M, N, P, Q, R, S, T, V, X, Z,
                int num = rand.Next(0, 7);
                switch (letterToBePaired)
                {
                    case "b":
                        switch (num)
                        {
                            case 0:
                                return "b";
                            case 1:
                                return "ae";
                            case 2:
                                return "ai";
                            case 3:
                                return "ao";
                            case 4:
                                return "au";
                            case 5:
                                return "ay";
                            default:
                                return "a";
                        }
                    case "e":
                        switch (num)
                        {
                            case 0:
                                return "ea";
                            case 1:
                                return "ee";
                            case 2:
                                return "ei";
                            case 3:
                                return "eo";
                            case 4:
                                return "eu";
                            case 5:
                                return "ey";
                            default:
                                return "e";
                        }
                    case "i":
                        switch (num)
                        {
                            case 0:
                                return "ea";
                            case 1:
                                return "ee";
                            case 2:
                                return "ei";
                            case 3:
                                return "eo";
                            case 4:
                                return "eu";
                            case 5:
                                return "ey";
                            default:
                                return "e";
                        }
                    case "o":
                        switch (num)
                        {
                            case 0:
                                return "ea";
                            case 1:
                                return "ee";
                            case 2:
                                return "ai";
                            case 3:
                                return "ao";
                            case 4:
                                return "au";
                            case 5:
                                return "ay";
                            default:
                                return "a";
                        }
                    case "u":
                        switch (num)
                        {
                            case 0:
                                return "aa";
                            case 1:
                                return "ae";
                            case 2:
                                return "ai";
                            case 3:
                                return "ao";
                            case 4:
                                return "au";
                            case 5:
                                return "ay";
                            default:
                                return "a";
                        }
                    case "y":
                        switch (num)
                        {
                            case 0:
                                return "aa";
                            case 1:
                                return "ae";
                            case 2:
                                return "ai";
                            case 3:
                                return "ao";
                            case 4:
                                return "au";
                            case 5:
                                return "ay";
                            default:
                                return "a";
                        }
                    default:
                        return letterToBePaired;

                }




            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class WordGenerator
    {
        WordList wordList;
        List<List<string>> allWordsLists;

        string noun;
        string verb;
        string adverb;
        string adjectivePositive;
        string adjectiveNegative;
        string adjective;
        string pronoun;
        string preposition;
        string interjection;
        string inquiry;
        string actionPositive;
        string actionNegative;
        string action;
        string reaction;
        string insultNoun;

        int index;
        Random random = new Random();
        public WordGenerator()
        {
            wordList = new WordList();
            allWordsLists = new List<List<string>>();
            allWordsLists = wordList.wordsLists();
        }
        public void sentenceGenerator()
        {
            generateNoun();

            generateVerb();

            generateAdverb();

            generateAdjectivePositive();

            generateAdjectiveNegative();

            generateAdjective();

            generatePronoun();

            generatePreposition();

            generateInterjection();

            Console.WriteLine(interjection + ", " + pronoun + " " + adverb + " " + verb + " the " + adjective + " " + noun + ".");
        }
        public string generateNoun()
        {
            index = random.Next(wordList.wordsLists()[0].Count);
            noun = wordList.wordsLists()[0][index];
            return noun;
        }
        public string generateVerb()
        {
            index = random.Next(wordList.wordsLists()[1].Count);
            verb = wordList.wordsLists()[1][index];
            return verb;
        }
        public string generateAdverb()
        {
            index = random.Next(wordList.wordsLists()[2].Count);
            adverb = wordList.wordsLists()[2][index];
            return adverb;
        }
        public string generateAdjectivePositive()
        {
            index = random.Next(wordList.wordsLists()[3].Count);
            adjectivePositive = wordList.wordsLists()[3][index];
            return adjectivePositive;
        }
        public string generateAdjectivePositiveTwo()
        {
            System.Threading.Thread.Sleep(10);
            index = random.Next(wordList.wordsLists()[3].Count);
            adjectivePositive = wordList.wordsLists()[3][index];
            return adjectivePositive;
        }
        public string generateAdjectiveNegative()
        {
            index = random.Next(wordList.wordsLists()[4].Count);
            adjectiveNegative = wordList.wordsLists()[4][index];
            return adjectiveNegative;
        }
        public string generateAdjectiveNegativeTwo()
        {
            System.Threading.Thread.Sleep(10);
            index = random.Next(wordList.wordsLists()[4].Count);
            adjectiveNegative = wordList.wordsLists()[4][index];
            return adjectiveNegative;
        }
        public string generateAdjective()
        {
            index = random.Next(wordList.wordsLists()[5].Count);
            adjective = wordList.wordsLists()[5][index];
            return adjective;
        }
        public string generatePronoun()
        {
            index = random.Next(wordList.wordsLists()[6].Count);
            pronoun = wordList.wordsLists()[6][index];
            return pronoun;
        }
        public string generatePreposition()
        {
            index = random.Next(wordList.wordsLists()[7].Count);
            preposition = wordList.wordsLists()[7][index];
            return preposition;
        }
        public string generateInterjection()
        {
            index = random.Next(wordList.wordsLists()[8].Count);
            interjection = wordList.wordsLists()[8][index];
            return interjection;
        }
        public string generateInquiry()
        {
            index = random.Next(wordList.wordsLists()[9].Count);
            inquiry = wordList.wordsLists()[9][index];
            return inquiry;
        }
        public string generateActionPositive()
        {
            index = random.Next(wordList.wordsLists()[10].Count);
            actionPositive = wordList.wordsLists()[10][index];
            return actionPositive;
        }
            public string generateActionNegative()
        {
            index = random.Next(wordList.wordsLists()[11].Count);
            actionNegative = wordList.wordsLists()[11][index];
            return actionNegative;
        }
        public string generateAction()
        {
            index = random.Next(wordList.wordsLists()[12].Count);
            action = wordList.wordsLists()[12][index];
            return action;
        }
        public string generateReaction()
        {
            index = random.Next(wordList.wordsLists()[13].Count);
            reaction = wordList.wordsLists()[13][index];
            return reaction;
        }
        public string generateInsultNoun()
        {
            index = random.Next(wordList.wordsLists()[14].Count);
            insultNoun = wordList.wordsLists()[14][index];
            return insultNoun;
        }
    }
}

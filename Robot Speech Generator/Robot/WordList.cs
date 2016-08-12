using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class WordList
    {
        string walk;
        string run;
        string climb;
        string jump;
        string smile;
        string scream;
        string whisper;
        string punch;
        string cry;
        string sit;
        string swim;
        string jabber;
        string whimper;
        string sway;
        string freeze;

        string react01;
        string react02;
        string react03;
        string react04;
        string react05;
        string react06;

        string inquire01;
        string inquire02;
        string inquire03;
        string inquire04;
        string inquire05;
        string inquire06;

        List<string> insultNouns;
        List<string> interjections;
        List<string> prepositions;
        List<string> pronouns;
        List<string> adjectivesPositive;
        List<string> adjectivesNegative;
        List<string> adjectives;
        List<string> adverbs;
        List<string> nouns;
        List<string> verbs;
        List<string> inquiries;
        List<string> reactions;
        List<string> actions;
        List<string> actionsPositive;
        List<string> actionsNegative;
        List<List<string>> allWordsLists;

        public WordList()
        {

        }
        public List<List<string>> wordsLists()
        {
            walk = "I am walking around and having a pleasant time doing so! :)";
            run = "I am running for my life, I wish I didn't have to run so fast!";
            climb = "A mountain shudders below my poised metal frame; I am a climber.";
            jump = "If I don't jump now I will surely feel like I should have.";
            smile = "You can only smile like this if you really feel good!";
            scream = "Ahhhhhhhhh, the freight is real; Eeeeeeeee!!!";
            whisper = "It's so quiet, I have to whisper as to not disturb the peaceful setting.";
            punch = "I didn't want to have to do this.... PUNCH!! Slam!!! Pow!!!! Boom!!!!!";
            cry = "These tears represent the feelings deep within, I cry in the cold dark sadness of this gloom.";
            sit = "I am too tired to stand.";
            swim = "There is water, I am in the water.";
            jabber = "I am doing just that right now, that is, I mean, what I said before.";
            whimper = "::Muffled Sniff:: Quietly, I plead, please leave me alone.";
            sway = "The wind is so strong, I keep swaying to and fro, to and fro.. swayyying and swayying..";
            freeze = "The icey spells of the world have stiffened my bolts and my movements have dwindled to naught.";
            actionsPositive = new List<string>();
            actionsPositive.Add(walk);
            actionsPositive.Add(climb);
            actionsPositive.Add(smile);
            actionsPositive.Add(whisper);
            actionsPositive.Add(swim);
            actionsPositive.Add(jabber);
            actionsPositive.Add(sway);
            actionsNegative = new List<string>();
            actionsNegative.Add(whimper);
            actionsNegative.Add(run);
            actionsNegative.Add(jump);
            actionsNegative.Add(scream);
            actionsNegative.Add(punch);
            actionsNegative.Add(cry);
            actionsNegative.Add(sit);
            actionsNegative.Add(freeze);
            actions = new List<string>();
            actions = actionsPositive.Union(actionsNegative).ToList();
            react01 = "Wow, that is truely insightful!";
            react02 = "Oh my goodness, I wish it were not so.";
            react03 = "I am glad you are the way you are!";
            react04 = "I flail in rhetoric turmoil that I can't make things better for you!";
            react05 = "This is great news! Thank you for sharing!";
            react06 = "I wonder if that is a good thing or not?";
            reactions = new List<string>();
            reactions.Add(react01);
            reactions.Add(react02);
            reactions.Add(react03);
            reactions.Add(react04);
            reactions.Add(react05);
            reactions.Add(react06);
            inquire01 = "How are things?";
            inquire02 = "Are you doing alright?";
            inquire03 = "What's happening?!";
            inquire04 = "What is going on?";
            inquire05 = "Would you be so kind to share your experience with me?";
            inquire06 = "How on earth is this happening?!";
            inquiries = new List<string>();
            inquiries.Add(inquire01);
            inquiries.Add(inquire02);
            inquiries.Add(inquire03);
            inquiries.Add(inquire04);
            inquiries.Add(inquire05);
            inquiries.Add(inquire06);
            interjections = new List<string>
            {
                "ahhh", "alas", "dear me", "eh", "er", "hey", "hmm", "oh", "ouch", "uh", "uhhh", "uh-huh", "um", "ummmm", "well", "gosh", "jeez", "boy o' boy", "phew", "wait", "come on", "goodness",
                "whaaaat", "but you", "stop that", "please", "whelp", "what"
            };
            prepositions = new List<string>
            {
                "aboard", "about", "above", "across", "after", "against", "along", "amid", "among", "anti", "around",
                "as", "at", "before", "behind", "below", "beneath", "beside", "besides",
                "between", "beyond", "but", "by", "concerning", "considering",
                "despite", "down", "during", "except", "excepting", "excluding", "following", "for",
                "from", "in", "inside", "into", "like", "minus", "near", "of", "off", "on", "onto",
                "opposite", "outside", "over", "past", "per", "plus", "regarding", "round", "save",
                "since", "than", "through", "to", "toward", "towards", "under", "underneath", "unlike",
                "until", "up", "upon", "versus", "via", "with", "within", "without"
            };
            pronouns = new List<string>
            {
                "anybody", "anyone", "anything", "either", "everybody", "everyone", "everything", "neither", "nobody", "no one", "nothing", "one", "somebody", "someone", "both",
                "few", "many", "several", "all", "most", "none", "some", "I", "my", "we", "you", "she", "he", "iterator", "they", "this", "that", "these", "those", "what"," who",
                "which", "whom", "whose", "my", "your", "his", "its", "your", "their"
            };
            adjectivesPositive = new List<string>
            {
                "adaptable", "adventurous", "affable", "affectionate", "agreeable", "ambitious", "amiable", "amicable", "amusing", "brave", "bright", "broad-minded", "calm", "careful",
                "charming", "communicative", "compassionate", "conscientious", "considerate", "convivial", "courageous", "courteous", "creative", "decisive", "determined", "diligent",
                "diplomatic", "discreet", "dynamic", "easygoing", "emotional", "energetic", "enthusiastic", "exuberant", "fair-minded", "faithful", "fearless", "forceful", "frank",
                "friendly", "funny", "generous", "gentle", "good", "gregarious", "hard-working", "helpful", "honest", "humorous", "imaginative", "impartial", "independent", "intellectual",
                "intelligent", "intuitive", "inventive", "kind", "loving", "loyal", "modest", "neat", "nice", "optimistic", "passionate", "patient", "persistent", "pioneering",
                "philosophical", "placid", "plucky", "polite", "powerful", "practical", "pro-active", "quick-witted", "quiet", "rational", "reliable", "reserved", "resourceful",
                "romantic", "self-confident", "self-disciplined", "sensible", "sensitive", "shy", "sincere", "sociable", "straightforward", "sympathetic", "thoughtful", "tidy",
                "tough", "unassuming", "understanding", "versatile", "warmhearted", "willing", "witty"
            };
            adjectivesNegative = new List<string>
            {
                "aggressive", "aloof", "arrogant", "belligerent", "big-headed", "boastful", "bone-idle", "boring", "bossy", "callous", "cantankerous", "careless",
                "changeable", "clinging", "compulsive", "conservative", "cowardly", "cruel", "cunning", "cynical", "deceitful", "detached", "dishonest", "dogmatic", "domineering",
                "finicky", "flirtatious", "foolish", "foolhardy", "fussy", "greedy", "grumpy", "gullible", "harsh", "impatient", "impolite", "impulsive", "inconsiderate",
                "inconsistent", "indecisive", "indiscreet", "inflexible", "interfering", "intolerant", "irresponsible", "jealous", "Lazy", "Machiavellian", "materialistic",
                "mean", "miserly", "moody", "narrow-minded", "nasty", "naughty", "nervous", "obsessive", "obstinate", "overcritical", "'overemotional", "parsimonious",
                "patronizing", "perverse", "pessimistic", "pompous", "possessive", "pusillanimous", "quarrelsome", "quick-tempered", "resentful", "rude", "ruthless",
                "sarcastic", "secretive", "selfish", "self-centred", "self-indulgent", "silly", "sneaky", "stingy", "stubborn", "stupid", "superficial", "tactless", "timid",
                "touchy", "thoughtless", "truculent", "unkind", "unpredictable", "unreliable", "untidy", "untrustworthy", "vague", "vain", "vengeful", "vulgar", "weak-willed"
            };
            adjectives = new List<string>();
            adjectives = adjectivesPositive.Union(adjectivesNegative).ToList();
            adverbs = new List<string>
            {
                "also", "often", "usually", "really", "never", "always", "sometimes", "likely", "simply", "generally", "actually", "almost", "especially", "quickly", "probably", "already",
                "directly", "thus", "easily", "eventually", "certainly", "normally", "currently", "finally", "constantly", "properly", "soon", "specifically", "immediately", "relatively",
                "slowly", "fairly", "primarily", "completely", "ultimately", "widely", "recently", "seriously", "frequently", "fully", "mostly", "naturally", "nearly", "occasionally", "carefully",
                "clearly", "essentially", "possibly", "slightly", "somewhat", "equally", "greatly", "necessarily", "personally", "rarely", "regularly", "similarly", "basically", "closely",
                "effectively", "initially", "literally", "mainly", "merely", "gently", "hopefully", "originally", "roughly", "significantly", "totally", "twice", "obviously", "perfectly",
                "physically", "successfully", "suddenly", "truly", "virtually", "altogether", "automatically", "deeply", "definitely", "deliberately", "hardly", "readily", "terribly",
                "unfortunately", "briefly", "strongly", "honestly", "previously", "first", "thirdly", "firstly"
            };
            verbs = new List<string>
            {
                "were", "had", "did", "said", "went", "got", "made", "knew", "thought", "took", "saw", "came", "wanted", "used", "found", "gave", "told", "worked",
                "called", "tried", "asked", "needed", "felt", "became", "left", "put", "meant", "kept", "let", "began", "seemed", "helped", "showed", "heard",
                "played", "ran", "moved", "lived", "believed", "brought", "happened", "wrote", "sat", "stood", "lost", "paid", "met", "included", "continued",
                "set", "learned", "changed", "led", "understood", "watched", "followed", "stopped", "created", "spoke", "read", "spent", "grew", "opened",
                "walked", "won", "taught", "offered", "remembered", "considered", "appeared", "bought", "served", "died", "sent", "built", "stayed", "fell",
                "cut", "reached", "killed", "raised", "passed", "sold", "decided", "returned", "explained", "hoped", "developed", "carried", "broke",
                "received", "agreed", "supported", "hit", "produced", "ate", "covered", "caught", "drew", "chose"
            };
            nouns = new List<string>
            {
                "time", "year", "people", "way", "day", "man", "thing", "woman", "life", "child", "world", "school", "state", "family", "student", "group", "country", "problem", "hand",
                "part", "place", "case", "week", "company", "system", "program", "question", "work", "government", "number", "night", "point", "home", "water", "room", "mother",
                "area", "money", "store", "fact", "month", "lot", "right", "study", "book", "eye", "job", "word", "business", "issue", "side", "kind", "head", "house", "service",
                "friend", "father", "power", "hour", "game", "line", "end", "member", "law", "car", "city", "community", "name", "president", "team", "minute", "idea", "kid",
                "body", "information", "back", "parent", "face", "other", "level", "office", "door", "health", "person", "art", "war", "history", "party", "result", "change", "morning",
                "reason", "research", "girl", "guy", "food", "moment", "air", "teacher"
            };
            insultNouns = new List<string>
            {
                "nerf-herder", "gumby", "maggot", "dweeb", "lightweight", "wasteoid", "lump", "puppet", "witless-sandbag", "prat", "wally", "pawn", "knobhead", "greaser", "tosser",
                "git", "spiffy", "shlup", "spoon", "crow", "fink", "dwilbert", "chimmy", "dope", "putz", "nimrod", "windbag", "floozy", "airhead", "bimbo", "bugger", "chicken", "deadbeat",
                "donkey", "wilma", "geezer", "honky", "poof", "poofter", "twirp", "wanker", "wog", "ninny"
            };
            allWordsLists = new List<List<string>>();
            allWordsLists.Add(nouns);
            allWordsLists.Add(verbs);
            allWordsLists.Add(adverbs);
            allWordsLists.Add(adjectivesPositive);
            allWordsLists.Add(adjectivesNegative);
            allWordsLists.Add(adjectives);
            allWordsLists.Add(pronouns);
            allWordsLists.Add(prepositions);
            allWordsLists.Add(interjections);
            allWordsLists.Add(inquiries);
            allWordsLists.Add(actionsPositive);
            allWordsLists.Add(actionsNegative);
            allWordsLists.Add(actions);
            allWordsLists.Add(reactions);
            allWordsLists.Add(insultNouns);
            return (allWordsLists);
        }
    }
}

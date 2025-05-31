


class Scripture
{
    //Declare variables
    private string _scriptureText;
    private List<Word> _scriptureWordList = new List<Word>();
    private string _textToDisplay;
    string _gottenWord;
    Reference _reference;
    private List<int> _unhiddenWords = new List<int>(); //Used to determine which words haven't yet been hidden.
    private Random _random = new Random();
    private int randomInt;


    public Scripture(string scriptureBookName, string scriptureReference, string scriptureText)
    {
        //This calls a Scripture class with parameters for the book name, reference numbers and text in the verse.
        //Used for a single verse.
        char[] seperatorChars = [' '];
        _scriptureText = scriptureText;
        _reference = new Reference(scriptureBookName, scriptureReference);
        string[] _seperatedText = _scriptureText.Split(seperatorChars);
        foreach (string word in _seperatedText)
        {
            Word _tempWord = new Word(word);
            _scriptureWordList.Add(_tempWord);

        }
        for (int i = 0; i < _scriptureWordList.Count; i++)
        {
            _unhiddenWords.Add(i);
        }
    }

    //TESTING

    public Scripture(string scriptureBookName, string scriptureReference, string scriptureText, string scriptureTextTwo)
    {
        //This calls a Scripture class with parameters for the book name, reference numbers and text in the verse.
        //Used for a single verse.
        char[] seperatorChars = [' '];
        _scriptureText = scriptureText + " " + "\n" + " " + scriptureTextTwo;
        _reference = new Reference(scriptureBookName, scriptureReference);
        string[] _seperatedText = _scriptureText.Split(seperatorChars);
        foreach (string word in _seperatedText)
        {
            Word _tempWord = new Word(word);
            _scriptureWordList.Add(_tempWord);

        }
        for (int i = 0; i < _scriptureWordList.Count; i++)
        {
            _unhiddenWords.Add(i);
        }
    }

    public Scripture(string scriptureBookName, string scriptureReference, string scriptureText, string scriptureTextTwo, string scriptureTextThree)
    {
        //This calls a Scripture class with parameters for the book name, reference numbers and text in the verse.
        //Used for a single verse.
        char[] seperatorChars = [' '];
        _scriptureText = scriptureText + " " + "\n" + " " + scriptureTextTwo + " " + "\n" + " " + scriptureTextThree;
        _reference = new Reference(scriptureBookName, scriptureReference);
        string[] _seperatedText = _scriptureText.Split(seperatorChars);
        foreach (string word in _seperatedText)
        {
            Word _tempWord = new Word(word);
            _scriptureWordList.Add(_tempWord);

        }
        for (int i = 0; i < _scriptureWordList.Count; i++)
        {
            _unhiddenWords.Add(i);
        }
    }

    //END TESTING


    public void DisplayScripture()
    {
        _reference.DisplayReference();
        _textToDisplay = "";
        foreach (Word word in _scriptureWordList)
        {
            _gottenWord = word.GetWord();
            _textToDisplay = _textToDisplay + " " + _gottenWord;
        }
        Console.WriteLine(_textToDisplay);
    }
    public void BlotOutWords()
    {
        //Ok so we now have a list of _unhiddenWords with a number for each word in the scripture, starting with 0.
        int _breakOut = 0;
        for (int i = 0; i < 3; i++)
        {
            randomInt = _random.Next(0, _unhiddenWords.Count);
            if (_scriptureWordList[randomInt].GetWord().Contains('_'))
            {
                i -= 1;
                _breakOut += 1;
            }
            _scriptureWordList[randomInt].FlipWord();
            // _unhiddenWords.Remove(randomInt);
            if (_breakOut > 10000)
            {
                break;
            }
        }
    }
    public void Memorize()
    {
        int _timeToQuit = 0;
        while (_unhiddenWords.Count > 0)
        {

            string _userInput;
            Console.Clear();
            DisplayScripture();
            BlotOutWords();

            _userInput = Console.ReadLine().ToLower();
            if (_userInput == "quit")
            {
                return;
            }

            if (_timeToQuit == 1)
            {
                return;
            }
            _timeToQuit = 1;
            foreach (Word word in _scriptureWordList)
            {
                if ((word.GetWord().Contains('_') == false) && word.GetWord().Contains('\n') == false)
                {
                    _timeToQuit = 0;
                }
            }
        }
    }
}



    // public void testFunction()
    // {    
    //     // private string[] testWords = _scriptureText.Split(' ');
    //     foreach (var word in testWords)
    //     {
    //         Console.WriteLine(word);
    //     }
    // }

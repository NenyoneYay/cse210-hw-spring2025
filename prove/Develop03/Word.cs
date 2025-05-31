


class Word
{
    private string _letters;
    private bool _isHidden = false;
    private string _blankWord = "";
    private int _lettersLength;

    public Word(string content)
    {
        _letters = content;
    }

    public void SetWord(string letters)
    {
        _letters = letters;
    }

    public string GetWord()
    {
        _lettersLength = _letters.Length;
        if (!_isHidden)
        {
            return _letters;
        }
        else
        {
            if (!_blankWord.Contains("_"))
            {
                for (int i = 0; i < _lettersLength; i++)
                    _blankWord += "_";
                return _blankWord;
            }
            else
            {
                return _blankWord;
            }
        }
    }

    public void FlipWord()
    {
        if (_letters != "\n")
        {
            _isHidden = true;
        }
    }
}
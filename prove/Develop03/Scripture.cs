public class Scripture
{
    private List<Word> _passageComplete;

    private Reference _reference;
    public Scripture(Reference reference, string passageComplete)
    {
        _reference = reference;
        _passageComplete = this.converter(passageComplete);
    }
    public string GetPassageComplete()
    {
        string passageCompleteReturn = "";
        foreach (Word word in _passageComplete)
        {
            passageCompleteReturn += word.GetWord() + " ";
        }
        return passageCompleteReturn;
    }

    public bool SetPassageComplete()
    {
        Random random = new Random();
        int randomGenerator = random.Next(0, _passageComplete.Count() - 1);
        List<int> indexes = new List<int>();
        for (int i = 0; i <= randomGenerator; i++)
        {
            indexes.Add(random.Next(0, _passageComplete.Count()));
        }
        foreach (int index in indexes)
        {
            _passageComplete[index].SetShow();
        }
        return this.isComplete();
    }
    public bool isComplete()
    {
        var complete = _passageComplete.Where(x => x._show);
        return complete.Count() == 0;
    }

    public Reference GetReference()
    {
        return _reference;
    }
    public void SetReference(Reference reference)
    {
        _reference = reference;
    }
    public string passageScripture()
    {
        return $"{_reference.GetReferenceString()} " + this.GetPassageComplete();
    }

    private List<Word> converter(string passageComplete)
    {
        List<Word> wordsToReturn = new List<Word>();
        string[] listOfWords = passageComplete.Split(" ");
        foreach (string word in listOfWords)
        {
            wordsToReturn.Add(new Word(word));
        }
        return wordsToReturn;
    }

}
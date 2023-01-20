public class Word
{
    private string _word;
    public bool _show;

    public Word(string word)
    {
        _word = word;
        _show = true; //false
    }

    public string GetWord()
    {
        if (_show)
        {
            return _word;
        }
        else
        {
            int length = _word.Length;
            string dashes = "";
            for (int i = 0; i < _word.Length; i++)
            {
                dashes += "_ ";
            }
            return dashes;
        }

    }
    public void SetWord(string word)
    {
        _word = word;
    }
    public void SetShow()
    {
        _show = false;
    }

}
using System.Xml;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public  Reference GetReference()
    {
        return _reference;
    }
    public void SetReference( Reference reference )
    {
        _reference = reference;

    }
    public List<Word> GetList()
    {
        return _words;
    }
    public void SetWords(Word word)
    {
        _words.Add(word);

    }
    public void HideRamdomWords(int numberToHide)
    {
        int numberComponents = _words.Count;


    }
/*     public string GetDisplayText()
    {

    }
    public bool IsCompletelyHidden()
    {
        
    } */

}
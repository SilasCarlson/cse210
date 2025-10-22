using System.Net.Mime;

class Word
{
    private bool _isHidden = false;
    private string _content;

    public Word(string content)
    {
        _content = content;
    }

    public string GetContent()
    {
        if (_isHidden)
        {
            return new string('_', _content.Length);
        }
        else
        {
            return _content;
        }
    }

    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }
}
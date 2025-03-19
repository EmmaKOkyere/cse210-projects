public class Word  
{  
    private string _text;     
    private bool _isHidden;   // A flag indicating whether the word is hidden  

    public Word(string text)  
    {  
        _text = text;  
        _isHidden = false; // Default to visible  
    }  

    public void Hide()  
    {  
        _isHidden = true;  
    }  

    public void Show()  
    {  
        _isHidden = false;  
    }  

    public bool IsHidden()  
    {  
        return _isHidden;  
    }  

    public string GetDisplayText()  
    {  
        return _isHidden ? "_____" : _text; // Return underscores if hidden  
    }  
}
class Library

{
    public string Author;
    public string Subject;
    public string Books;
    public string Category;
    public string subject
    {
        get
        {
            return Subject;
        }        
        set
        {
            if (value.Length > 3)
            {
                subject = value;
            }
            
        }    

    }


}
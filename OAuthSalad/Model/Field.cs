namespace OAuthSalad.Model;

public class Field
{
    public Field(string id, string value)
    {
        Id = id;
        Value = value;
    }
    
    public string Id { get; }
    public string Value { get; }
}
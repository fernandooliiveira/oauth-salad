using System.Text.Json.Serialization;

namespace OAuthSalad.Model;

public class Form
{
    public Form(List<Field> fields)
    {
        FormFields = fields;
    }
    
    [JsonPropertyName("formFields")]
    public List<Field> FormFields { get; }
}
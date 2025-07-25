using GitArApi.Common.Mongo.Constants;

namespace GitArApi.AuthServiceApi.Documents;

public class User : IDocument
{
    public string? Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? UserName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? PasswordSalt { get; set; }
}
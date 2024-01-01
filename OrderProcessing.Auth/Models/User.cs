namespace OrderProcessing.Auth.Models
{
    public record User
    {
        public User(string _Username, string _Password, string _Role, string[] _Scopes)
        {
            Username = _Username;
            Password = _Password;
            Role = _Role;
            Scopes = _Scopes;
        }

        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string[]? Scopes { get; set; }
    }
}

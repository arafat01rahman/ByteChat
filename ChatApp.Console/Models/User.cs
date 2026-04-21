
namespace ChatApp.Console.Models
{
    public class User
    {
        public string Username { get; set; }
        public int UserId { get; set; }
        public bool IsOnline { get; set; }
        public ConnectionStatus Status { get; set; }

        public User(string username, int userId)
        {
            Username = username;
            UserId = userId;
            IsOnline = true;
        }

        public override string ToString()
        {
            return $"{Username} - {Status}";
        }
    }
}
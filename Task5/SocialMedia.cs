

using System.Xml.Linq;

namespace Task5
{
    internal class SocialMedia
    {
        public Dictionary<string, List<string>> Friends { get;  }

  
        public SocialMedia()
        {
            Friends = new Dictionary<string, List<string>>();
        }

        // 5.1: Arkadaş eklemek
        public void AddFriend(string username, string friendUsername)
        {
            if (!Friends.ContainsKey(username))
            {
                Friends[username] = new List<string>();
            }

            if (!Friends[username].Contains(friendUsername))
            {
                Friends[username].Add(friendUsername);
            }
        }

     
        public void RemoveFriend(string username, string friendUsername)
        {
            if (Friends.ContainsKey(username))
            {
                Friends[username].Remove(friendUsername);
            }
        }

       
        public List<string> GetAllFriendsByUsername(string username)
        {
            return Friends.GetValueOrDefault(username);
        }
    }
}

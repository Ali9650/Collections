namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SocialMedia socialMedia = new SocialMedia();
            socialMedia.AddFriend("Alik", "Namiq");
            socialMedia.AddFriend("Alik", "Musviq");
            var data = socialMedia.GetAllFriendsByUsername("Alik");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}

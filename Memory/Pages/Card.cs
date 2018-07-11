namespace Memory.Pages
{
    public class Card
    {
        public string ImageUrl { get; }
        public int Id { get; }

        public Card(string imageUrl, int id)
        {
            ImageUrl = imageUrl;
            Id = id;
        }
    }
}

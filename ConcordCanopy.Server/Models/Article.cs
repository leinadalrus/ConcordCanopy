namespace ConcordCanopy.Server.Models
{
    public class Article
    {
        public Int32 Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Author { get; set; }
        public DateOnly PublicationDate { get; set; }

        public Article(int id, String title, String description, String author)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
        }
    }
}

namespace ConcordCanopy.Server.Models
{
    public class Article
    {
        public Article(UInt16 id, String title, String description, String author)
        {
            ID = id;
            Title = title;
            Description = description;
            Author = author;
        }

        UInt16 ID
        {
            get; set;
        }

        String Title
        {
            get; set;
        }

        String Description
        {
            get; set;
        }

        String Author
        {
            get; set;
        }

        DateOnly PublicationDate
        {
            get; set;
        }
    }
}

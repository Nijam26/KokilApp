using System.ComponentModel.DataAnnotations;

namespace KokilApp.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public string? ImageUrl { get; set; }
        public int NrOfReports { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        //Forein Key
        public int UserId { get; set; }

        //Navigation Property
        public User User { get; set; }

    }
}

using System;

namespace QuipVid.WWW.Models
{
    public class Quip
    {
        public string QuipId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public string Poster { get; set; }
        public string OmdbId { get; set; }
        public string Script { get; set; }
        public bool IsPublished { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}
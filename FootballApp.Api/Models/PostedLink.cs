using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApp.Api.Models
{
    public class PostedLink
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Url { get; private set; }
        public string Description { get; private set; }
        public int Votes { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        // TODO: comments
        // TODO: author

        private PostedLink()
        {
        }

        private PostedLink(string title, string url, string description)
        {
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
            Description = description;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public static PostedLink Create(string title, string url, string description)
            => new PostedLink(title, url, description);
    }
}

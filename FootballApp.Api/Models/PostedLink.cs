using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApp.Api.Models
{
    public class PostedLink
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public int Votes { get; set; }
        // TODO: comments
        // TODO: author
    }
}

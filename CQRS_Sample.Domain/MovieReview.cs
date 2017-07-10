using SimpleCqrs.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Sample.Domain
{
    public class MovieReview : AggregateRoot
    {
        public string Content { get; set; }
        public string Reviewer { get; set; }
        public string Publication { get; set; }

        public MovieReview(Guid reviewId, string content, string reviewer, string publication)
        {
            
        }
    }
}

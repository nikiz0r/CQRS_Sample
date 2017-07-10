using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CQRS_Sample.Application.ReadModel
{
    [Table("Movie")]
    public partial class Movie
    {
        public Movie()
        {
            MovieReviews = new HashSet<MovieReview>();
        }

        public Guid Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RunningTimeMinutes { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<MovieReview> MovieReviews { get; set; }
    }
}

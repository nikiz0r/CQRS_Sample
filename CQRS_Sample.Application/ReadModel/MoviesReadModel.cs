using System.Data.Entity;

namespace CQRS_Sample.Application.ReadModel
{
    public partial class MoviesReadModel : DbContext
    {
        public MoviesReadModel() : base("name=MoviesReadModel")
        {
        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MovieReview> MovieReviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasMany(e => e.MovieReviews)
                .WithRequired(e => e.Movie)
                .WillCascadeOnDelete(false);
        }
    }
}

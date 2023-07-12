using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface IReviewRepository
{
    public IEnumerable<Review> GetAllReviews();
    public IEnumerable<Review> GetReviewsByProgramId(int programId);
    public Review? GetReview(int programId, long learnerId);
    public void AddReview(Review review);
    public void UpdateReview(Review review);
    public void DeleteReview(Review review);
}

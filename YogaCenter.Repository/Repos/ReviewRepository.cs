using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class ReviewRepository : IReviewRepository
{
    public IEnumerable<Review> GetAllReviews() => ReviewDAO.Instance.GetAll();
    public IEnumerable<Review> GetReviewsByProgram(int programId) => ReviewDAO.Instance.GetByProgram(programId);
    public Review? GetReview(int programId, long learnerId) => ReviewDAO.Instance.Get(programId, learnerId);
    public void AddReview(Review review) => ReviewDAO.Instance.Add(review);
    public void UpdateReview(Review review) => ReviewDAO.Instance.Update(review);
    public void DeleteReview(int programId, long learnerId) => ReviewDAO.Instance.Remove(programId, learnerId);
}

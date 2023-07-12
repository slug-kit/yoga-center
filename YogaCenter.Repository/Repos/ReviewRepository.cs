using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class ReviewRepository : IReviewRepository
{
    public IEnumerable<Review> GetAllReviews() => ReviewDAO.Instance.GetAll();
    public IEnumerable<Review> GetReviewsByProgramId(int programId) => ReviewDAO.Instance.GetByProgramId(programId);
    public Review? GetReview(int programId, long learnerId) => ReviewDAO.Instance.Get(programId, learnerId);
    public void AddReview(Review review) => ReviewDAO.Instance.Add(review);
    public void UpdateReview(Review review)
    {
        throw new NotImplementedException();
    }
    public void DeleteReview(Review review)
    {
        throw new NotImplementedException();
    }
}

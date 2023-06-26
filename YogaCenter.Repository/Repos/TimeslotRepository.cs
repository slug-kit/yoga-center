using YogaCenter.Repository.DAL;
using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public class TimeslotRepository : ITimeslotRepository
{
    public IEnumerable<Timeslot> GetTimeslots() => TimeslotDAO.Instance.GetAll();
}

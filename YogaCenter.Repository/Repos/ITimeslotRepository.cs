using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.Repos;

public interface ITimeslotRepository
{
    public IEnumerable<Timeslot> GetTimeslots();
}

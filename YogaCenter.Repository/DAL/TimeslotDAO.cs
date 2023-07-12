using YogaCenter.Repository.Models;

namespace YogaCenter.Repository.DAL;

public class TimeslotDAO
{
    private static TimeslotDAO? instance;
    private readonly static object instanceLock = new();
    public static TimeslotDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                instance ??= new TimeslotDAO();
                return instance;
            }
        }
    }

    private TimeslotDAO() { }

    public IEnumerable<Timeslot> GetAll()
    {
        using var db = new YogaCenterContext();
        return db.Timeslots.ToList();
    }
}

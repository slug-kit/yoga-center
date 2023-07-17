using System.Collections;
using YogaCenter.Repository.Models;

namespace YogaCenterWinApp_Group9.DisplayModels;

public static class CourseStatus
{
    public static CourseStatusNames StatusNames { get; } = new();

    public class CourseStatusNames : IEnumerable<StatusIdNamePair>
    {
        private static Dictionary<int, string> StatusNames { get; set; } = new Dictionary<int, string>()
        {
            { -1, "<COULD NOT BE DETERMINED>" },
            { 0, "Schedule Not Set" },
            { 1, "Registration Dates Pending" },
            { 2, "Registration Not Open Yet" },
            { 3, "Registration Open" },
            { 4, "Registration Closed; Ready to Start" },
            { 5, "Course In Progress" },
            { 6, "Course Finished" },
        };

        public string this[int index]
        {
            get => StatusNames[index];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerator<StatusIdNamePair> GetEnumerator()
        {
            foreach (var statusName in StatusNames)
            {
                yield return new StatusIdNamePair
                {
                    StatusId = statusName.Key,
                    StatusName = statusName.Value
                };
            }
        }
    }

    public struct StatusIdNamePair
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }
}

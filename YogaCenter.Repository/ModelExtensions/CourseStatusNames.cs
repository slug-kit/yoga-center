using System.Collections;

namespace YogaCenter.Repository.ModelExtensions;

public static class CourseStatus
{
    public static CourseStatusNames StatusNames { get; } = new();

    public class CourseStatusNames : IEnumerable<StatusIdNamePair>
    {
        private static Dictionary<int, string> StatusNames { get; set; } = new Dictionary<int, string>()
        {
            { -1, "<COULD NOT BE DETERMINED>" },

            { 0, "Dates Not Set" },
            { 1, "Dates Not Set - Instructor Pending" },
            { 2, "Dates Not Set - Instructor Assigned" },

            { 10, "Registration Dates Pending" },
            { 11, "Registration Dates Pending - Instructor Pending" },
            { 12, "Registration Dates Pending - Instructor Assigned" },

            { 20, "Registration Not Open Yet" },
            { 21, "Registration Not Open Yet - Instructor Pending" },
            { 22, "Registration Not Open Yet - Instructor Assigned" },

            { 30, "Registration Open" },
            { 31, "Registration Open - Instructor Pending" },
            { 32, "Registration Open - Instructor Assigned" },

            { 40, "Registration Closed - Ready to Start" },
            { 41, "Registration Closed - Instructor Pending" },
            { 42, "Registration Closed - Instructor Assigned" },

            { 50, "*** Course In Progress ***" },
            { 51, "<YOU SHOULDN'T BE SEEING THIS>" },
            { 52, "Course In Progress" },
            
            { 60, "Course On Hold" },
            { 61, "<CANNOT START> - No Instructor" },
            { 62, "<CANCELLED> - Registration Issues" },

            { 70, "*** Course Has Finished ***" },
            { 71, "<YOU SHOULDN'T BE SEEING THIS>" },
            { 72, "Course Finished" },
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

using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2024May
{
    public class KinderGarden
    {
        private List<Kid> kids;

        public KinderGarden()
        {
            kids = new List<Kid>();
        }
        
        public bool isKidIdContained(string id)
        {
            return kids.Any(k => k.Id == id);
        }

        public void EnrollKid(Kid kid)
        {
            kids.Add(kid);
            Console.WriteLine($"The child {kid.FirstName} {kid.LastName} is enrolled");
        }

        public void ReleaseKid(string id)
        {
            var currKid = kids
                .FirstOrDefault(k => k.Id == id);

            if (currKid != null)
            {
                kids.Remove(currKid);
                Console.WriteLine($"The child {currKid.FirstName} {currKid.LastName} has been unsubscribed.");
            }
            else
            {
                Console.WriteLine($"Unsubscribe failed - invalid identifier {id}.");
            }
        }

        public void GroupInfo(string group) 
        {
            var groupKidsCount = kids
                .Where(k=>k.Group == group)
                .Count();

            var groupKids = kids
                .Where(k => k.Group == group)
                .OrderBy(k => k.FirstName)
                .ThenBy(k => k.LastName);

            var sb = new StringBuilder();

            sb.AppendLine($"{group} group - {groupKidsCount} children");

            foreach(var kid in groupKids)
            {
                sb.AppendLine($"{kid.FirstName} {kid.LastName}, {kid.Age}, {kid.ParentGSM} ({kid.ParentLastName})");
            }


            Console.WriteLine(sb.ToString());
        }
    }
}

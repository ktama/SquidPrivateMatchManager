using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquidPrivateMatchManager
{
    public class Team
    {
        public ObservableCollection<TeamMember> Members = new ObservableCollection<TeamMember>();

        public string MembersNames
        {
            get
            {
                var names = string.Empty;
                foreach(var member in Members)
                {
                    names += member.Name + " ";
                }
                return names;
            }
        }

        public Team(string memberName1, string memberName2, string memberName3, string memberName4)
        {
            AddMember(memberName1);
            AddMember(memberName2);
            AddMember(memberName3);
            AddMember(memberName4);
        }

        public Team(TeamMember member1, TeamMember member2, TeamMember member3, TeamMember member4)
        {
            AddMember(member1);
            AddMember(member2);
            AddMember(member3);
            AddMember(member4);
        }

        public void AddMember(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Members.Add(new TeamMember(name));
            }
        }

        public void AddMember(TeamMember member)
        {
            if (member != null)
            {
                Members.Add(member);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquidPrivateMatchManager
{
    public class TeamMember
    {
        public string Name { get; set; }
        // Weaponなども持てるようにクラス作成

        public TeamMember(string name)
        {
            this.Name = name;
        }
    }
}

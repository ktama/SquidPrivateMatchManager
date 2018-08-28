
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

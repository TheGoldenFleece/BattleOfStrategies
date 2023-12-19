using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BattleOfStrategies.Models {
    public class MilitaryUnit {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Range { get; set; }
        public int Level { get; set; } = 1;
        public float Damage { get; set; }
        public float HP { get; set; }
        public float Aim { get; set; }
        [DisplayName("Affected Area")]
        public int AffectedArea { get; set; }
    }
}

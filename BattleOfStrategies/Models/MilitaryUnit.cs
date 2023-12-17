using System.ComponentModel.DataAnnotations;

namespace BattleOfStrategies.Models {
    public class MilitaryUnit {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public float Range { get; set; }
        public int Level { get; set; } = 1;
        public float Damage { get; set; }
        public float HP { get; set; }
        [Range(0f, 1f)]
        public float Aim { get; set; }
        public float AffectedArea { get; set; }
    }
}

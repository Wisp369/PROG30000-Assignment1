namespace Assignment1.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public EquipmentType EquipmentType { get; set; }

        public string Description { get; set; }
        public bool IsAvailable { get; set; }
    }
}

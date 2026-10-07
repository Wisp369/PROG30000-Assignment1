using Assignment1.Models;

namespace Assignment1.Repositories
{
    public class EquipmentRepository
    {
        private static List<Equipment> _equipment = new List<Equipment>
      {
        new Equipment { Id = 0, EquipmentType = EquipmentType.Laptop, Description = "Laptop", IsAvailable = true },
        new Equipment { Id = 1, EquipmentType = EquipmentType.Phone, Description = "Phone", IsAvailable = true },
        new Equipment { Id = 2, EquipmentType = EquipmentType.Phone, Description = "Phone", IsAvailable = true },
        new Equipment { Id = 3, EquipmentType = EquipmentType.Laptop, Description = "Laptop", IsAvailable = true },
        new Equipment { Id = 4, EquipmentType = EquipmentType.Tablet, Description = "Tablet", IsAvailable = true },
        new Equipment { Id = 5, EquipmentType = EquipmentType.Laptop, Description = "Laptop", IsAvailable = true },
        new Equipment { Id = 6, EquipmentType = EquipmentType.Laptop, Description = "Laptop", IsAvailable = false },
        new Equipment { Id = 7, EquipmentType = EquipmentType.Phone, Description = "Phone", IsAvailable = false },
        new Equipment { Id = 8, EquipmentType = EquipmentType.Other, Description = "Projector", IsAvailable = true },
        new Equipment { Id = 9, EquipmentType = EquipmentType.Tablet, Description = "Tablet", IsAvailable = false },
      };

        public List<Equipment> GetAllEquipment()
        {
            return _equipment;
        }
    }
}

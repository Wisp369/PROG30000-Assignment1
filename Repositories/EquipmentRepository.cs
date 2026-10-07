using Assignment1.Models;

namespace Assignment1.Repositories
{
    public class EquipmentRepository
    {
        private static List<Equipment> _equipment = new List<Equipment>
      {
        new Equipment { EquipmentType = EquipmentType.Laptop, IsAvailable = true },
        new Equipment { EquipmentType = EquipmentType.Phone, IsAvailable = true },
        new Equipment { EquipmentType = EquipmentType.Phone, IsAvailable = true },
        new Equipment { EquipmentType = EquipmentType.Laptop, IsAvailable = true },
        new Equipment { EquipmentType = EquipmentType.Tablet, IsAvailable = true },
        new Equipment { EquipmentType = EquipmentType.Laptop, IsAvailable = true },
        new Equipment { EquipmentType = EquipmentType.Laptop, IsAvailable = false },
        new Equipment { EquipmentType = EquipmentType.Phone, IsAvailable = false },
        new Equipment { EquipmentType = EquipmentType.Other, IsAvailable = true },
        new Equipment { EquipmentType = EquipmentType.Tablet, IsAvailable = false },
      };

        public List<Equipment> GetAllEquipment()
        {
            return _equipment;
        }
    }
}

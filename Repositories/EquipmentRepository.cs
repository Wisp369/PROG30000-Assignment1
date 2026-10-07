using Assignment1.Models;

namespace Assignment1.Repositories
{
    public class EquipmentRepository
    {
        private static List<Equipment> _equipment = new List<Equipment>
      {
        new Equipment { EquipmentType = EquipmentType.LAPTOP, IsAvailable = true },
        new Equipment { EquipmentType = EquipmentType.PHONE, IsAvailable = true },
        new Equipment { EquipmentType = EquipmentType.PHONE, IsAvailable = true },
        new Equipment { EquipmentType = EquipmentType.LAPTOP, IsAvailable = true },
        new Equipment { EquipmentType = EquipmentType.TABLET, IsAvailable = true },
        new Equipment { EquipmentType = EquipmentType.LAPTOP, IsAvailable = true },
        new Equipment { EquipmentType = EquipmentType.LAPTOP, IsAvailable = false },
        new Equipment { EquipmentType = EquipmentType.PHONE, IsAvailable = false },
        new Equipment { EquipmentType = EquipmentType.OTHER, IsAvailable = true },
        new Equipment { EquipmentType = EquipmentType.TABLET, IsAvailable = false },
      };

        public List<Equipment> GetAllEquipment()
        {
            return _equipment;
        }
    }
}

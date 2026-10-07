using Assignment1.Repositories;

namespace Assignment1.Service
{
    public static class EquipmentService
    {
        public static EquipmentRepository Equipment { get; set; } = new EquipmentRepository();
        public static EquipmentRequestRepository EquipmentRequest { get; set; } = new EquipmentRequestRepository();
    }
}

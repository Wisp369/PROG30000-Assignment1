using Assignment1.Models;

namespace Assignment1.Repositories
{
    public class EquipmentRequestRepository
    {
        private EquipmentRepository _equipmentRepository = new EquipmentRepository();
        private static List<EquipmentRequest> _requests = new List<EquipmentRequest>();

        public void AddRequest(EquipmentRequest newRequest)
        {
            var availableEquipment = _equipmentRepository.GetAllEquipment().FirstOrDefault(e => e.EquipmentType == newRequest.EquipmentType && e.IsAvailable);
            if (availableEquipment != null)
            {
                availableEquipment.IsAvailable = false;
                _requests.Add(newRequest);
            }
        }
    }
}

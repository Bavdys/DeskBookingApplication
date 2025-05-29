namespace DeskBooking.Domain.Entities
{
    public class WorkspaceCapacity
    {
        public int Availability { get; set; }

        public int WorkspaceId { get; set; }
        public int CapacityId { get; set; }

        public Workspace Workspace { get; set; }
        public Capacity Capacity { get; set; }
    }
}
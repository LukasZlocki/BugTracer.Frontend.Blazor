using BugTracer.Frontend.Blazor.DTOs;

namespace BugTracer.Frontend.Blazor.ViewModels
{
    public class TicketDetailsVM
    {
        public TicketReadDto Ticket { get; set; }
        public ResourceReadDto Resource { get; set; }
        public TicketPriorityReadDto Priority { get; set; }
        public TicketStatusReadDto TicketStatus { get; set; }

        public TicketDetailsVM(TicketReadDto ticket, ResourceReadDto resource, TicketPriorityReadDto priority, TicketStatusReadDto status)
        {
            Ticket = ticket;
            Resource = resource;
            Priority = priority;
            TicketStatus = status;
        }
    }
}

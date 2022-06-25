 using BugTracer.Frontend.Blazor;
using BugTracer.Frontend.Blazor.DTOs;


namespace BugTracer.Frontend.Blazor.ViewModels
{
    public class ProjectTicketsViewModel
    {
        public ProjectBasicReadDto  ProjectBasicDataReadDto { get; set; } = new ProjectBasicReadDto();
        public List<TicketReadDto> ProjectTicketsReadDto { get; set; } = new List<TicketReadDto>();

        //  CONSTR
        public ProjectTicketsViewModel()
        {

        }

        // constructor
        public ProjectTicketsViewModel(ProjectBasicReadDto project, List<TicketReadDto> ticketsList)
        {
            ProjectBasicDataReadDto = project;
            ProjectTicketsReadDto = ticketsList;
        }


    }
}

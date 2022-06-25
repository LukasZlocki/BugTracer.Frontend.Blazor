namespace BugTracer.Frontend.Blazor.DTOs
{
    public class ResourceReadDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int ResourceRoleId { get; set; }
        // public ResourceRoleReadDto RoleReadDto { get; set; }  <- add this if needed
    }
}

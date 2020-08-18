namespace  pipelines_dotnet_core_docker.Models
{
    public class CustomerModel
    {
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
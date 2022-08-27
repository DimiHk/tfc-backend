namespace DimiHWM.Domain.Entities
{
    public class Teacher
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string NIF { get; set; }
    }
}
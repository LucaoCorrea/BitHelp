using BitHelpAPI.Enum;

namespace BitHelpAPI.Dto
{
    public class UserRegisterDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole UserRole { get; set; } = UserRole.User; // Default 
    }
}

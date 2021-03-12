namespace dnc.Dtos.User
{
    public class UserRegisterDto {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UserLoginDto {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
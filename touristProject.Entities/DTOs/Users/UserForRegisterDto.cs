namespace touristProject.Entities.DTOs.Users
{
    public class UserForRegisterDto
    {
        //Sisteme kayıt olmak için oluşturulmuş Dto nesnesidir.

        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

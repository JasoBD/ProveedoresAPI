namespace ProveedoresApi.Models
{
    public class UserToken
    {
        public string? Username { get; set; }
        public string? Password { get; set; }


        public static List<UserToken> Usuariodb()
        {
            var list = new List<UserToken>() {

                new UserToken
                {
                    Username ="Jaondres",
                    Password="12345"
                }
            };
            return list;
        }
    }
}

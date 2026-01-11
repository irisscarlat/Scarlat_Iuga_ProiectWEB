namespace Scarlat_Iuga_ProiectWEB.Models
{
    public class UserSession
    {
        public static bool IsAuthenticated { get; set; } = false;
        public static string Role { get; set; } = "User";
    }
}

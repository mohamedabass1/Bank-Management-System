namespace BankSystemProjectWinfosForm
{

    static public class clsGolobalCurrentUser
    {
        public static int UserID = -1;
        public static string UserName = "";
        public static string Password = "";
        public static int Permissions = 0;
        public static string ImagePath = "";

        public static void Clear()
        {
            UserID = -1;
            UserName = "";
            Permissions = 0;
            Password = "";
            ImagePath = "";
        }
    }
}

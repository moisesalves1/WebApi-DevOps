namespace Blog
{
    public static class Configuration
    {
        public static string JwtKey = "ZmVkYWY3ZDg4NjNiNDh1MTk3YjkyODdkNDkyYjcwOGU=";
        public static string ApiKeyName = "api_key";
        public static string ApiKey = "curso_api_ILTevUK/0ey3NaCV/un8g=";
        public static SmtpConfiguration Smtp = new();

        public class SmtpConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; } = 25;
            public string UserName { get; set; }
            public string Password { get; set; }
        }


    }
}

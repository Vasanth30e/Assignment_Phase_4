namespace LoginLib
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string LoginMethod()
        {
            if (string.IsNullOrWhiteSpace(Username) && string.IsNullOrWhiteSpace(Password))
            {
                throw new ArgumentException("Both username and password are empty or null.");
            }
            else if (string.IsNullOrWhiteSpace(Username))
            {
                throw new ArgumentException("Username is empty or null.");
            }
            else if (string.IsNullOrWhiteSpace(Password))
            {
                throw new ArgumentException("Password is empty or null.");
            }
            else if (Username == "Sam" && Password == "sam@123")
            {
                return "Login Successful";
            }
            else
            {
                return "Login Failed";
            }
        }
    }
}
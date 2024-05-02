using BiByt.Database;
using AppContext = BiByt.Database.AppContext;

namespace BiByt.Utils;

public static class Registration
{
    public static bool IsUsernameAvailable(string username)
    {
        using (AppContext context = new AppContext())
            return context.Set<User>().Any(u => u.Username == username);
    }

    public static bool IsPasswordValid(string password)
    {
        return password.Length >= 6 && password.Any(char.IsDigit) && password.Any(char.IsUpper) &&
               password.Any(char.IsLower) && password.All(char.IsLetterOrDigit);
        // return Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s)(?=.*[^\da-zA-Z]).{6,}$");
    }
}

public static class Login
{
    public static bool IsCredentialsValid(string username, string password)
    {
        using (AppContext context = new AppContext())
            return context.Set<User>().Any(u => u.Username == username && u.Password == password);
    }
}
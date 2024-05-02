using BiByt.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

//public class User
//{
//    public long Id { get; set; }
//    public string Username { get; set; }
//    public string Password { get; set; }
//}

//public class ApplicationContext
//{
//    public void SaveChanges() { }
//    public IQueryable<User> Users { get; }
//}

public class Registration
{
    //private readonly ApplicationContext _context;

    //public Registration(ApplicationContext context)
    //{
    //    _context = context;
    //}

    public bool IsUsernameAvailable(string username)
    {
        using (BiByt.Database.ApplicationContext context = new BiByt.Database.ApplicationContext())
            return context.Set<User>().Any(u => u.Username == username);
        //return !Query.Get<Users>(u => u.Username == username);
        //return !_context.Users.Any(u => u.Username == username);
    }

    public bool IsPasswordValid(string password)
    {
        // Проверка длины пароля
        if (password.Length < 6)
            return false;

        // Проверка наличия хотя бы одной цифры
        if (!password.Any(char.IsDigit))
            return false;

        // Проверка наличия хотя бы одного специального символа
        if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            return false;

        // Проверка наличия хотя бы одной заглавной или строчной буквы
        if (!password.Any(char.IsUpper) && !password.Any(char.IsLower))
            return false;

        return true;
    }

    public void RegisterUser(string username, string password)
    {
        if (!IsUsernameAvailable(username))
        {
            Console.WriteLine("Такой логин уже зарегистрирован.");
            return;
        }

        if (!IsPasswordValid(password))
        {
            Console.WriteLine("Пароль не соответствует требованиям.");
            return;
        }

        using (BiByt.Database.ApplicationContext context = new BiByt.Database.ApplicationContext())
        {
            var newUser = new User { Username = username, Password = password };
            context.Set<User>().Add(newUser);
            context.SaveChanges();
        }
        Console.WriteLine("Пользователь успешно зарегистрирован.");
    }
}

class Programm
{
    static void Mainn(string[] args)
    {
        //var context = new ApplicationContext();
        var registration = new Registration();

        Console.WriteLine("Введите логин:");
        string username = Console.ReadLine();

        Console.WriteLine("Введите пароль:");
        string password = Console.ReadLine();

        registration.RegisterUser(username, password);
    }
}
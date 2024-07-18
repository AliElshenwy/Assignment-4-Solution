namespace Assignment_4
{

    #region Question 
    //Q-1 =>B
    //Q-2 =>A
    //Q-3 =>B
    //Q-4 =>B
    //Q-5 =>A
    //Q-6 =>A
    //Q-7 =>B
    //Q-8 =>A
    //Q-9 =>B
    //Q-10 =>C
    #endregion





    /*#region Q_1

    public interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }

    public interface ICircle : IShape
    {
        double Radius { get; set; }
    }

    public interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }

    public class Circle : ICircle
    {
        public double Radius { get; set; }

        public double Area => Math.PI * Radius * Radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Circle\nRadius: {Radius}\nArea: {Area:F2}");
        }
    }

    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area => Width * Height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Rectangle\nWidth: {Width}\nHeight: {Height}\nArea: {Area:F2}");
        }
    }

    internal class Program
    {
        static void Main()
        {
            ICircle circle = new Circle { Radius = 5 };
            circle.DisplayShapeInfo();

            IRectangle rectangle = new Rectangle { Width = 4, Height = 6 };
            rectangle.DisplayShapeInfo();
        }
    } 
    #endregion
    */

    /*#region Q_2 
    using System;
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }

    public class BasicAuthenticationService : IAuthenticationService
    {
        private readonly Dictionary<string, string> _users = new Dictionary<string, string>
    {
        { "user1", "password1" },
        { "user2", "password2" }
    };

        private readonly Dictionary<string, List<string>> _userRoles = new Dictionary<string, List<string>>
    {
        { "user1", new List<string> { "admin", "user" } },
        { "user2", new List<string> { "user" } }
    };

        public bool AuthenticateUser(string username, string password)
        {
            return _users.TryGetValue(username, out var storedPassword) && storedPassword == password;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return _userRoles.TryGetValue(username, out var roles) && roles.Contains(role);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IAuthenticationService authService = new BasicAuthenticationService();

            string username = "user1";
            string password = "password1";
            string role = "admin";
            bool isAuthenticated = authService.AuthenticateUser(username, password);
            bool isAuthorized = authService.AuthorizeUser(username, role);

            Console.WriteLine($"Is {username} authenticated? {isAuthenticated}");
            Console.WriteLine($"Is {username} authorized as {role}? {isAuthorized}");
        }
    }

    #endregion
    */





}



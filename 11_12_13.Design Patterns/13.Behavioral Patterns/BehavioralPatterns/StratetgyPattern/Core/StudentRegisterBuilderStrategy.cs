using StratetgyPattern.Abstractions;

namespace StratetgyPattern.Core
{
    public class StudentRegisterBuilderStrategy : IRegisterBuilderStrategy, IRegister
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public void Register(string username, string password)
        {
            Console.WriteLine("Welcome Student");
        }
    }
}

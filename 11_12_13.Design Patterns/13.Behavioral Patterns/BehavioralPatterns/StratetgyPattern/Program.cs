using BehavioralPatterns.Domain;
using BehavioralPatterns.ExtensionMethods;
using StratetgyPattern.Core;


var loginContext = new RegisterBuilderContext();
Console.WriteLine("Select one role to regsiter in app");
Console.WriteLine("1. Admin\n2.Student\n3.Teacher\n4.Customer");
var selectType = Console.ReadLine();
Console.WriteLine("Your username:");
var username = Console.ReadLine();

Console.WriteLine("Your password:");
var password = Console.ReadLine();

switch (selectType)
{
    case "1": loginContext.SetRegisterStrategy(new AdminRegisterBuilderStrategy() { UserName = username, Password = password });
        break;
    case "2":
        loginContext.SetRegisterStrategy(new StudentRegisterBuilderStrategy() { UserName = username, Password = password });
        break;
    case "3":
        loginContext.SetRegisterStrategy(new TeacherRegisterBuilderStrategy() { UserName = username, Password = password });
        break;
    case "4":
        loginContext.SetRegisterStrategy(new CustomerRegisterBuilderStrategy() { UserName = username, Password = password });
        break;
}


loginContext.Register(username, password);





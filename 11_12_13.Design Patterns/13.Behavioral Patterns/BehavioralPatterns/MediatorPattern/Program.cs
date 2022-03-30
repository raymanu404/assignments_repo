using MediatorPattern.Abstractions;

namespace MediatorPattern
{

    record MessageRequest(string Message) : IRequest; // prin aceasta interfata marcam acest tip de record sa fie IRequest;

    class MessageHandler : IRequestHandler<MessageRequest>
    {
        public void Handle(MessageRequest request)
        {
            Console.WriteLine($"Sending message {request.Message}");
        }
    }


    record NumberRequest(int Number) : IRequest;
    class NumberHandler : IRequestHandler<NumberRequest>
    {
        public void Handle(NumberRequest request)
        {
            File.WriteAllLines("./hello.txt", new string[] { $"Sending number {request.Number}" });
        }
    }


    record ArticleRequest(string Title, string Description, int Number, DateTime DateTime) : IRequest;
    class ArticleHandler : IRequestHandler<ArticleRequest>
    {
        public void Handle(ArticleRequest request)
        {
            Console.WriteLine($"Article Handler: {request.Title} {request.Number}: {request.Description} - {request.DateTime}");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new Mediator();

            mediator.RegisterHandler(typeof(MessageRequest), new MessageHandler());
            mediator.RegisterHandler(typeof(NumberRequest), new NumberHandler());
            mediator.RegisterHandler(typeof(ArticleRequest), new ArticleHandler());

            mediator.Send(new ArticleRequest("Bathman", "Batman in 1999", 223, DateTime.Now));
            mediator.Send(new MessageRequest("some random message"));
            mediator.Send(new NumberRequest(3454));
        }
    }

}
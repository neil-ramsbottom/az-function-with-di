namespace FunctionWithInjection.Services
{
    public class HelloMessageService : IMessageService
    {
        public string GetMessage(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "Hello";
            return $"Hello {name}";
        }
    }
}



public class ApplicationHandler : SupportHandler
{
    protected override bool CanHandle(SupportRequest request)
    {
        return request.Type == RequestType.ApplicationError;
    }

    protected override void Process(SupportRequest request)
    {
        Console.WriteLine(
            $"Обращение номер{request.Id} | " +
            $"Тип: {request.Type} | " +
            "Итоговый обработчик: разработчик приложений");
    }
}
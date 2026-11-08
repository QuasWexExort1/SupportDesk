
public class ServerHandler : SupportHandler
{
    protected override bool CanHandle(SupportRequest request)
    {
        return request.Type == RequestType.ServerProblem;
    }

    protected override void Process(SupportRequest request)
    {
        Console.WriteLine(
            $"Обращение номер{request.Id} | " +
            $"Тип: {request.Type} | " +
            "Итоговый обработчик: системный администратор");
    }
}
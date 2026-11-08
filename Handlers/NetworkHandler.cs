public class NetworkHandler : SupportHandler
{
    protected override bool CanHandle(SupportRequest request)
    {
        return request.Type == RequestType.NetworkProblem;
    }

    protected override void Process(SupportRequest request)
    {
        Console.WriteLine(
            $"Обращение номер{request.Id} | " +
            $"Тип: {request.Type} | " +
            "Итоговый обработчик: сетевой администратор");
    }
}
public class AccountHandler : SupportHandler
{
    protected override bool CanHandle(SupportRequest request)
    {
        return request.Type == RequestType.AccountLogin;
    }

    protected override void Process(SupportRequest request)
    {
        Console.WriteLine(
            $"Обращение номер{request.Id} | " +
            $"Тип: {request.Type} | " +
            "Итоговый обработчик: специалист по аккаунтам");
    }
}
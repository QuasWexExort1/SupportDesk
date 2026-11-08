SupportHandler account = new AccountHandler();
SupportHandler application = new ApplicationHandler();
SupportHandler network = new NetworkHandler();
SupportHandler server = new ServerHandler();

account.SetNext(application)
       .SetNext(network)
       .SetNext(server);

var requests = new List<SupportRequest>
{
    new(1, RequestType.AccountLogin,
        "Не получается войти в аккаунт"),

    new(2, RequestType.ApplicationError,
        "Приложение выдаёт ошибку"),

    new(3, RequestType.NetworkProblem,
        "Нет подключения к Wi-Fi"),

    new(4, RequestType.ServerProblem,
        "Сервер колледжа недоступен"),

    new(5, RequestType.Unknown,
        "Неизвестная ошибка"),

    new(6, RequestType.AccountLogin,
        "Забыт пароль"),

    new(7, RequestType.NetworkProblem,
        "Не работает интернет в аудитории"),

    new(8, RequestType.ApplicationError,
        "Программа неожиданно закрывается")
};

Console.WriteLine("СИСТЕМА SUPPORT DESK\n");

foreach (var request in requests)
{
    account.Handle(request);
}

Console.WriteLine("\nОБРАБОТКА ЗАВЕРШЕНА");
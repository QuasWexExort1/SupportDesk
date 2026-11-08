
public abstract class SupportHandler
{
    private SupportHandler? _nextHandler;

    public SupportHandler SetNext(SupportHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public void Handle(SupportRequest request)
    {
        if (CanHandle(request))
        {
            Process(request);
            return;
        }

        if (_nextHandler != null)
        {
            _nextHandler.Handle(request);
            return;
        }

        ManualReview(request);
    }

    protected abstract bool CanHandle(SupportRequest request);

    protected abstract void Process(SupportRequest request);

    protected virtual void ManualReview(SupportRequest request)
    {
        Console.WriteLine(
            $"Обращение номер{request.Id} | " +
            $"Тип: {request.Type} | " +
            "Итоговый обработчик: ручной разбор");
    }
}
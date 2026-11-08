public class SupportRequest
{
    public int Id { get; }
    public RequestType Type { get; }
    public string Description { get; }

    public SupportRequest(
        int id,
        RequestType type,
        string description)
    {
        Id = id;
        Type = type;
        Description = description;
    }
}
namespace agora.domain;

public static class ExceptionMessages
{
    public static string InvalidPropertyNullEmpty(string property) => $"Invalid property '{property}': cannot be null or empty";
    public static string InvalidProperty(string property, string value) => $"Invalid property '{property}': {value}";
}

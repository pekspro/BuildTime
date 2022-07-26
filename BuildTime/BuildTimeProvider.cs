public static partial class BuildTimeProvider
{
    static BuildTimeProvider()
    {
        Initialize();
    }

    static partial void Initialize();

    public static string? BuildTimeString { get; private set; }

    public static DateTime BuildTime => 
        BuildTimeString is null ? DateTime.MinValue : DateTime.Parse(BuildTimeString);
}

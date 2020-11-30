using System;

public sealed class BuildConfig
{
    public static Type BuildType { get; } = Type.Development;

    public enum Type
    {
        Development,
        Staging,
        Production
    }
}
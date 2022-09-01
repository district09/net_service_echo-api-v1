namespace District09.Echo;

public class PathBaseStartupFilter : IStartupFilter
{
    private readonly string _pathBase;

    public PathBaseStartupFilter(string pathBase)
    {
        _pathBase = pathBase.StartsWith("/") ? pathBase : $"/{pathBase}";
    }

    public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
    {
        return app =>
        {
            app.UsePathBase(_pathBase);
            next(app);
        };
    }
}
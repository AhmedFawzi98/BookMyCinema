namespace BookMyCinema.App.Extensions;

public static class WebApplicationExtensions
{
    public static WebApplication ConfigureWebApplication(this WebApplication app)
    {
        app.UsePresentation();
        app.UseApplication();
        app.UseInfrastructure();
        app.UsePersistance();

        return app;
    }

    private static WebApplication UsePresentation(this WebApplication app)
    {
        app.MapOpenApi();
        app.UseHttpsRedirection();
        app.MapControllers();

        return app;
    }

    private static WebApplication UseApplication(this WebApplication app)
    {
        
        return app;
    }

    private static WebApplication UseInfrastructure(this WebApplication app)
    {

        return app;
    }
    private static WebApplication UsePersistance(this WebApplication app)
    {

        return app;
    }
}

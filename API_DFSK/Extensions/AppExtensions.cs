using API_DFSK.Middlewares;

namespace API_DFSK.Extensions
{

    public static class AppExtensions
    {
        public static void useErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}

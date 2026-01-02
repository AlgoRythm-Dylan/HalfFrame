namespace HalfFrameWeb.Lib.Middleware
{
    public class MachineIdentifierMiddleware
    {
        private readonly RequestDelegate Next;
        public MachineIdentifierMiddleware(RequestDelegate next)
        {
            Next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            string uidKey = "hf_uid";
            if (!context.Request.Cookies.ContainsKey(uidKey))
            {
                var token = Crypto.RandomToken();
                context.Response.Cookies.Append(uidKey, token);
                context.Items[uidKey] = token;
            }
            await Next(context);
        }
    }
}

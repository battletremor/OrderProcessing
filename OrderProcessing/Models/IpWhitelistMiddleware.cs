using System.Net;

namespace OrderProcessing.Models
{
    public class IpWhitelistMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string[]? _allowedIpAddresses;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IpWhitelistMiddleware(RequestDelegate next)
        {
            _next = next ?? throw new ArgumentNullException(nameof(next));
        }

        public IpWhitelistMiddleware(RequestDelegate next, string[] allowedIpAddresses)
        : this(next)
        {
            _allowedIpAddresses = allowedIpAddresses ?? throw new ArgumentNullException(nameof(allowedIpAddresses)) ; 
        }

        public async Task Invoke(HttpContext context)
        {
            var ipAddress = context.Connection.RemoteIpAddress;

            try
            {
                if (IsIpAddressAllowed(ipAddress))
                {
                    await _next(context);
                }
                else
                {
                    context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                    return;
                }
            }
            catch (ArgumentNullException)
            {
                log.Error("ipAddress is null");
            }
            catch(Exception ex)
            {
                log.Error("Error while checking if IP is allowed", ex);
            }
        }

        private bool IsIpAddressAllowed(IPAddress ipAddress)
        {
            try
            {
                return Array.Exists(_allowedIpAddresses, allowedIp => IPAddress.Parse(allowedIp).Equals(ipAddress));
            }
            catch (Exception ex)
            {
                log.Error("Error while checking if IP is allowed",ex);
                return false;
            }

        }
    }
}

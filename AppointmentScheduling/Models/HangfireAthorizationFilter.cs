using Hangfire.Annotations;
using Hangfire.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AppointmentScheduling.Models
{
    public class HangfireAthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize(DashboardContext context)
        {
            //return HttpContext.Current.User.Identity.IsAuthenticated;
            var httpContext = context.GetHttpContext();

            if (!httpContext.User.Identity.IsAuthenticated) httpContext.Response.Redirect("/Account/Login");

            // Allow all authenticated users to see the Dashboard (potentially dangerous).
            return true;// httpContext.User.Identity.IsAuthenticated;

        }
    }
}

using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Filters
{

    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
        public override void OnActionExecuted(ActionExecutedContext filtercontext)
        {
            base.OnActionExecuted(filtercontext);
        }
        public override void OnResultExecuting(ResultExecutingContext filtercontext)
        {
            base.OnResultExecuting(filtercontext);
        }
        public override void OnResultExecuted(ResultExecutedContext filtercontext)
        {
            base.OnResultExecuted(filtercontext);
        }
    }
}

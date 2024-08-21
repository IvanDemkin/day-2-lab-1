using Microsoft.AspNetCore.Mvc.Filters;
using System.Text;
using ControllersProj.Models;

namespace ControllersProj.Filters
{
    public class MyActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            StringBuilder sb = new StringBuilder();
            object? obj = context.ActionArguments.ElementAt(0).Value;
            if (obj != null)
            {
                foreach (var prop in obj.GetType().GetProperties())
                {
                    sb.Append($"{prop.Name} {prop.GetValue(obj, null)}, ");
                }
            }
            Console.WriteLine($"ActionExecuting. Params: {sb.ToString()}");
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;

namespace Webapi.ActionValueBinder.Contrib
{
    public class MultiActionBinder : DefaultActionValueBinder
    {
	    private List<IActionBinding> _bindings;

	    public MultiActionBinder()
	    {
		    _bindings = new List<IActionBinding>();
	    } 
		
		protected override HttpParameterBinding GetParameterBinding(HttpParameterDescriptor parameter)
		{
			var possibleBindings = _bindings.Where(x => x.CanBind(parameter)).ToArray();
			if (possibleBindings.Any())
				return possibleBindings.First().Bind(parameter);

			return base.GetParameterBinding(parameter);
		}

		public void AddBinding(IActionBinding binding)
	    {
		    _bindings.Add(binding);
	    }
    }
}

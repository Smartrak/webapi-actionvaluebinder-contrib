using System.Web.Http.Controllers;

namespace Webapi.ActionValueBinder.Contrib
{
	public interface IActionBinding
	{
		bool CanBind(HttpParameterDescriptor parameter);
		HttpParameterBinding Bind(HttpParameterDescriptor parameter);
	}
}

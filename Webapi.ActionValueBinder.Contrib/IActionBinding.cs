using System.Web.Http.Controllers;

namespace WebApi.ActionValueBinder.Contrib
{
	public interface IActionBinding
	{
		bool CanBind(HttpParameterDescriptor parameter);
		HttpParameterBinding Bind(HttpParameterDescriptor parameter);
	}
}

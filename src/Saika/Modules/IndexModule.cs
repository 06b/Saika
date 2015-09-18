using Nancy;
using Nancy.ModelBinding;
using Nancy.Responses;
using Saika.Models;

namespace Saika.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters => View["index"];


            Get["/vulnerability/"] = parameters => Response.AsRedirect("/vulnerability/new", RedirectResponse.RedirectType.Temporary);
            Get["/vulnerability/new"] = parameters => View["vulnerabilities/manage"];

            Post["/api/vulnerabilities/add"] = parameters =>
            {

                Vulnerabilities Vulnerability = this.Bind<Vulnerabilities>();

                return HttpStatusCode.OK;
            };
        }
    }
}
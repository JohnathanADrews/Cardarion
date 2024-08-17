using CardarionPlugin.Data;
using CardarionPlugin.Routers.Repository.Routes.Request;
using CardarionPlugin.Routers.Repository.Routes.Response;
using HularionCore.Pattern.Functional;
using HularionPlugin.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardarionPlugin.Routers.Repository
{
    public class CardarionRepositoryRouter : IRouteProvider
    {

        public string Name => "Cardarion Mesh Repository Route Provider";

        public string Key => "CardarionMeshRepositoryRouter";

        public string Purpose => "Provides routes for a Cardarion Mesh Repository.";

        public IEnumerable<HularionRoute> Routes => routes;

        private List<HularionRoute> routes { get; set; } = new List<HularionRoute>();

        public string BaseRoute { get; private set; } = string.Format("cardarion/repository/");


        public CardarionRepositoryRouter()
        {

            //Route = string.Format("{0}open", BaseRoute)
            routes.Add(new HularionRoute<OpenRepositoryRequest, OpenRepositoryResponse>()
            {
                Name = "Open Repository",
                Method = "OpenRepository",
                Route = string.Format("{0}open", BaseRoute),
                Usage = "Opens a repository to use.",
                Handler = ParameterizedFacade.FromSingle<RoutedRequest<OpenRepositoryRequest>, RoutedResponse<OpenRepositoryResponse>>(request =>
                {
                    var response = request.CreateResponse<OpenRepositoryResponse>();
                    response.Messages.Add(new RoutedResponseMessage() { Header = "Called OpenRepository" });
                    return response;
                })
            });

            //Route = string.Format("{0}items/get", BaseRoute)
            routes.Add(new HularionRoute<GetItemsRequest, GetItemsResponse>()
            {
                Name = "Get Items",
                Method = "GetItems",
                Route = string.Format("{0}items/get", BaseRoute),
                Usage = "Queries items to provide.",
                Handler = ParameterizedFacade.FromSingle<RoutedRequest<GetItemsRequest>, RoutedResponse<GetItemsResponse>>(request =>
                {
                    var response = request.CreateResponse<GetItemsResponse>();
                    response.Messages.Add(new RoutedResponseMessage() { Header = "Called GetItems" });
                    return response;
                })
            });

            //Route = string.Format("{0}items/create", BaseRoute)
            routes.Add(new HularionRoute<CreateItemsRequest, CreateItemsResponse>()
            {
                Name = "Create Items",
                Method = "CreateItems",
                Route = string.Format("{0}items/create", BaseRoute),
                Usage = "Creates items with the give domain and provides them.",
                Handler = ParameterizedFacade.FromSingle<RoutedRequest<CreateItemsRequest>, RoutedResponse<CreateItemsResponse>>(request =>
                {
                    var response = request.CreateResponse<CreateItemsResponse>();
                    response.Messages.Add(new RoutedResponseMessage() { Header = "Called CreateItems" });
                    return response;
                })
            });

            //Route = string.Format("{0}items/delete", BaseRoute)
            routes.Add(new HularionRoute<DeleteItemsRequest, DeleteItemsResponse>()
            {
                Name = "Delete Items",
                Method = "DeleteItems",
                Route = string.Format("{0}items/delete", BaseRoute),
                Usage = "Deletes items according to the provided query.",
                Handler = ParameterizedFacade.FromSingle<RoutedRequest<DeleteItemsRequest>, RoutedResponse<DeleteItemsResponse>>(request =>
                {
                    var response = request.CreateResponse<DeleteItemsResponse>();
                    response.Messages.Add(new RoutedResponseMessage() { Header = "Called DeleteItems" });
                    return response;
                })
            });

            //Route = string.Format("{0}items/update", BaseRoute)
            routes.Add(new HularionRoute<UpdateItemsRequest, UpdateItemsResponse>()
            {
                Name = "Update Items",
                Method = "UpdateItems",
                Route = string.Format("{0}items/update", BaseRoute),
                Usage = "Updates the provided items.",
                Handler = ParameterizedFacade.FromSingle<RoutedRequest<UpdateItemsRequest>, RoutedResponse<UpdateItemsResponse>>(request =>
                {
                    var response = request.CreateResponse<UpdateItemsResponse>();
                    response.Messages.Add(new RoutedResponseMessage() { Header = "Called UpdateItems" });
                    return response;
                })
            });

        }
    }
}

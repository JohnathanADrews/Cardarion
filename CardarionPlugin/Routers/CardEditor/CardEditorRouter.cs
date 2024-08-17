using CardarionPlugin.Routers.CardEditor.Routes.Request;
using CardarionPlugin.Routers.CardEditor.Routes.Response;
using HularionCore.Pattern.Functional;
using HularionPlugin.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardarionPlugin.Routers.CardEditor
{
    public class CardEditorRouter : IRouteProvider
    {

        public string Name => "Card Editor Route Provider";

        public string Key => "CardEditorRouter";

        public string Purpose => "Provides routes for editing Cardarion cards.";

        public IEnumerable<HularionRoute> Routes => routes;

        private List<HularionRoute> routes { get; set; } = new List<HularionRoute>();

        public string BaseRoute { get; private set; } = string.Format("cardarion/editor/");

        public CardEditorRouter()
        {

            //Route = string.Format("{0}cards/get", BaseRoute)
            routes.Add(new HularionRoute<GetCardsRequest, GetCardsResponse>()
            {
                Name = "Get Cards",
                Method = "GetCards",
                Route = string.Format("{0}cards/get", BaseRoute),
                Usage = "Gets the complete card list or those specified by search or key.",
                Handler = ParameterizedFacade.FromSingle<RoutedRequest<GetCardsRequest>, RoutedResponse<GetCardsResponse>>(request =>
                {
                    var response = request.CreateResponse<GetCardsResponse>();
                    return response;
                })
            });

            //Route = string.Format("{0}cards/create", BaseRoute)
            routes.Add(new HularionRoute<CreateCardRequest, CreateCardResponse>()
            {
                Name = "Create Cards",
                Method = "CreateCards",
                Route = string.Format("{0}cards/create", BaseRoute),
                Usage = "Creates the specified number of cards and returns them.",
                Handler = ParameterizedFacade.FromSingle<RoutedRequest<CreateCardRequest>, RoutedResponse<CreateCardResponse>>(request =>
                {
                    var response = request.CreateResponse<CreateCardResponse>();
                    return response;
                })
            });

            //Route = string.Format("{0}cards/delete", BaseRoute)
            routes.Add(new HularionRoute<DeleteCardRequest, DeleteCardResponse>()
            {
                Name = "Delete Card",
                Method = "DeleteCard",
                Route = string.Format("{0}cards/delete", BaseRoute),
                Usage = "Deletes the cards with the given ids.",
                Handler = ParameterizedFacade.FromSingle<RoutedRequest<DeleteCardRequest>, RoutedResponse<DeleteCardResponse>>(request =>
                {
                    var response = request.CreateResponse<DeleteCardResponse>();
                    return response;
                })
            });

            //Route = string.Format("{0}cards/update", BaseRoute)
            routes.Add(new HularionRoute<UpdateCardRequest, UpdateCardResponse>()
            {
                Name = "Update Card",
                Method = "UpdateCard",
                Route = string.Format("{0}cards/update", BaseRoute),
                Usage = "Updates the card with the given id.",
                Handler = ParameterizedFacade.FromSingle<RoutedRequest<UpdateCardRequest>, RoutedResponse<UpdateCardResponse>>(request =>
                {
                    var response = request.CreateResponse<UpdateCardResponse>();
                    return response;
                })
            });
        }
    }
}

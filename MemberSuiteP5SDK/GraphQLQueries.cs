using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using MemberSuiteP5SDK.Model.msOrganization;
using MemberSuiteP5SDK.Model.msEvent;
using MemberSuiteP5SDK.Model.msIndividual;
using MemberSuiteP5SDK.Model.msMerchandise;
using MemberSuiteP5SDK.Model.msEventRegistrationForUser;

namespace MemberSuiteP5SDK.GraphQL
{
    /// <summary>
    /// Handles posting queries to the graphql REST endpoint
    /// </summary>
    public class GraphQLQueries
    {
        private APIClient _APIClient;
        const string GraphQLEndPoint = "graphql/v2";

        public GraphQLQueries(APIClient apiClient)
        {
            _APIClient = apiClient;
        }

        /// <summary>
        /// Posts the GetOrganization graphql query to the REST API
        /// </summary>
        /// <param name="OrganizationID">GUID of the organization</param>
        /// <returns>Organization data of the given GUID</returns>
        public msOrganization RunGetOrganization(string OrganizationID)
        {
            string query = GetOrganization.CreateGetOrganizationQuery(OrganizationID);

            HttpResponseMessage response = _APIClient.MakePostCall(GraphQLEndPoint, query);

            string result = response.Content.ReadAsStringAsync().Result;

            msOrganizationRootObject root = JsonConvert.DeserializeObject<msOrganizationRootObject>(result);

            return root.data.organization;
        }

        /// <summary>
        /// Posts the GetEvent graphql query to the REST API
        /// </summary>
        /// <param name="EventID">GUID of the event</param>
        /// <param name="EntityID">GUID of the individual</param>
        /// <returns>Event information of the give GUID</returns>
        public msEvent RunGetEvent(string EventID, string EntityID)
        {
            string query = GetEvent.CreateGetEventQuery(EventID, EntityID);

            HttpResponseMessage response = _APIClient.MakePostCall(GraphQLEndPoint, query);

            string result = response.Content.ReadAsStringAsync().Result;

            msEventRootobject root = JsonConvert.DeserializeObject<msEventRootobject>(result);

            return root.data.@event;
        }

        /// <summary>
        /// Posts the GetEvent graphql query to the REST API
        /// </summary>
        /// <param name="IndividualID">GUID of the individual</param>
        /// <returns>Individual information of the given GUID</returns>
        public msIndividual RunGetIndividual(string IndividualID)
        {
            string query = GetIndividual.CreateIndividualQuery(IndividualID);

            HttpResponseMessage response = _APIClient.MakePostCall(GraphQLEndPoint, query);

            string result = response.Content.ReadAsStringAsync().Result;

            msIndividualRootobject root = JsonConvert.DeserializeObject<msIndividualRootobject>(result);

            return root.data.individual;
        }

        /// <summary>
        /// Posts the GetMerchandise graphql query to the REST API
        /// </summary>
        /// <param name="first">???</param>
        /// <param name="after">???</param>
        /// <param name="sellFrom">The sell from date of the merchandise</param>
        /// <param name="sellUntil">The sell until date of the merchandise</param>
        /// <param name="entityId">The entityId of the merchandise</param>
        /// <returns>A list of merchandise items that match the criteria of the give parameters</returns>
        public msMerchandisesearch RunGetMerchandise(string first, string after, string sellFrom, string sellUntil, string entityId)
        {
            string query = GetMerchandise.CreateGetMerchandiseQuery(first, after, sellFrom, sellUntil, entityId);

            HttpResponseMessage response = _APIClient.MakePostCall(GraphQLEndPoint, query);

            string result = response.Content.ReadAsStringAsync().Result;

            msMerchandiseRootobject root = JsonConvert.DeserializeObject<msMerchandiseRootobject>(result);

            return root.data.merchandiseSearch;
        }

        /// <summary>
        /// Posts the GetEventRegistrationForUser graphql query to the REST API
        /// </summary>
        /// <param name="entityId">The GUID of the individual</param>
        /// <returns>A list of all event registrations owned by the given individual</returns>
        public msEventregistrationforuser RunGetEventRegistrationForUser(string entityId)
        {
            string query = GetEventRegistrationForUser.CreateGetEventRegistrationForUserQuery(entityId);

            HttpResponseMessage response = _APIClient.MakePostCall(GraphQLEndPoint, query);

            string result = response.Content.ReadAsStringAsync().Result;

            msEventRegistrationForUserRootobject root = JsonConvert.DeserializeObject<msEventRegistrationForUserRootobject>(result);

            return root.data.eventRegistrationForUser;
        }
    }
}

using System;
using System.Net.Http;
using MemberSuiteP5SDK.GraphQL;
using MemberSuiteP5SDK.Model;

namespace MemberSuiteP5SDK
{
    public class MemberSuiteAPI
    {

        public GraphQLQueries GraphQLQueries;
        private APIClient _APIClient;

        public MemberSuiteAPI(string APIurl, string username, string password, string clientID, string tenantID)
        {
            _APIClient = new APIClient(APIurl, username, password, clientID, tenantID);

            GraphQLQueries = new GraphQLQueries(_APIClient);
        }

    }
}

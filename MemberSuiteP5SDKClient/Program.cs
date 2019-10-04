using System;
using MemberSuiteP5SDK;
using MemberSuiteP5SDK.Model.msOrganization;
using MemberSuiteP5SDK.Model.msEvent;
using MemberSuiteP5SDK.Model.msIndividual;
using MemberSuiteP5SDK.Model.msMerchandise;
using MemberSuiteP5SDK.Model.msEventRegistrationForUser;


namespace MemberSuiteP5SDKClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberSuiteAPI msAPI = new MemberSuiteAPI("https://rest-blue-internal.financial.membersuite.com", "hj2", "Password1!", "77vb3ihs1lrpoee0fc0q415iub", "27969");

            msOrganization a = msAPI.GraphQLQueries.RunGetOrganization("8902ce52-0007-cb23-a2a8-0b39828645e9");
            msEvent b = msAPI.GraphQLQueries.RunGetEvent("8902ce52-0078-c450-0978-0b3f2d50b2e2", "8902ce52-0006-c741-3888-0b3f474d7ca2");
            msIndividual c = msAPI.GraphQLQueries.RunGetIndividual("8902ce52-0006-c741-3888-0b3f474d7ca2");
            msMerchandisesearch d = msAPI.GraphQLQueries.RunGetMerchandise("21", "0", "2019-02-11T13:55:44.703Z", "2019-02-11T13:55:44.703Z", "8902ce52-0006-c255-d1de-0b3f327d1b78");
            msEventregistrationforuser e = msAPI.GraphQLQueries.RunGetEventRegistrationForUser("8902ce52-0006-c255-d1de-0b3f327d1b78");
        }
    }
}

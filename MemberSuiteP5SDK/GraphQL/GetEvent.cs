using System;
using System.Collections.Generic;
using System.Text;

namespace MemberSuiteP5SDK.GraphQL
{
    public class GetEvent
    {
        private const string GetEventQueryStart = @"{""operationName"":""GetEvent"",""variables"":{""id"":""";
        private const string GetEventIDAfter= @""",""entityId"":""";
        private const string GetEventQueryEnd = @"""},""query"":""query GetEvent($id: String!, $entityId:
String) {
event(id: $id, entityId: $entityId) {
startDate
endDate
id: iD
description
location {
city
company
country
county
line1
line2
postalCode
state
__typename
}
name
displayStartEndDateTimesAs
preRegistrationCutOffDate
earlyRegistrationCutOffDate
regularRegistrationCutOffDate
registrationOpenDate
registrationCloseDate
availableCapacity
allowWaitList
enableGroupRegistrations
allowGroupRegistrationsFrom
allowGroupRegistrationsUntil
groupRegistrationRelationshipTypes
registrationMode
isRegistered(entityId: $entityId)
registrationFeeInstructions
registrationFormInstructions
acknowledgementText
hasTabledEvents
guestsInformation
enablePortalTableManagement
purchasedBy(entityId: $entityId)
__typename
}
}
""}";

        public static string CreateGetEventQuery(string EventID, string EntityID)
        {
            return GetEventQueryStart + EventID + GetEventIDAfter + EntityID + GetEventQueryEnd;
        }
    }
}

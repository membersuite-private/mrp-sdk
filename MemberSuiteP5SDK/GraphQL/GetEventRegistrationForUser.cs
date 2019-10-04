using System;
using System.Collections.Generic;
using System.Text;

namespace MemberSuiteP5SDK.GraphQL
{
    public class GetEventRegistrationForUser
    {
        private const string GetEventRegistrationForUserQueryStart = @"{""operationName"":""eventRegistrationForUser"",""variables"":{""entityId"":""";
        private const string GetEventRegistrationForUserQueryEnd = @"""},""query"":""query eventRegistrationForUser($entityId: String) {
eventRegistrationForUser(entityId: $entityId) {
items {
addOns {
comments
__typename
}
approved
assignedTo
badgeCity
badgeCountry
badgeName
badgeOrganization
badgeState
badgeTitle
cancellationDate
cancellationReason
category
checkInDate
class
createdBy
createdDate
dateApproved
event
fee
group
groupName
hasGeneratedCEUCredits
iD
isConfiguration
isSealed
keywords
lastModifiedBy
lastModifiedDate
localID
lockedForDeletion
name
notes
onWaitList
order
orderLineItemID
owner
ownerPrimaryOrganization
parentRegistration
systemTimestamp
tieredRegistrationPricingRule
__typename
}
__typename
}
}
""}";

        public static string CreateGetEventRegistrationForUserQuery(string EntityID)
        {
            return GetEventRegistrationForUserQueryStart + EntityID + GetEventRegistrationForUserQueryEnd;
        }
    }
}

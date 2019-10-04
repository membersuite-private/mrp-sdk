using System;
using System.Collections.Generic;
using System.Text;

namespace MemberSuiteP5SDK.GraphQL
{
    public class GetOrganization
    {
        private const string GetOrganizationQueryStart = @"{""operationName"":""GetOrganization"",""variables"":{""organizationId"":""";
        private const string GetOrganizationQueryEnd = @"""},""query"":""query GetOrganization($organizationId: String!) {   organization(id: $organizationId) {
id: iD
name
billingContactName
billingContactPhoneNumber
emailAddress
image
preferredAddressType
preferredPhoneNumberType
addresses {
  isPreferred
  address
    {
        city
    company
    line1
    line2
    postalCode
    state
    stateName
    __typename
    }
    __typename
}
phoneNumbers {
  isPreferred
  phoneNumber
  type
  type_Name
  __typename
}
memberships {
  id: iD
  productId: product_ID
  type

 type_Name
  typeId: type
  joinDate
  expirationDate
  renewalDate
  reinstatementDate
  terminationDate
  status_Name
  chapters
{
    chapter
    __typename
}
sections {
    section
    __typename
  }
  membershipDuesProduct {
    name
    termLength
    gracePeriod
    reinstatementPeriod
    __typename
  }
  membershipDirectoryOptOut
  receivesMemberBenefits
  membershipOrganization
  membershipOrganizationDetails
{
    iD
    name
    __typename
}
__typename
}
__typename   } }""}";

        public static string CreateGetOrganizationQuery(string OrganizationID)
        {
            return GetOrganizationQueryStart + OrganizationID + GetOrganizationQueryEnd;
        }
    }
}

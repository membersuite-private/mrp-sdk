using System;
using System.Collections.Generic;
using System.Text;

namespace MemberSuiteP5SDK.GraphQL
{
    public class GetIndividual
    {
        private const string GetIndividualQueryStart = @"{""operationName"":""GetIndividual"",""variables"":{""id"":""";
        private const string GetIndividualQueryEnd = @"""},""query"":""query GetIndividual($id: String!) {
individual(id: $id) {
addresses {
incorrectSince
isPreferred
lastUpdated
region
type
type_Name
address {
city
company
country
county
geocodeLat
geocodeLong
lastGeocodeDate
line1
line2
postalCode
state
__typename
}
__typename
}
age
company
doNotEmail
doNotMail
doNotFax
optOuts
emailAddress
firstName
id: iD
image
lastName
middleName
name
nickname
notes
phoneNumbers {
isPreferred
phoneNumber
type
type_Name
__typename
}
memberships {
id: iD
name
localID
productId: product_ID
type
type_Name
typeId: type
joinDate
expirationDate
renewalDate
terminationDate
status_Name
isInherited
referredBy
owner
approved
savedPaymentMethod
savedElectronicCheck {
name
check {
bankAccountType
bankAccountNumber
nameOnAccount
routingNumber
billingAddress {
city
state
country
postalCode
line1
line2
__typename
}
__typename
}
__typename
}
product {
name
__typename
}
savedCreditCard {
card {
cardNumber
nameOnCard
cardExpirationDate
accountNumber
name
billingAddress {
city
state
country
postalCode
line1
line2
__typename
}
__typename
}
cardLastFiveDigits
cardType
__typename
}
demographics {
name
value
__typename
}
customFields {
fieldDefinition {
label
name
description
helpText
customFieldID
dataType
displayType
portalAccessibility
nullValueLabel
pickListEntries {
text
value
isActive
isDefault
__typename
}
__typename
}
__typename
}
lastOrder {
id: iD
lineItems {
type
product
__typename
}
__typename
}
chapters {
chapter
chapterName
__typename
}
sections {
section
sectionName
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
membershipOrganizationDetails {
iD
name
__typename
days: numberOfDaysPriorToExpirationToPromptForRenewal
}
__typename
}
preferredAddressType
preferredPhoneNumberType
prefix
status
suffix
title
type
webSite
emailAddress2
emailAddress3
sourceCode
sortName
paymentGatewayID
communicationsLastVerified
communicationsLastVerifiedFrom
createdBy
createdDate
dateOfBirth
designation
donorLevel
isConfiguration
isSealed
keywords
lastModifiedBy
lastModifiedDate
legislativeDistricts {
district
__typename
}
lockedForDeletion
mediaCode
nRDSID
seasonalAddressEnd
seasonalAddressStart
systemTimestamp
relationships {
iD
leftSide
rightSide
relationshipType {
iD
name
isActive
eligibleForPortalSignup
enablePortalManagement
leftSideName
rightSideName
leftSideType
rightSideType
__typename
}
__typename
}
gifts {
name
total
__typename
}
__typename
}
}
""}";

        public static string CreateIndividualQuery(string IndividualID)
        {
            return GetIndividualQueryStart + IndividualID + GetIndividualQueryEnd;
        }
    }
}

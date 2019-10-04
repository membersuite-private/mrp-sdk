using System;
using System.Collections.Generic;
using System.Text;

namespace MemberSuiteP5SDK.Model.msIndividual
{

    public class msIndividualRootobject
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public msIndividual individual { get; set; }
    }

    public class msIndividual
    {
        public Address[] addresses { get; set; }
        public object age { get; set; }
        public object company { get; set; }
        public bool? doNotEmail { get; set; }
        public bool? doNotMail { get; set; }
        public bool? doNotFax { get; set; }
        public object[] optOuts { get; set; }
        public string emailAddress { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public object image { get; set; }
        public string lastName { get; set; }
        public object middleName { get; set; }
        public string name { get; set; }
        public object nickname { get; set; }
        public object notes { get; set; }
        public Phonenumber[] phoneNumbers { get; set; }
        public Membership[] memberships { get; set; }
        public string preferredAddressType { get; set; }
        public string preferredPhoneNumberType { get; set; }
        public object prefix { get; set; }
        public string status { get; set; }
        public object suffix { get; set; }
        public object title { get; set; }
        public string type { get; set; }
        public string webSite { get; set; }
        public object emailAddress2 { get; set; }
        public object emailAddress3 { get; set; }
        public object sourceCode { get; set; }
        public string sortName { get; set; }
        public string paymentGatewayID { get; set; }
        public object communicationsLastVerified { get; set; }
        public object communicationsLastVerifiedFrom { get; set; }
        public string createdBy { get; set; }
        public string createdDate { get; set; }
        public object dateOfBirth { get; set; }
        public object designation { get; set; }
        public object donorLevel { get; set; }
        public bool? isConfiguration { get; set; }
        public bool? isSealed { get; set; }
        public object keywords { get; set; }
        public string lastModifiedBy { get; set; }
        public string lastModifiedDate { get; set; }
        public object[] legislativeDistricts { get; set; }
        public bool? lockedForDeletion { get; set; }
        public object mediaCode { get; set; }
        public object nRDSID { get; set; }
        public object seasonalAddressEnd { get; set; }
        public object seasonalAddressStart { get; set; }
        public string systemTimestamp { get; set; }
        public Relationship[] relationships { get; set; }
        public object[] gifts { get; set; }
        public string __typename { get; set; }
    }

    public class Address
    {
        public object incorrectSince { get; set; }
        public bool? isPreferred { get; set; }
        public string lastUpdated { get; set; }
        public object region { get; set; }
        public string type { get; set; }
        public string type_Name { get; set; }
        public Address1 address { get; set; }
        public string __typename { get; set; }
    }

    public class Address1
    {
        public string city { get; set; }
        public string company { get; set; }
        public string country { get; set; }
        public string county { get; set; }
        public float? geocodeLat { get; set; }
        public float? geocodeLong { get; set; }
        public object lastGeocodeDate { get; set; }
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string postalCode { get; set; }
        public string state { get; set; }
        public string __typename { get; set; }
    }

    public class Phonenumber
    {
        public bool? isPreferred { get; set; }
        public string phoneNumber { get; set; }
        public string type { get; set; }
        public string type_Name { get; set; }
        public string __typename { get; set; }
    }

    public class Membership
    {
        public string id { get; set; }
        public string name { get; set; }
        public int localID { get; set; }
        public string productId { get; set; }
        public string type { get; set; }
        public string type_Name { get; set; }
        public string typeId { get; set; }
        public string joinDate { get; set; }
        public string expirationDate { get; set; }
        public object renewalDate { get; set; }
        public object terminationDate { get; set; }
        public string status_Name { get; set; }
        public bool? isInherited { get; set; }
        public object referredBy { get; set; }
        public string owner { get; set; }
        public bool? approved { get; set; }
        public string savedPaymentMethod { get; set; }
        public Savedelectroniccheck savedElectronicCheck { get; set; }
        public Product product { get; set; }
        public object savedCreditCard { get; set; }
        public Demographic[] demographics { get; set; }
        public Customfield[] customFields { get; set; }
        public Lastorder lastOrder { get; set; }
        public Chapter[] chapters { get; set; }
        public object[] sections { get; set; }
        public Membershipduesproduct membershipDuesProduct { get; set; }
        public bool? membershipDirectoryOptOut { get; set; }
        public bool? receivesMemberBenefits { get; set; }
        public string membershipOrganization { get; set; }
        public Membershiporganizationdetails membershipOrganizationDetails { get; set; }
        public string __typename { get; set; }
    }

    public class Savedelectroniccheck
    {
        public string name { get; set; }
        public Check check { get; set; }
        public string __typename { get; set; }
    }

    public class Check
    {
        public string bankAccountType { get; set; }
        public string bankAccountNumber { get; set; }
        public object nameOnAccount { get; set; }
        public string routingNumber { get; set; }
        public object billingAddress { get; set; }
        public string __typename { get; set; }
    }

    public class Product
    {
        public string name { get; set; }
        public string __typename { get; set; }
    }

    public class Lastorder
    {
        public string id { get; set; }
        public Lineitem[] lineItems { get; set; }
        public string __typename { get; set; }
    }

    public class Lineitem
    {
        public string type { get; set; }
        public string product { get; set; }
        public string __typename { get; set; }
    }

    public class Membershipduesproduct
    {
        public string name { get; set; }
        public int termLength { get; set; }
        public int gracePeriod { get; set; }
        public int reinstatementPeriod { get; set; }
        public string __typename { get; set; }
    }

    public class Membershiporganizationdetails
    {
        public string iD { get; set; }
        public string name { get; set; }
        public string __typename { get; set; }
        public int days { get; set; }
    }

    public class Demographic
    {
        public string name { get; set; }
        public object value { get; set; }
        public string __typename { get; set; }
    }

    public class Customfield
    {
        public Fielddefinition fieldDefinition { get; set; }
        public string __typename { get; set; }
    }

    public class Fielddefinition
    {
        public string label { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public object helpText { get; set; }
        public string customFieldID { get; set; }
        public int dataType { get; set; }
        public int displayType { get; set; }
        public int portalAccessibility { get; set; }
        public object nullValueLabel { get; set; }
        public Picklistentry[] pickListEntries { get; set; }
        public string __typename { get; set; }
    }

    public class Picklistentry
    {
        public string text { get; set; }
        public string value { get; set; }
        public bool? isActive { get; set; }
        public bool? isDefault { get; set; }
        public string __typename { get; set; }
    }

    public class Chapter
    {
        public string chapter { get; set; }
        public string chapterName { get; set; }
        public string __typename { get; set; }
    }

    public class Relationship
    {
        public string iD { get; set; }
        public string leftSide { get; set; }
        public string rightSide { get; set; }
        public Relationshiptype relationshipType { get; set; }
        public string __typename { get; set; }
    }

    public class Relationshiptype
    {
        public string iD { get; set; }
        public string name { get; set; }
        public bool? isActive { get; set; }
        public bool? eligibleForPortalSignup { get; set; }
        public bool? enablePortalManagement { get; set; }
        public string leftSideName { get; set; }
        public string rightSideName { get; set; }
        public string leftSideType { get; set; }
        public string rightSideType { get; set; }
        public string __typename { get; set; }
    }



}

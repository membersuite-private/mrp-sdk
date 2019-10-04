using System;
using System.Collections.Generic;
using System.Text;

namespace MemberSuiteP5SDK.Model.msOrganization
{
    public class msOrganizationRootObject
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public msOrganization organization { get; set; }
    }

    public class msOrganization
    {
        public string id { get; set; }
        public string name { get; set; }
        public string billingContactName { get; set; }
        public string billingContactPhoneNumber { get; set; }
        public string emailAddress { get; set; }
        public string image { get; set; }
        public string preferredAddressType { get; set; }
        public string preferredPhoneNumberType { get; set; }
        public Address[] addresses { get; set; }
        public Phonenumber[] phoneNumbers { get; set; }
        public Membership[] memberships { get; set; }
        public string __typename { get; set; }
    }

    public class Address
    {
        public bool? isPreferred { get; set; }
        public Address1 address { get; set; }
        public string __typename { get; set; }
    }

    public class Address1
    {
        public string city { get; set; }
        public string company { get; set; }
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string postalCode { get; set; }
        public string state { get; set; }
        public string stateName { get; set; }
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
        public string productId { get; set; }
        public string type { get; set; }
        public string type_Name { get; set; }
        public string typeId { get; set; }
        public string joinDate { get; set; }
        public string expirationDate { get; set; }
        public string renewalDate { get; set; }
        public string reinstatementDate { get; set; }
        public string terminationDate { get; set; }
        public string status_Name { get; set; }
        public Chapter[] chapters { get; set; }
        public object[] sections { get; set; }
        public Membershipduesproduct membershipDuesProduct { get; set; }
        public bool? membershipDirectoryOptOut { get; set; }
        public bool? receivesMemberBenefits { get; set; }
        public string membershipOrganization { get; set; }
        public Membershiporganizationdetails membershipOrganizationDetails { get; set; }
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
    }

    public class Chapter
    {
        public string chapter { get; set; }
        public string __typename { get; set; }
    }
    
}

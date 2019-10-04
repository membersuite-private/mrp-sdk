using System;
using System.Collections.Generic;
using System.Text;

namespace MemberSuiteP5SDK.Model.msEventRegistrationForUser
{

    public class msEventRegistrationForUserRootobject
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public msEventregistrationforuser eventRegistrationForUser { get; set; }
    }

    public class msEventregistrationforuser
    {
        public Item[] items { get; set; }
        public string __typename { get; set; }
    }

    public class Item
    {
        public Addon[] addOns { get; set; }
        public bool approved { get; set; }
        public string assignedTo { get; set; }
        public string badgeCity { get; set; }
        public string badgeCountry { get; set; }
        public string badgeName { get; set; }
        public string badgeOrganization { get; set; }
        public string badgeState { get; set; }
        public string badgeTitle { get; set; }
        public string cancellationDate { get; set; }
        public string cancellationReason { get; set; }
        public object category { get; set; }
        public object checkInDate { get; set; }
        public object _class { get; set; }
        public string createdBy { get; set; }
        public string createdDate { get; set; }
        public string dateApproved { get; set; }
        public string _event { get; set; }
        public string fee { get; set; }
        public string group { get; set; }
        public object groupName { get; set; }
        public bool hasGeneratedCEUCredits { get; set; }
        public string iD { get; set; }
        public bool isConfiguration { get; set; }
        public bool isSealed { get; set; }
        public object keywords { get; set; }
        public string lastModifiedBy { get; set; }
        public string lastModifiedDate { get; set; }
        public int localID { get; set; }
        public bool lockedForDeletion { get; set; }
        public string name { get; set; }
        public object notes { get; set; }
        public bool onWaitList { get; set; }
        public string order { get; set; }
        public string orderLineItemID { get; set; }
        public string owner { get; set; }
        public string ownerPrimaryOrganization { get; set; }
        public object parentRegistration { get; set; }
        public string systemTimestamp { get; set; }
        public object tieredRegistrationPricingRule { get; set; }
        public string __typename { get; set; }
    }

    public class Addon
    {
        public object comments { get; set; }
        public string __typename { get; set; }
    }

}

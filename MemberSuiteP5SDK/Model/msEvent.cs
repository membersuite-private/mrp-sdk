using System;
using System.Collections.Generic;
using System.Text;

namespace MemberSuiteP5SDK.Model.msEvent
{

    public class msEventRootobject
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public msEvent @event { get; set; }
    }

    public class msEvent
    {
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string id { get; set; }
        public string description { get; set; }
        public object location { get; set; }
        public string name { get; set; }
        public object displayStartEndDateTimesAs { get; set; }
        public DateTime? preRegistrationCutOffDate { get; set; }
        public DateTime? earlyRegistrationCutOffDate { get; set; }
        public object regularRegistrationCutOffDate { get; set; }
        public object registrationOpenDate { get; set; }
        public object registrationCloseDate { get; set; }
        public float? availableCapacity { get; set; }
        public bool? allowWaitList { get; set; }
        public bool? enableGroupRegistrations { get; set; }
        public DateTime? allowGroupRegistrationsFrom { get; set; }
        public DateTime? allowGroupRegistrationsUntil { get; set; }
        public string[] groupRegistrationRelationshipTypes { get; set; }
        public string registrationMode { get; set; }
        public bool? isRegistered { get; set; }
        public object registrationFeeInstructions { get; set; }
        public object registrationFormInstructions { get; set; }
        public object acknowledgementText { get; set; }
        public bool? hasTabledEvents { get; set; }
        public object guestsInformation { get; set; }
        public bool? enablePortalTableManagement { get; set; }
        public object[] purchasedBy { get; set; }
        public string __typename { get; set; }
    }



}

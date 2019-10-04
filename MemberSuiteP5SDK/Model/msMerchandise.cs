using System;
using System.Collections.Generic;
using System.Text;

namespace MemberSuiteP5SDK.Model.msMerchandise
{

    public class msMerchandiseRootobject
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public msMerchandisesearch merchandiseSearch { get; set; }
    }

    public class msMerchandisesearch
    {
        public int totalCount { get; set; }
        public Item[] items { get; set; }
        public string __typename { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public int localID { get; set; }
        public bool? eligibleForShippingCharges { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public bool? hasSpecialPrices { get; set; }
        public object displayPriceAs { get; set; }
        public bool? hasEligibilityRestrictions { get; set; }
        public float? price { get; set; }
        public float? memberPrice { get; set; }
        public float? specialPrice { get; set; }
        public string shortDescription { get; set; }
        public string description { get; set; }
        public bool? isSoldOut { get; set; }
        public object sellFrom { get; set; }
        public object sellUntil { get; set; }
        public bool? sellOnline { get; set; }
        public bool? useSpecialPricesOnly { get; set; }
        public bool? isSpecialPriceEligible { get; set; }
        public string __typename { get; set; }
    }


}

using System;
using System.Collections.Generic;
using System.Text;

namespace MemberSuiteP5SDK.GraphQL
{
    public class GetMerchandise
    {
        private const string GetMerchandiseQueryStart = @"{""operationName"":""GetMerchandise"",""variables"":{""first"":";
        private const string GetMerchandiseQueryAfterFirst = @",""after"":";
        private const string GetMerchandiseQueryAfterAfter = @",""sellFrom"":""";
        private const string GetMerchandiseQueryAfterSellFrom = @""",""sellUntil"":""";
        private const string GetMerchandiseQueryAfterSellUntil = @""",""entityId"":""";
        private const string GetMerchandiseQueryEnd = @"""},""query"":""query GetMerchandise($contains: String, $first: Int, $after: Int, $sellFrom:
Date, $sellUntil: Date, $entityId: String) {
merchandiseSearch(contains: $contains, first: $first, after: $after, sellFrom: $sellFrom, sellUntil:
$sellUntil, entityId: $entityId) {
totalCount
items {
id: iD
localID
eligibleForShippingCharges
name
image
hasSpecialPrices
displayPriceAs
hasEligibilityRestrictions
price
memberPrice
specialPrice(entityId: $entityId)
shortDescription
description
isSoldOut
sellFrom
sellUntil
sellOnline
useSpecialPricesOnly
isSpecialPriceEligible(entityId: $entityId)
__typename
}
__typename
}
}
""}";

        public static string CreateGetMerchandiseQuery(string first, string after, string sellFrom, string sellUntil, string entityId)
        {
            return GetMerchandiseQueryStart + first + GetMerchandiseQueryAfterFirst + after + GetMerchandiseQueryAfterAfter + sellFrom + GetMerchandiseQueryAfterSellFrom
                + sellUntil + GetMerchandiseQueryAfterSellUntil + entityId + GetMerchandiseQueryEnd;
        }
    }
}

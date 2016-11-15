using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.Usage.Record 
{

    public class YesterdayResource : Resource 
    {
        public sealed class CategoryEnum : StringEnum 
        {
            private CategoryEnum(string value) : base(value) {}
            public CategoryEnum() {}
        
            public static readonly CategoryEnum AuthyAuthentications = new CategoryEnum("authy-authentications");
            public static readonly CategoryEnum AuthyCallsOutbound = new CategoryEnum("authy-calls-outbound");
            public static readonly CategoryEnum AuthyMonthlyFees = new CategoryEnum("authy-monthly-fees");
            public static readonly CategoryEnum AuthyPhoneIntelligence = new CategoryEnum("authy-phone-intelligence");
            public static readonly CategoryEnum AuthyPhoneVerifications = new CategoryEnum("authy-phone-verifications");
            public static readonly CategoryEnum AuthySmsOutbound = new CategoryEnum("authy-sms-outbound");
            public static readonly CategoryEnum CallProgessEvents = new CategoryEnum("call-progess-events");
            public static readonly CategoryEnum Calleridlookups = new CategoryEnum("calleridlookups");
            public static readonly CategoryEnum Calls = new CategoryEnum("calls");
            public static readonly CategoryEnum CallsClient = new CategoryEnum("calls-client");
            public static readonly CategoryEnum CallsGlobalconference = new CategoryEnum("calls-globalconference");
            public static readonly CategoryEnum CallsInbound = new CategoryEnum("calls-inbound");
            public static readonly CategoryEnum CallsInboundLocal = new CategoryEnum("calls-inbound-local");
            public static readonly CategoryEnum CallsInboundMobile = new CategoryEnum("calls-inbound-mobile");
            public static readonly CategoryEnum CallsInboundTollfree = new CategoryEnum("calls-inbound-tollfree");
            public static readonly CategoryEnum CallsOutbound = new CategoryEnum("calls-outbound");
            public static readonly CategoryEnum CallsRecordings = new CategoryEnum("calls-recordings");
            public static readonly CategoryEnum CallsSip = new CategoryEnum("calls-sip");
            public static readonly CategoryEnum CallsSipInbound = new CategoryEnum("calls-sip-inbound");
            public static readonly CategoryEnum CallsSipOutbound = new CategoryEnum("calls-sip-outbound");
            public static readonly CategoryEnum CarrierLookups = new CategoryEnum("carrier-lookups");
            public static readonly CategoryEnum Conversations = new CategoryEnum("conversations");
            public static readonly CategoryEnum ConversationsApiRequests = new CategoryEnum("conversations-api-requests");
            public static readonly CategoryEnum ConversationsConversationEvents = new CategoryEnum("conversations-conversation-events");
            public static readonly CategoryEnum ConversationsEndpointConnectivity = new CategoryEnum("conversations-endpoint-connectivity");
            public static readonly CategoryEnum ConversationsEvents = new CategoryEnum("conversations-events");
            public static readonly CategoryEnum ConversationsParticipantEvents = new CategoryEnum("conversations-participant-events");
            public static readonly CategoryEnum ConversationsParticipants = new CategoryEnum("conversations-participants");
            public static readonly CategoryEnum IpMessaging = new CategoryEnum("ip-messaging");
            public static readonly CategoryEnum IpMessagingCommands = new CategoryEnum("ip-messaging-commands");
            public static readonly CategoryEnum IpMessagingDataStorage = new CategoryEnum("ip-messaging-data-storage");
            public static readonly CategoryEnum IpMessagingDataTransfer = new CategoryEnum("ip-messaging-data-transfer");
            public static readonly CategoryEnum IpMessagingEndpointConnectivity = new CategoryEnum("ip-messaging-endpoint-connectivity");
            public static readonly CategoryEnum Lookups = new CategoryEnum("lookups");
            public static readonly CategoryEnum Mediastorage = new CategoryEnum("mediastorage");
            public static readonly CategoryEnum Mms = new CategoryEnum("mms");
            public static readonly CategoryEnum MmsInbound = new CategoryEnum("mms-inbound");
            public static readonly CategoryEnum MmsInboundLongcode = new CategoryEnum("mms-inbound-longcode");
            public static readonly CategoryEnum MmsInboundShortcode = new CategoryEnum("mms-inbound-shortcode");
            public static readonly CategoryEnum MmsOutbound = new CategoryEnum("mms-outbound");
            public static readonly CategoryEnum MmsOutboundLongcode = new CategoryEnum("mms-outbound-longcode");
            public static readonly CategoryEnum MmsOutboundShortcode = new CategoryEnum("mms-outbound-shortcode");
            public static readonly CategoryEnum MonitorReads = new CategoryEnum("monitor-reads");
            public static readonly CategoryEnum MonitorStorage = new CategoryEnum("monitor-storage");
            public static readonly CategoryEnum MonitorWrites = new CategoryEnum("monitor-writes");
            public static readonly CategoryEnum NumberFormatLookups = new CategoryEnum("number-format-lookups");
            public static readonly CategoryEnum Phonenumbers = new CategoryEnum("phonenumbers");
            public static readonly CategoryEnum PhonenumbersCps = new CategoryEnum("phonenumbers-cps");
            public static readonly CategoryEnum PhonenumbersEmergency = new CategoryEnum("phonenumbers-emergency");
            public static readonly CategoryEnum PhonenumbersLocal = new CategoryEnum("phonenumbers-local");
            public static readonly CategoryEnum PhonenumbersMobile = new CategoryEnum("phonenumbers-mobile");
            public static readonly CategoryEnum PhonenumbersSetups = new CategoryEnum("phonenumbers-setups");
            public static readonly CategoryEnum PhonenumbersTollfree = new CategoryEnum("phonenumbers-tollfree");
            public static readonly CategoryEnum Premiumsupport = new CategoryEnum("premiumsupport");
            public static readonly CategoryEnum Recordings = new CategoryEnum("recordings");
            public static readonly CategoryEnum Recordingstorage = new CategoryEnum("recordingstorage");
            public static readonly CategoryEnum Shortcodes = new CategoryEnum("shortcodes");
            public static readonly CategoryEnum ShortcodesCustomerowned = new CategoryEnum("shortcodes-customerowned");
            public static readonly CategoryEnum ShortcodesMmsEnablement = new CategoryEnum("shortcodes-mms-enablement");
            public static readonly CategoryEnum ShortcodesMps = new CategoryEnum("shortcodes-mps");
            public static readonly CategoryEnum ShortcodesRandom = new CategoryEnum("shortcodes-random");
            public static readonly CategoryEnum ShortcodesUk = new CategoryEnum("shortcodes-uk");
            public static readonly CategoryEnum ShortcodesVanity = new CategoryEnum("shortcodes-vanity");
            public static readonly CategoryEnum Sms = new CategoryEnum("sms");
            public static readonly CategoryEnum SmsInbound = new CategoryEnum("sms-inbound");
            public static readonly CategoryEnum SmsInboundLongcode = new CategoryEnum("sms-inbound-longcode");
            public static readonly CategoryEnum SmsInboundShortcode = new CategoryEnum("sms-inbound-shortcode");
            public static readonly CategoryEnum SmsOutbound = new CategoryEnum("sms-outbound");
            public static readonly CategoryEnum SmsOutboundLongcode = new CategoryEnum("sms-outbound-longcode");
            public static readonly CategoryEnum SmsOutboundShortcode = new CategoryEnum("sms-outbound-shortcode");
            public static readonly CategoryEnum TaskrouterTasks = new CategoryEnum("taskrouter-tasks");
            public static readonly CategoryEnum Totalprice = new CategoryEnum("totalprice");
            public static readonly CategoryEnum Transcriptions = new CategoryEnum("transcriptions");
            public static readonly CategoryEnum TrunkingCps = new CategoryEnum("trunking-cps");
            public static readonly CategoryEnum TrunkingEmergencyCalls = new CategoryEnum("trunking-emergency-calls");
            public static readonly CategoryEnum TrunkingOrigination = new CategoryEnum("trunking-origination");
            public static readonly CategoryEnum TrunkingOriginationLocal = new CategoryEnum("trunking-origination-local");
            public static readonly CategoryEnum TrunkingOriginationMobile = new CategoryEnum("trunking-origination-mobile");
            public static readonly CategoryEnum TrunkingOriginationTollfree = new CategoryEnum("trunking-origination-tollfree");
            public static readonly CategoryEnum TrunkingRecordings = new CategoryEnum("trunking-recordings");
            public static readonly CategoryEnum TrunkingSecure = new CategoryEnum("trunking-secure");
            public static readonly CategoryEnum TrunkingTermination = new CategoryEnum("trunking-termination");
            public static readonly CategoryEnum Turnmegabytes = new CategoryEnum("turnmegabytes");
            public static readonly CategoryEnum TurnmegabytesAustralia = new CategoryEnum("turnmegabytes-australia");
            public static readonly CategoryEnum TurnmegabytesBrasil = new CategoryEnum("turnmegabytes-brasil");
            public static readonly CategoryEnum TurnmegabytesIreland = new CategoryEnum("turnmegabytes-ireland");
            public static readonly CategoryEnum TurnmegabytesJapan = new CategoryEnum("turnmegabytes-japan");
            public static readonly CategoryEnum TurnmegabytesSingapore = new CategoryEnum("turnmegabytes-singapore");
            public static readonly CategoryEnum TurnmegabytesUseast = new CategoryEnum("turnmegabytes-useast");
            public static readonly CategoryEnum TurnmegabytesUswest = new CategoryEnum("turnmegabytes-uswest");
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <returns> YesterdayReader capable of executing the read </returns> 
        public static YesterdayReader Reader()
        {
            return new YesterdayReader();
        }
    
        /// <summary>
        /// Converts a JSON string into a YesterdayResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> YesterdayResource object represented by the provided JSON </returns> 
        public static YesterdayResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<YesterdayResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        public string AccountSid { get; set; }
        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }
        [JsonProperty("category")]
        [JsonConverter(typeof(StringEnumConverter))]
        public YesterdayResource.CategoryEnum Category { get; set; }
        [JsonProperty("count")]
        public string Count { get; set; }
        [JsonProperty("count_unit")]
        public string CountUnit { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("end_date")]
        public DateTime? EndDate { get; set; }
        [JsonProperty("price")]
        public decimal? Price { get; set; }
        [JsonProperty("price_unit")]
        public string PriceUnit { get; set; }
        [JsonProperty("start_date")]
        public DateTime? StartDate { get; set; }
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; set; }
        [JsonProperty("uri")]
        public string Uri { get; set; }
        [JsonProperty("usage")]
        public string Usage { get; set; }
        [JsonProperty("usage_unit")]
        public string UsageUnit { get; set; }
    
        public YesterdayResource()
        {
        
        }
    
        private YesterdayResource([JsonProperty("account_sid")]
                                  string accountSid, 
                                  [JsonProperty("api_version")]
                                  string apiVersion, 
                                  [JsonProperty("category")]
                                  YesterdayResource.CategoryEnum category, 
                                  [JsonProperty("count")]
                                  string count, 
                                  [JsonProperty("count_unit")]
                                  string countUnit, 
                                  [JsonProperty("description")]
                                  string description, 
                                  [JsonProperty("end_date")]
                                  string endDate, 
                                  [JsonProperty("price")]
                                  decimal? price, 
                                  [JsonProperty("price_unit")]
                                  string priceUnit, 
                                  [JsonProperty("start_date")]
                                  string startDate, 
                                  [JsonProperty("subresource_uris")]
                                  Dictionary<string, string> subresourceUris, 
                                  [JsonProperty("uri")]
                                  string uri, 
                                  [JsonProperty("usage")]
                                  string usage, 
                                  [JsonProperty("usage_unit")]
                                  string usageUnit)
                                  {
            AccountSid = accountSid;
            ApiVersion = apiVersion;
            Category = category;
            Count = count;
            CountUnit = countUnit;
            Description = description;
            EndDate = MarshalConverter.DateTimeFromString(endDate);
            Price = price;
            PriceUnit = priceUnit;
            StartDate = MarshalConverter.DateTimeFromString(startDate);
            SubresourceUris = subresourceUris;
            Uri = uri;
            Usage = usage;
            UsageUnit = usageUnit;
        }
    }
}
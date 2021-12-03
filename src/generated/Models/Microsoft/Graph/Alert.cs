using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Alert : Entity, IParsable {
        /// <summary>Name or alias of the activity group (attacker) this alert is attributed to.</summary>
        public string ActivityGroupName { get; set; }
        public List<AlertDetection> AlertDetections { get; set; }
        /// <summary>Name of the analyst the alert is assigned to for triage, investigation, or remediation (supports update).</summary>
        public string AssignedTo { get; set; }
        /// <summary>Azure subscription ID, present if this alert is related to an Azure resource.</summary>
        public string AzureSubscriptionId { get; set; }
        /// <summary>Azure Active Directory tenant ID. Required.</summary>
        public string AzureTenantId { get; set; }
        /// <summary>Category of the alert (for example, credentialTheft, ransomware, etc.).</summary>
        public string Category { get; set; }
        /// <summary>Time at which the alert was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z (supports update).</summary>
        public DateTimeOffset? ClosedDateTime { get; set; }
        /// <summary>Security-related stateful information generated by the provider about the cloud application/s related to this alert.</summary>
        public List<CloudAppSecurityState> CloudAppStates { get; set; }
        /// <summary>Customer-provided comments on alert (for customer alert management) (supports update).</summary>
        public List<string> Comments { get; set; }
        /// <summary>Confidence of the detection logic (percentage between 1-100).</summary>
        public int? Confidence { get; set; }
        /// <summary>Time at which the alert was created by the alert provider. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Alert description.</summary>
        public string Description { get; set; }
        /// <summary>Set of alerts related to this alert entity (each alert is pushed to the SIEM as a separate record).</summary>
        public List<string> DetectionIds { get; set; }
        /// <summary>Time at which the event(s) that served as the trigger(s) to generate the alert occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>Analyst feedback on the alert. Possible values are: unknown, truePositive, falsePositive, benignPositive. (supports update)</summary>
        public AlertFeedback? Feedback { get; set; }
        /// <summary>Security-related stateful information generated by the provider about the file(s) related to this alert.</summary>
        public List<FileSecurityState> FileStates { get; set; }
        /// <summary>A collection of alertHistoryStates comprising an audit log of all updates made to an alert.</summary>
        public List<AlertHistoryState> HistoryStates { get; set; }
        /// <summary>Security-related stateful information generated by the provider about the host(s) related to this alert.</summary>
        public List<HostSecurityState> HostStates { get; set; }
        /// <summary>IDs of incidents related to current alert.</summary>
        public List<string> IncidentIds { get; set; }
        public List<InvestigationSecurityState> InvestigationSecurityStates { get; set; }
        public DateTimeOffset? LastEventDateTime { get; set; }
        /// <summary>Time at which the alert entity was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Threat Intelligence pertaining to malware related to this alert.</summary>
        public List<MalwareState> MalwareStates { get; set; }
        public List<MessageSecurityState> MessageSecurityStates { get; set; }
        /// <summary>Security-related stateful information generated by the provider about the network connection(s) related to this alert.</summary>
        public List<NetworkConnection> NetworkConnections { get; set; }
        /// <summary>Security-related stateful information generated by the provider about the process or processes related to this alert.</summary>
        public List<Process> Processes { get; set; }
        /// <summary>Vendor/provider recommended action(s) to take as a result of the alert (for example, isolate machine, enforce2FA, reimage host).</summary>
        public List<string> RecommendedActions { get; set; }
        /// <summary>Security-related stateful information generated by the provider about the registry keys related to this alert.</summary>
        public List<RegistryKeyState> RegistryKeyStates { get; set; }
        /// <summary>Resources related to current alert. For example, for some alerts this can have the Azure Resource value.</summary>
        public List<SecurityResource> SecurityResources { get; set; }
        /// <summary>Alert severity - set by vendor/provider. Possible values are: unknown, informational, low, medium, high. Required.</summary>
        public AlertSeverity? Severity { get; set; }
        /// <summary>Hyperlinks (URIs) to the source material related to the alert, for example, provider's user interface for alerts or log search, etc.</summary>
        public List<string> SourceMaterials { get; set; }
        /// <summary>Alert lifecycle status (stage). Possible values are: unknown, newAlert, inProgress, resolved. (supports update). Required.</summary>
        public AlertStatus? Status { get; set; }
        /// <summary>User-definable labels that can be applied to an alert and can serve as filter conditions (for example 'HVA', 'SAW', etc.) (supports update).</summary>
        public List<string> Tags { get; set; }
        /// <summary>Alert title. Required.</summary>
        public string Title { get; set; }
        /// <summary>Security-related information about the specific properties that triggered the alert (properties appearing in the alert). Alerts might contain information about multiple users, hosts, files, ip addresses. This field indicates which properties triggered the alert generation.</summary>
        public List<AlertTrigger> Triggers { get; set; }
        public List<UriClickSecurityState> UriClickSecurityStates { get; set; }
        /// <summary>Security-related stateful information generated by the provider about the user accounts related to this alert.</summary>
        public List<UserSecurityState> UserStates { get; set; }
        /// <summary>Complex type containing details about the security product/service vendor, provider, and subprovider (for example, vendor=Microsoft; provider=Windows Defender ATP; subProvider=AppLocker). Required.</summary>
        public SecurityVendorInformation VendorInformation { get; set; }
        /// <summary>Threat intelligence pertaining to one or more vulnerabilities related to this alert.</summary>
        public List<VulnerabilityState> VulnerabilityStates { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activityGroupName", (o,n) => { (o as Alert).ActivityGroupName = n.GetStringValue(); } },
                {"alertDetections", (o,n) => { (o as Alert).AlertDetections = n.GetCollectionOfObjectValues<AlertDetection>().ToList(); } },
                {"assignedTo", (o,n) => { (o as Alert).AssignedTo = n.GetStringValue(); } },
                {"azureSubscriptionId", (o,n) => { (o as Alert).AzureSubscriptionId = n.GetStringValue(); } },
                {"azureTenantId", (o,n) => { (o as Alert).AzureTenantId = n.GetStringValue(); } },
                {"category", (o,n) => { (o as Alert).Category = n.GetStringValue(); } },
                {"closedDateTime", (o,n) => { (o as Alert).ClosedDateTime = n.GetDateTimeOffsetValue(); } },
                {"cloudAppStates", (o,n) => { (o as Alert).CloudAppStates = n.GetCollectionOfObjectValues<CloudAppSecurityState>().ToList(); } },
                {"comments", (o,n) => { (o as Alert).Comments = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"confidence", (o,n) => { (o as Alert).Confidence = n.GetIntValue(); } },
                {"createdDateTime", (o,n) => { (o as Alert).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as Alert).Description = n.GetStringValue(); } },
                {"detectionIds", (o,n) => { (o as Alert).DetectionIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"eventDateTime", (o,n) => { (o as Alert).EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"feedback", (o,n) => { (o as Alert).Feedback = n.GetEnumValue<AlertFeedback>(); } },
                {"fileStates", (o,n) => { (o as Alert).FileStates = n.GetCollectionOfObjectValues<FileSecurityState>().ToList(); } },
                {"historyStates", (o,n) => { (o as Alert).HistoryStates = n.GetCollectionOfObjectValues<AlertHistoryState>().ToList(); } },
                {"hostStates", (o,n) => { (o as Alert).HostStates = n.GetCollectionOfObjectValues<HostSecurityState>().ToList(); } },
                {"incidentIds", (o,n) => { (o as Alert).IncidentIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"investigationSecurityStates", (o,n) => { (o as Alert).InvestigationSecurityStates = n.GetCollectionOfObjectValues<InvestigationSecurityState>().ToList(); } },
                {"lastEventDateTime", (o,n) => { (o as Alert).LastEventDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Alert).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"malwareStates", (o,n) => { (o as Alert).MalwareStates = n.GetCollectionOfObjectValues<MalwareState>().ToList(); } },
                {"messageSecurityStates", (o,n) => { (o as Alert).MessageSecurityStates = n.GetCollectionOfObjectValues<MessageSecurityState>().ToList(); } },
                {"networkConnections", (o,n) => { (o as Alert).NetworkConnections = n.GetCollectionOfObjectValues<NetworkConnection>().ToList(); } },
                {"processes", (o,n) => { (o as Alert).Processes = n.GetCollectionOfObjectValues<Process>().ToList(); } },
                {"recommendedActions", (o,n) => { (o as Alert).RecommendedActions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"registryKeyStates", (o,n) => { (o as Alert).RegistryKeyStates = n.GetCollectionOfObjectValues<RegistryKeyState>().ToList(); } },
                {"securityResources", (o,n) => { (o as Alert).SecurityResources = n.GetCollectionOfObjectValues<SecurityResource>().ToList(); } },
                {"severity", (o,n) => { (o as Alert).Severity = n.GetEnumValue<AlertSeverity>(); } },
                {"sourceMaterials", (o,n) => { (o as Alert).SourceMaterials = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"status", (o,n) => { (o as Alert).Status = n.GetEnumValue<AlertStatus>(); } },
                {"tags", (o,n) => { (o as Alert).Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"title", (o,n) => { (o as Alert).Title = n.GetStringValue(); } },
                {"triggers", (o,n) => { (o as Alert).Triggers = n.GetCollectionOfObjectValues<AlertTrigger>().ToList(); } },
                {"uriClickSecurityStates", (o,n) => { (o as Alert).UriClickSecurityStates = n.GetCollectionOfObjectValues<UriClickSecurityState>().ToList(); } },
                {"userStates", (o,n) => { (o as Alert).UserStates = n.GetCollectionOfObjectValues<UserSecurityState>().ToList(); } },
                {"vendorInformation", (o,n) => { (o as Alert).VendorInformation = n.GetObjectValue<SecurityVendorInformation>(); } },
                {"vulnerabilityStates", (o,n) => { (o as Alert).VulnerabilityStates = n.GetCollectionOfObjectValues<VulnerabilityState>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activityGroupName", ActivityGroupName);
            writer.WriteCollectionOfObjectValues<AlertDetection>("alertDetections", AlertDetections);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteStringValue("category", Category);
            writer.WriteDateTimeOffsetValue("closedDateTime", ClosedDateTime);
            writer.WriteCollectionOfObjectValues<CloudAppSecurityState>("cloudAppStates", CloudAppStates);
            writer.WriteCollectionOfPrimitiveValues<string>("comments", Comments);
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfPrimitiveValues<string>("detectionIds", DetectionIds);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteEnumValue<AlertFeedback>("feedback", Feedback);
            writer.WriteCollectionOfObjectValues<FileSecurityState>("fileStates", FileStates);
            writer.WriteCollectionOfObjectValues<AlertHistoryState>("historyStates", HistoryStates);
            writer.WriteCollectionOfObjectValues<HostSecurityState>("hostStates", HostStates);
            writer.WriteCollectionOfPrimitiveValues<string>("incidentIds", IncidentIds);
            writer.WriteCollectionOfObjectValues<InvestigationSecurityState>("investigationSecurityStates", InvestigationSecurityStates);
            writer.WriteDateTimeOffsetValue("lastEventDateTime", LastEventDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<MalwareState>("malwareStates", MalwareStates);
            writer.WriteCollectionOfObjectValues<MessageSecurityState>("messageSecurityStates", MessageSecurityStates);
            writer.WriteCollectionOfObjectValues<NetworkConnection>("networkConnections", NetworkConnections);
            writer.WriteCollectionOfObjectValues<Process>("processes", Processes);
            writer.WriteCollectionOfPrimitiveValues<string>("recommendedActions", RecommendedActions);
            writer.WriteCollectionOfObjectValues<RegistryKeyState>("registryKeyStates", RegistryKeyStates);
            writer.WriteCollectionOfObjectValues<SecurityResource>("securityResources", SecurityResources);
            writer.WriteEnumValue<AlertSeverity>("severity", Severity);
            writer.WriteCollectionOfPrimitiveValues<string>("sourceMaterials", SourceMaterials);
            writer.WriteEnumValue<AlertStatus>("status", Status);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("title", Title);
            writer.WriteCollectionOfObjectValues<AlertTrigger>("triggers", Triggers);
            writer.WriteCollectionOfObjectValues<UriClickSecurityState>("uriClickSecurityStates", UriClickSecurityStates);
            writer.WriteCollectionOfObjectValues<UserSecurityState>("userStates", UserStates);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
            writer.WriteCollectionOfObjectValues<VulnerabilityState>("vulnerabilityStates", VulnerabilityStates);
        }
    }
}

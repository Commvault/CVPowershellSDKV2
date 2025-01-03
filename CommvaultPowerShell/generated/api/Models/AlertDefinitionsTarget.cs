// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Please note CONTENT_INDEX will be returned at all times as it is enabled at all times.
    /// </summary>
    public partial class AlertDefinitionsTarget :
        Commvault.Powershell.Models.IAlertDefinitionsTarget,
        Commvault.Powershell.Models.IAlertDefinitionsTargetInternal
    {

        /// <summary>Internal Acessors for Recipients</summary>
        Commvault.Powershell.Models.IAlertDefinitionsTargetRecipients Commvault.Powershell.Models.IAlertDefinitionsTargetInternal.Recipients { get => (this._recipients = this._recipients ?? new Commvault.Powershell.Models.AlertDefinitionsTargetRecipients()); set { {_recipients = value;} } }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IAlertTargetIdNameType1> RecipientBcc { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetRecipientsInternal)Recipients).Bcc; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetRecipientsInternal)Recipients).Bcc = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IAlertTargetIdNameType1> RecipientCc { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetRecipientsInternal)Recipients).Cc; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetRecipientsInternal)Recipients).Cc = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IAlertTargetIdNameType1> RecipientTo { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetRecipientsInternal)Recipients).To; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetRecipientsInternal)Recipients).To = value ?? null /* arrayOf */; }

        /// <summary>
        /// id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list
        /// of webhooks, use api GET Webhook
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? RecipientWebHookId { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetRecipientsInternal)Recipients).WebHookId; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetRecipientsInternal)Recipients).WebHookId = value ?? default(long); }

        /// <summary>Backing field for <see cref="Recipients" /> property.</summary>
        private Commvault.Powershell.Models.IAlertDefinitionsTargetRecipients _recipients;

        /// <summary>AlertDefinitionsTargetRecipients</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IAlertDefinitionsTargetRecipients Recipients { get => (this._recipients = this._recipients ?? new Commvault.Powershell.Models.AlertDefinitionsTargetRecipients()); set => this._recipients = value; }

        /// <summary>Backing field for <see cref="RecipientsOperationType" /> property.</summary>
        private string _recipientsOperationType;

        /// <summary>
        /// Allows adding to, overwriting and deleting existing recipients. default is adding to existing recipients
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string RecipientsOperationType { get => this._recipientsOperationType; set => this._recipientsOperationType = value; }

        /// <summary>Backing field for <see cref="SendAlertTo" /> property.</summary>
        private System.Collections.Generic.List<string> _sendAlertTo;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SendAlertTo { get => this._sendAlertTo; set => this._sendAlertTo = value; }

        /// <summary>Creates an new <see cref="AlertDefinitionsTarget" /> instance.</summary>
        public AlertDefinitionsTarget()
        {

        }
    }
    /// Please note CONTENT_INDEX will be returned at all times as it is enabled at all times.
    public partial interface IAlertDefinitionsTarget :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"bcc",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAlertTargetIdNameType1) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IAlertTargetIdNameType1> RecipientBcc { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"cc",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAlertTargetIdNameType1) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IAlertTargetIdNameType1> RecipientCc { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"to",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAlertTargetIdNameType1) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IAlertTargetIdNameType1> RecipientTo { get; set; }
        /// <summary>
        /// id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list
        /// of webhooks, use api GET Webhook
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list of webhooks, use api GET Webhook",
        SerializedName = @"webHookId",
        PossibleTypes = new [] { typeof(long) })]
        long? RecipientWebHookId { get; set; }
        /// <summary>
        /// Allows adding to, overwriting and deleting existing recipients. default is adding to existing recipients
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Allows adding to, overwriting and deleting existing recipients. default is adding to existing recipients",
        SerializedName = @"recipientsOperationType",
        PossibleTypes = new [] { typeof(string) })]
        string RecipientsOperationType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"sendAlertTo",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SendAlertTo { get; set; }

    }
    /// Please note CONTENT_INDEX will be returned at all times as it is enabled at all times.
    internal partial interface IAlertDefinitionsTargetInternal

    {
        System.Collections.Generic.List<Commvault.Powershell.Models.IAlertTargetIdNameType1> RecipientBcc { get; set; }

        System.Collections.Generic.List<Commvault.Powershell.Models.IAlertTargetIdNameType1> RecipientCc { get; set; }

        System.Collections.Generic.List<Commvault.Powershell.Models.IAlertTargetIdNameType1> RecipientTo { get; set; }
        /// <summary>
        /// id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list
        /// of webhooks, use api GET Webhook
        /// </summary>
        long? RecipientWebHookId { get; set; }
        /// <summary>AlertDefinitionsTargetRecipients</summary>
        Commvault.Powershell.Models.IAlertDefinitionsTargetRecipients Recipients { get; set; }
        /// <summary>
        /// Allows adding to, overwriting and deleting existing recipients. default is adding to existing recipients
        /// </summary>
        string RecipientsOperationType { get; set; }

        System.Collections.Generic.List<string> SendAlertTo { get; set; }

    }
}
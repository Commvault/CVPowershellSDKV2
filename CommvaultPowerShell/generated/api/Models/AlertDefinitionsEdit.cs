// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>AlertDefinitionsEdit</summary>
    public partial class AlertDefinitionsEdit :
        Commvault.Powershell.Models.IAlertDefinitionsEdit,
        Commvault.Powershell.Models.IAlertDefinitionsEditInternal
    {

        /// <summary>Backing field for <see cref="AlertTarget" /> property.</summary>
        private Commvault.Powershell.Models.IAlertDefinitionsTarget _alertTarget;

        /// <summary>AlertDefinitionsTarget</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IAlertDefinitionsTarget AlertTarget { get => (this._alertTarget = this._alertTarget ?? new Commvault.Powershell.Models.AlertDefinitionsTarget()); set => this._alertTarget = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] AlertTargetSendAlertTo { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).SendAlertTo; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).SendAlertTo = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Associations" /> property.</summary>
        private Commvault.Powershell.Models.IAlertAssociationIdNameType1[] _associations;

        /// <summary>AlertDefinitionsAssociations</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IAlertAssociationIdNameType1[] Associations { get => this._associations; set => this._associations = value; }

        /// <summary>Internal Acessors for AlertTarget</summary>
        Commvault.Powershell.Models.IAlertDefinitionsTarget Commvault.Powershell.Models.IAlertDefinitionsEditInternal.AlertTarget { get => (this._alertTarget = this._alertTarget ?? new Commvault.Powershell.Models.AlertDefinitionsTarget()); set { {_alertTarget = value;} } }

        /// <summary>Internal Acessors for AlertTargetRecipients</summary>
        Commvault.Powershell.Models.IAlertDefinitionsTargetRecipients Commvault.Powershell.Models.IAlertDefinitionsEditInternal.AlertTargetRecipients { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).Recipients; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).Recipients = value; }

        /// <summary>Internal Acessors for TemplateLocale</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IAlertDefinitionsEditInternal.TemplateLocale { get => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).Locale; set => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).Locale = value; }

        /// <summary>Internal Acessors for Templates</summary>
        Commvault.Powershell.Models.IAlertDefinitionsTemplate Commvault.Powershell.Models.IAlertDefinitionsEditInternal.Templates { get => (this._templates = this._templates ?? new Commvault.Powershell.Models.AlertDefinitionsTemplate()); set { {_templates = value;} } }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? LocaleId { get => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).LocaleId; set => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).LocaleId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string LocaleName { get => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).LocaleName; set => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).LocaleName = value ?? null; }

        /// <summary>Backing field for <see cref="NewName" /> property.</summary>
        private string _newName;

        /// <summary>The new name of the alert definition</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NewName { get => this._newName; set => this._newName = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientBcc { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientBcc; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientBcc = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientCc { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientCc; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientCc = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientTo { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientTo; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientTo = value ?? null /* arrayOf */; }

        /// <summary>
        /// id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list
        /// of webhooks, use api GET Webhook
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? RecipientWebHookId { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientWebHookId; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientWebHookId = value ?? default(long); }

        /// <summary>Backing field for <see cref="SendIndividualNotifications" /> property.</summary>
        private bool? _sendIndividualNotifications;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? SendIndividualNotifications { get => this._sendIndividualNotifications; set => this._sendIndividualNotifications = value; }

        /// <summary>the message template for the console notification</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TemplateConsoleMessage { get => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).ConsoleMessage; set => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).ConsoleMessage = value ?? null; }

        /// <summary>
        /// the message template for the email notification. Contains both email subject as well as body
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TemplateEmailMessage { get => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).EmailMessage; set => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).EmailMessage = value ?? null; }

        /// <summary>the message template for the event viewer notification</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TemplateEventViewerMessage { get => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).EventViewerMessage; set => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).EventViewerMessage = value ?? null; }

        /// <summary>the message template for the webhook notification</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TemplateWebhookMessage { get => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).WebhookMessage; set => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).WebhookMessage = value ?? null; }

        /// <summary>Backing field for <see cref="Templates" /> property.</summary>
        private Commvault.Powershell.Models.IAlertDefinitionsTemplate _templates;

        /// <summary>AlertDefinitionsTemplate</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IAlertDefinitionsTemplate Templates { get => (this._templates = this._templates ?? new Commvault.Powershell.Models.AlertDefinitionsTemplate()); set => this._templates = value; }

        /// <summary>Creates an new <see cref="AlertDefinitionsEdit" /> instance.</summary>
        public AlertDefinitionsEdit()
        {

        }
    }
    /// AlertDefinitionsEdit
    public partial interface IAlertDefinitionsEdit :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sendAlertTo",
        PossibleTypes = new [] { typeof(string) })]
        string[] AlertTargetSendAlertTo { get; set; }
        /// <summary>AlertDefinitionsAssociations</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"AlertDefinitionsAssociations",
        SerializedName = @"associations",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAlertAssociationIdNameType1) })]
        Commvault.Powershell.Models.IAlertAssociationIdNameType1[] Associations { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? LocaleId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string LocaleName { get; set; }
        /// <summary>The new name of the alert definition</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The new name of the alert definition",
        SerializedName = @"newName",
        PossibleTypes = new [] { typeof(string) })]
        string NewName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"bcc",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAlertTargetIdNameType1) })]
        Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientBcc { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"cc",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAlertTargetIdNameType1) })]
        Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientCc { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"to",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAlertTargetIdNameType1) })]
        Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientTo { get; set; }
        /// <summary>
        /// id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list
        /// of webhooks, use api GET Webhook
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list of webhooks, use api GET Webhook",
        SerializedName = @"webHookId",
        PossibleTypes = new [] { typeof(long) })]
        long? RecipientWebHookId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sendIndividualNotifications",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SendIndividualNotifications { get; set; }
        /// <summary>the message template for the console notification</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the message template for the console notification",
        SerializedName = @"consoleMessage",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateConsoleMessage { get; set; }
        /// <summary>
        /// the message template for the email notification. Contains both email subject as well as body
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the message template for the email notification. Contains both email subject as well as body",
        SerializedName = @"emailMessage",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateEmailMessage { get; set; }
        /// <summary>the message template for the event viewer notification</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the message template for the event viewer notification",
        SerializedName = @"eventViewerMessage",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateEventViewerMessage { get; set; }
        /// <summary>the message template for the webhook notification</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the message template for the webhook notification",
        SerializedName = @"webhookMessage",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateWebhookMessage { get; set; }

    }
    /// AlertDefinitionsEdit
    internal partial interface IAlertDefinitionsEditInternal

    {
        /// <summary>AlertDefinitionsTarget</summary>
        Commvault.Powershell.Models.IAlertDefinitionsTarget AlertTarget { get; set; }
        /// <summary>AlertDefinitionsTargetRecipients</summary>
        Commvault.Powershell.Models.IAlertDefinitionsTargetRecipients AlertTargetRecipients { get; set; }

        string[] AlertTargetSendAlertTo { get; set; }
        /// <summary>AlertDefinitionsAssociations</summary>
        Commvault.Powershell.Models.IAlertAssociationIdNameType1[] Associations { get; set; }

        long? LocaleId { get; set; }

        string LocaleName { get; set; }
        /// <summary>The new name of the alert definition</summary>
        string NewName { get; set; }

        Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientBcc { get; set; }

        Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientCc { get; set; }

        Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientTo { get; set; }
        /// <summary>
        /// id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list
        /// of webhooks, use api GET Webhook
        /// </summary>
        long? RecipientWebHookId { get; set; }

        bool? SendIndividualNotifications { get; set; }
        /// <summary>the message template for the console notification</summary>
        string TemplateConsoleMessage { get; set; }
        /// <summary>
        /// the message template for the email notification. Contains both email subject as well as body
        /// </summary>
        string TemplateEmailMessage { get; set; }
        /// <summary>the message template for the event viewer notification</summary>
        string TemplateEventViewerMessage { get; set; }

        Commvault.Powershell.Models.IIdName TemplateLocale { get; set; }
        /// <summary>the message template for the webhook notification</summary>
        string TemplateWebhookMessage { get; set; }
        /// <summary>AlertDefinitionsTemplate</summary>
        Commvault.Powershell.Models.IAlertDefinitionsTemplate Templates { get; set; }

    }
}
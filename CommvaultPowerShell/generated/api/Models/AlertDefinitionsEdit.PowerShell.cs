// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>AlertDefinitionsEdit</summary>
    [System.ComponentModel.TypeConverter(typeof(AlertDefinitionsEditTypeConverter))]
    public partial class AlertDefinitionsEdit
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.AlertDefinitionsEdit"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AlertDefinitionsEdit(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).AlertTarget = (Commvault.Powershell.Models.IAlertDefinitionsTarget) content.GetValueForProperty("AlertTarget",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).AlertTarget, Commvault.Powershell.Models.AlertDefinitionsTargetTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).Templates = (Commvault.Powershell.Models.IAlertDefinitionsTemplate) content.GetValueForProperty("Templates",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).Templates, Commvault.Powershell.Models.AlertDefinitionsTemplateTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).NewName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).SendIndividualNotifications = (bool?) content.GetValueForProperty("SendIndividualNotifications",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).SendIndividualNotifications, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).Associations = (Commvault.Powershell.Models.IAlertAssociationIdNameType1[]) content.GetValueForProperty("Associations",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).Associations, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertAssociationIdNameType1>(__y, Commvault.Powershell.Models.AlertAssociationIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).AlertTargetRecipients = (Commvault.Powershell.Models.IAlertDefinitionsTargetRecipients) content.GetValueForProperty("AlertTargetRecipients",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).AlertTargetRecipients, Commvault.Powershell.Models.AlertDefinitionsTargetRecipientsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).AlertTargetSendAlertTo = (string[]) content.GetValueForProperty("AlertTargetSendAlertTo",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).AlertTargetSendAlertTo, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateLocale = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("TemplateLocale",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateLocale, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateEmailMessage = (string) content.GetValueForProperty("TemplateEmailMessage",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateEmailMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateConsoleMessage = (string) content.GetValueForProperty("TemplateConsoleMessage",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateConsoleMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateEventViewerMessage = (string) content.GetValueForProperty("TemplateEventViewerMessage",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateEventViewerMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateWebhookMessage = (string) content.GetValueForProperty("TemplateWebhookMessage",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateWebhookMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientTo = (Commvault.Powershell.Models.IAlertTargetIdNameType1[]) content.GetValueForProperty("RecipientTo",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientTo, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertTargetIdNameType1>(__y, Commvault.Powershell.Models.AlertTargetIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientCc = (Commvault.Powershell.Models.IAlertTargetIdNameType1[]) content.GetValueForProperty("RecipientCc",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientCc, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertTargetIdNameType1>(__y, Commvault.Powershell.Models.AlertTargetIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientBcc = (Commvault.Powershell.Models.IAlertTargetIdNameType1[]) content.GetValueForProperty("RecipientBcc",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientBcc, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertTargetIdNameType1>(__y, Commvault.Powershell.Models.AlertTargetIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientWebHookId = (long?) content.GetValueForProperty("RecipientWebHookId",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientWebHookId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).LocaleId = (long?) content.GetValueForProperty("LocaleId",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).LocaleId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).LocaleName = (string) content.GetValueForProperty("LocaleName",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).LocaleName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.AlertDefinitionsEdit"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AlertDefinitionsEdit(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).AlertTarget = (Commvault.Powershell.Models.IAlertDefinitionsTarget) content.GetValueForProperty("AlertTarget",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).AlertTarget, Commvault.Powershell.Models.AlertDefinitionsTargetTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).Templates = (Commvault.Powershell.Models.IAlertDefinitionsTemplate) content.GetValueForProperty("Templates",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).Templates, Commvault.Powershell.Models.AlertDefinitionsTemplateTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).NewName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).SendIndividualNotifications = (bool?) content.GetValueForProperty("SendIndividualNotifications",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).SendIndividualNotifications, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).Associations = (Commvault.Powershell.Models.IAlertAssociationIdNameType1[]) content.GetValueForProperty("Associations",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).Associations, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertAssociationIdNameType1>(__y, Commvault.Powershell.Models.AlertAssociationIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).AlertTargetRecipients = (Commvault.Powershell.Models.IAlertDefinitionsTargetRecipients) content.GetValueForProperty("AlertTargetRecipients",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).AlertTargetRecipients, Commvault.Powershell.Models.AlertDefinitionsTargetRecipientsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).AlertTargetSendAlertTo = (string[]) content.GetValueForProperty("AlertTargetSendAlertTo",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).AlertTargetSendAlertTo, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateLocale = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("TemplateLocale",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateLocale, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateEmailMessage = (string) content.GetValueForProperty("TemplateEmailMessage",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateEmailMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateConsoleMessage = (string) content.GetValueForProperty("TemplateConsoleMessage",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateConsoleMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateEventViewerMessage = (string) content.GetValueForProperty("TemplateEventViewerMessage",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateEventViewerMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateWebhookMessage = (string) content.GetValueForProperty("TemplateWebhookMessage",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).TemplateWebhookMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientTo = (Commvault.Powershell.Models.IAlertTargetIdNameType1[]) content.GetValueForProperty("RecipientTo",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientTo, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertTargetIdNameType1>(__y, Commvault.Powershell.Models.AlertTargetIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientCc = (Commvault.Powershell.Models.IAlertTargetIdNameType1[]) content.GetValueForProperty("RecipientCc",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientCc, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertTargetIdNameType1>(__y, Commvault.Powershell.Models.AlertTargetIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientBcc = (Commvault.Powershell.Models.IAlertTargetIdNameType1[]) content.GetValueForProperty("RecipientBcc",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientBcc, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertTargetIdNameType1>(__y, Commvault.Powershell.Models.AlertTargetIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientWebHookId = (long?) content.GetValueForProperty("RecipientWebHookId",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).RecipientWebHookId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).LocaleId = (long?) content.GetValueForProperty("LocaleId",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).LocaleId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).LocaleName = (string) content.GetValueForProperty("LocaleName",((Commvault.Powershell.Models.IAlertDefinitionsEditInternal)this).LocaleName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.AlertDefinitionsEdit"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IAlertDefinitionsEdit" />.
        /// </returns>
        public static Commvault.Powershell.Models.IAlertDefinitionsEdit DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AlertDefinitionsEdit(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.AlertDefinitionsEdit"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IAlertDefinitionsEdit" />.
        /// </returns>
        public static Commvault.Powershell.Models.IAlertDefinitionsEdit DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AlertDefinitionsEdit(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AlertDefinitionsEdit" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IAlertDefinitionsEdit FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// AlertDefinitionsEdit
    [System.ComponentModel.TypeConverter(typeof(AlertDefinitionsEditTypeConverter))]
    public partial interface IAlertDefinitionsEdit

    {

    }
}
// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>
    /// Applicable only for credentials with Cloud Account and Vendor Type as Microsoft Azure
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(AzureCredentialContentWithTenantIdTypeConverter))]
    public partial class AzureCredentialContentWithTenantId
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.AzureCredentialContentWithTenantId"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureCredentialContentWithTenantId(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Endpoints"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Endpoints = (Commvault.Powershell.Models.IAzureEndpoints) content.GetValueForProperty("Endpoints",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Endpoints, Commvault.Powershell.Models.AzureEndpointsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Security"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Security = (Commvault.Powershell.Models.ICredentialSecurity) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Security, Commvault.Powershell.Models.CredentialSecurityTypeConverter.ConvertFrom);
            }
            if (content.Contains("AuthType"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).AuthType = (string) content.GetValueForProperty("AuthType",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).AuthType, global::System.Convert.ToString);
            }
            if (content.Contains("NewName"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).NewName, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationId"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).ApplicationId = (string) content.GetValueForProperty("ApplicationId",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).ApplicationId, global::System.Convert.ToString);
            }
            if (content.Contains("NewApplicationSecret"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).NewApplicationSecret = (string) content.GetValueForProperty("NewApplicationSecret",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).NewApplicationSecret, global::System.Convert.ToString);
            }
            if (content.Contains("Environment"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Environment = (string) content.GetValueForProperty("Environment",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Environment, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Description = (string) content.GetValueForProperty("Description",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("EndpointActiveDirectory"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).EndpointActiveDirectory = (string) content.GetValueForProperty("EndpointActiveDirectory",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).EndpointActiveDirectory, global::System.Convert.ToString);
            }
            if (content.Contains("EndpointStorage"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).EndpointStorage = (string) content.GetValueForProperty("EndpointStorage",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).EndpointStorage, global::System.Convert.ToString);
            }
            if (content.Contains("EndpointResourceManager"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).EndpointResourceManager = (string) content.GetValueForProperty("EndpointResourceManager",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).EndpointResourceManager, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityOwner"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).SecurityOwner = (Commvault.Powershell.Models.ICredentialOwner) content.GetValueForProperty("SecurityOwner",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).SecurityOwner, Commvault.Powershell.Models.CredentialOwnerTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityAssociations"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).SecurityAssociations = (System.Collections.Generic.List<Commvault.Powershell.Models.ICredentialSecurityAssociations>) content.GetValueForProperty("SecurityAssociations",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).SecurityAssociations, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.ICredentialSecurityAssociations>(__y, Commvault.Powershell.Models.CredentialSecurityAssociationsTypeConverter.ConvertFrom));
            }
            if (content.Contains("OwnerUser"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).OwnerUser = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("OwnerUser",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).OwnerUser, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("OwnerUserGroup"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).OwnerUserGroup = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("OwnerUserGroup",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).OwnerUserGroup, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserId"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserId = (long?) content.GetValueForProperty("UserId",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UserName"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserName = (string) content.GetValueForProperty("UserName",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserName, global::System.Convert.ToString);
            }
            if (content.Contains("UserGroupId"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserGroupId = (long?) content.GetValueForProperty("UserGroupId",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserGroupId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UserGroupName"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserGroupName = (string) content.GetValueForProperty("UserGroupName",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserGroupName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.AzureCredentialContentWithTenantId"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureCredentialContentWithTenantId(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Endpoints"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Endpoints = (Commvault.Powershell.Models.IAzureEndpoints) content.GetValueForProperty("Endpoints",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Endpoints, Commvault.Powershell.Models.AzureEndpointsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Security"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Security = (Commvault.Powershell.Models.ICredentialSecurity) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Security, Commvault.Powershell.Models.CredentialSecurityTypeConverter.ConvertFrom);
            }
            if (content.Contains("AuthType"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).AuthType = (string) content.GetValueForProperty("AuthType",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).AuthType, global::System.Convert.ToString);
            }
            if (content.Contains("NewName"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).NewName, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationId"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).ApplicationId = (string) content.GetValueForProperty("ApplicationId",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).ApplicationId, global::System.Convert.ToString);
            }
            if (content.Contains("NewApplicationSecret"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).NewApplicationSecret = (string) content.GetValueForProperty("NewApplicationSecret",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).NewApplicationSecret, global::System.Convert.ToString);
            }
            if (content.Contains("Environment"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Environment = (string) content.GetValueForProperty("Environment",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Environment, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Description = (string) content.GetValueForProperty("Description",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("EndpointActiveDirectory"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).EndpointActiveDirectory = (string) content.GetValueForProperty("EndpointActiveDirectory",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).EndpointActiveDirectory, global::System.Convert.ToString);
            }
            if (content.Contains("EndpointStorage"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).EndpointStorage = (string) content.GetValueForProperty("EndpointStorage",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).EndpointStorage, global::System.Convert.ToString);
            }
            if (content.Contains("EndpointResourceManager"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).EndpointResourceManager = (string) content.GetValueForProperty("EndpointResourceManager",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).EndpointResourceManager, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityOwner"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).SecurityOwner = (Commvault.Powershell.Models.ICredentialOwner) content.GetValueForProperty("SecurityOwner",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).SecurityOwner, Commvault.Powershell.Models.CredentialOwnerTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityAssociations"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).SecurityAssociations = (System.Collections.Generic.List<Commvault.Powershell.Models.ICredentialSecurityAssociations>) content.GetValueForProperty("SecurityAssociations",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).SecurityAssociations, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.ICredentialSecurityAssociations>(__y, Commvault.Powershell.Models.CredentialSecurityAssociationsTypeConverter.ConvertFrom));
            }
            if (content.Contains("OwnerUser"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).OwnerUser = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("OwnerUser",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).OwnerUser, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("OwnerUserGroup"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).OwnerUserGroup = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("OwnerUserGroup",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).OwnerUserGroup, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserId"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserId = (long?) content.GetValueForProperty("UserId",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UserName"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserName = (string) content.GetValueForProperty("UserName",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserName, global::System.Convert.ToString);
            }
            if (content.Contains("UserGroupId"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserGroupId = (long?) content.GetValueForProperty("UserGroupId",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserGroupId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UserGroupName"))
            {
                ((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserGroupName = (string) content.GetValueForProperty("UserGroupName",((Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal)this).UserGroupName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.AzureCredentialContentWithTenantId"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IAzureCredentialContentWithTenantId" />.
        /// </returns>
        public static Commvault.Powershell.Models.IAzureCredentialContentWithTenantId DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureCredentialContentWithTenantId(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.AzureCredentialContentWithTenantId"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IAzureCredentialContentWithTenantId" />.
        /// </returns>
        public static Commvault.Powershell.Models.IAzureCredentialContentWithTenantId DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureCredentialContentWithTenantId(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureCredentialContentWithTenantId" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="AzureCredentialContentWithTenantId" /> model class.
        /// </returns>
        public static Commvault.Powershell.Models.IAzureCredentialContentWithTenantId FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Applicable only for credentials with Cloud Account and Vendor Type as Microsoft Azure
    [System.ComponentModel.TypeConverter(typeof(AzureCredentialContentWithTenantIdTypeConverter))]
    public partial interface IAzureCredentialContentWithTenantId

    {

    }
}
// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Get identity server response</summary>
    [System.ComponentModel.TypeConverter(typeof(IdentityServerTypeConverter))]
    public partial class IdentityServer
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.IdentityServer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IIdentityServer" />.</returns>
        public static Commvault.Powershell.Models.IIdentityServer DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new IdentityServer(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.IdentityServer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IIdentityServer" />.</returns>
        public static Commvault.Powershell.Models.IIdentityServer DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new IdentityServer(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="IdentityServer" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="IdentityServer" /> model class.</returns>
        public static Commvault.Powershell.Models.IIdentityServer FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.IdentityServer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal IdentityServer(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Company"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).Company = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Company",((Commvault.Powershell.Models.IIdentityServerInternal)this).Company, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("GlobalConfigInfo"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfo = (Commvault.Powershell.Models.IGlobalConfigInfo) content.GetValueForProperty("GlobalConfigInfo",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfo, Commvault.Powershell.Models.GlobalConfigInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IIdentityServerInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IIdentityServerInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).Type = (string) content.GetValueForProperty("Type",((Commvault.Powershell.Models.IIdentityServerInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("SamlType"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).SamlType = (string) content.GetValueForProperty("SamlType",((Commvault.Powershell.Models.IIdentityServerInternal)this).SamlType, global::System.Convert.ToString);
            }
            if (content.Contains("Configured"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).Configured = (bool?) content.GetValueForProperty("Configured",((Commvault.Powershell.Models.IIdentityServerInternal)this).Configured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GlobalConfigInfoId"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoId = (string) content.GetValueForProperty("GlobalConfigInfoId",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoId, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoName"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoName = (string) content.GetValueForProperty("GlobalConfigInfoName",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoName, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoCommcells"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoCommcells = (System.Collections.Generic.List<Commvault.Powershell.Models.IGlobalConfigCommcellInfo>) content.GetValueForProperty("GlobalConfigInfoCommcells",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoCommcells, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IGlobalConfigCommcellInfo>(__y, Commvault.Powershell.Models.GlobalConfigCommcellInfoTypeConverter.ConvertFrom));
            }
            if (content.Contains("GlobalConfigInfoScope"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoScope = (string) content.GetValueForProperty("GlobalConfigInfoScope",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoScope, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoStatus"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoStatus = (string) content.GetValueForProperty("GlobalConfigInfoStatus",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoStatus, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyId"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).CompanyId = (long?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IIdentityServerInternal)this).CompanyId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CompanyName"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IIdentityServerInternal)this).CompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoScopeFilterQuery"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoScopeFilterQuery = (string) content.GetValueForProperty("GlobalConfigInfoScopeFilterQuery",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoScopeFilterQuery, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoApplyOnAllCommCells"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoApplyOnAllCommCells = (bool?) content.GetValueForProperty("GlobalConfigInfoApplyOnAllCommCells",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoApplyOnAllCommCells, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GlobalConfigInfoIsMarkedForDeletion"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoIsMarkedForDeletion = (bool?) content.GetValueForProperty("GlobalConfigInfoIsMarkedForDeletion",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoIsMarkedForDeletion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.IdentityServer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal IdentityServer(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Company"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).Company = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Company",((Commvault.Powershell.Models.IIdentityServerInternal)this).Company, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("GlobalConfigInfo"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfo = (Commvault.Powershell.Models.IGlobalConfigInfo) content.GetValueForProperty("GlobalConfigInfo",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfo, Commvault.Powershell.Models.GlobalConfigInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IIdentityServerInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IIdentityServerInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).Type = (string) content.GetValueForProperty("Type",((Commvault.Powershell.Models.IIdentityServerInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("SamlType"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).SamlType = (string) content.GetValueForProperty("SamlType",((Commvault.Powershell.Models.IIdentityServerInternal)this).SamlType, global::System.Convert.ToString);
            }
            if (content.Contains("Configured"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).Configured = (bool?) content.GetValueForProperty("Configured",((Commvault.Powershell.Models.IIdentityServerInternal)this).Configured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GlobalConfigInfoId"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoId = (string) content.GetValueForProperty("GlobalConfigInfoId",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoId, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoName"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoName = (string) content.GetValueForProperty("GlobalConfigInfoName",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoName, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoCommcells"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoCommcells = (System.Collections.Generic.List<Commvault.Powershell.Models.IGlobalConfigCommcellInfo>) content.GetValueForProperty("GlobalConfigInfoCommcells",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoCommcells, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IGlobalConfigCommcellInfo>(__y, Commvault.Powershell.Models.GlobalConfigCommcellInfoTypeConverter.ConvertFrom));
            }
            if (content.Contains("GlobalConfigInfoScope"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoScope = (string) content.GetValueForProperty("GlobalConfigInfoScope",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoScope, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoStatus"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoStatus = (string) content.GetValueForProperty("GlobalConfigInfoStatus",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoStatus, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyId"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).CompanyId = (long?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IIdentityServerInternal)this).CompanyId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CompanyName"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IIdentityServerInternal)this).CompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoScopeFilterQuery"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoScopeFilterQuery = (string) content.GetValueForProperty("GlobalConfigInfoScopeFilterQuery",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoScopeFilterQuery, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoApplyOnAllCommCells"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoApplyOnAllCommCells = (bool?) content.GetValueForProperty("GlobalConfigInfoApplyOnAllCommCells",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoApplyOnAllCommCells, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GlobalConfigInfoIsMarkedForDeletion"))
            {
                ((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoIsMarkedForDeletion = (bool?) content.GetValueForProperty("GlobalConfigInfoIsMarkedForDeletion",((Commvault.Powershell.Models.IIdentityServerInternal)this).GlobalConfigInfoIsMarkedForDeletion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

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
    /// Get identity server response
    [System.ComponentModel.TypeConverter(typeof(IdentityServerTypeConverter))]
    public partial interface IIdentityServer

    {

    }
}
// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(UpdateRoleTypeConverter))]
    public partial class UpdateRole
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.UpdateRole"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IUpdateRole" />.</returns>
        public static Commvault.Powershell.Models.IUpdateRole DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UpdateRole(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.UpdateRole"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IUpdateRole" />.</returns>
        public static Commvault.Powershell.Models.IUpdateRole DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UpdateRole(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UpdateRole" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="UpdateRole" /> model class.</returns>
        public static Commvault.Powershell.Models.IUpdateRole FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.UpdateRole"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UpdateRole(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NewName"))
            {
                ((Commvault.Powershell.Models.IUpdateRoleInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IUpdateRoleInternal)this).NewName, global::System.Convert.ToString);
            }
            if (content.Contains("PermissionList"))
            {
                ((Commvault.Powershell.Models.IUpdateRoleInternal)this).PermissionList = (System.Collections.Generic.List<Commvault.Powershell.Models.IPermissions>) content.GetValueForProperty("PermissionList",((Commvault.Powershell.Models.IUpdateRoleInternal)this).PermissionList, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IPermissions>(__y, Commvault.Powershell.Models.PermissionsTypeConverter.ConvertFrom));
            }
            if (content.Contains("PermissionOperationType"))
            {
                ((Commvault.Powershell.Models.IUpdateRoleInternal)this).PermissionOperationType = (string) content.GetValueForProperty("PermissionOperationType",((Commvault.Powershell.Models.IUpdateRoleInternal)this).PermissionOperationType, global::System.Convert.ToString);
            }
            if (content.Contains("Enabled"))
            {
                ((Commvault.Powershell.Models.IUpdateRoleInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Commvault.Powershell.Models.IUpdateRoleInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VisibleToAll"))
            {
                ((Commvault.Powershell.Models.IUpdateRoleInternal)this).VisibleToAll = (bool?) content.GetValueForProperty("VisibleToAll",((Commvault.Powershell.Models.IUpdateRoleInternal)this).VisibleToAll, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Security"))
            {
                ((Commvault.Powershell.Models.IUpdateRoleInternal)this).Security = (System.Collections.Generic.List<Commvault.Powershell.Models.IUpdateSecurityAssoc>) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IUpdateRoleInternal)this).Security, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IUpdateSecurityAssoc>(__y, Commvault.Powershell.Models.UpdateSecurityAssocTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.UpdateRole"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UpdateRole(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NewName"))
            {
                ((Commvault.Powershell.Models.IUpdateRoleInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IUpdateRoleInternal)this).NewName, global::System.Convert.ToString);
            }
            if (content.Contains("PermissionList"))
            {
                ((Commvault.Powershell.Models.IUpdateRoleInternal)this).PermissionList = (System.Collections.Generic.List<Commvault.Powershell.Models.IPermissions>) content.GetValueForProperty("PermissionList",((Commvault.Powershell.Models.IUpdateRoleInternal)this).PermissionList, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IPermissions>(__y, Commvault.Powershell.Models.PermissionsTypeConverter.ConvertFrom));
            }
            if (content.Contains("PermissionOperationType"))
            {
                ((Commvault.Powershell.Models.IUpdateRoleInternal)this).PermissionOperationType = (string) content.GetValueForProperty("PermissionOperationType",((Commvault.Powershell.Models.IUpdateRoleInternal)this).PermissionOperationType, global::System.Convert.ToString);
            }
            if (content.Contains("Enabled"))
            {
                ((Commvault.Powershell.Models.IUpdateRoleInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Commvault.Powershell.Models.IUpdateRoleInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VisibleToAll"))
            {
                ((Commvault.Powershell.Models.IUpdateRoleInternal)this).VisibleToAll = (bool?) content.GetValueForProperty("VisibleToAll",((Commvault.Powershell.Models.IUpdateRoleInternal)this).VisibleToAll, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Security"))
            {
                ((Commvault.Powershell.Models.IUpdateRoleInternal)this).Security = (System.Collections.Generic.List<Commvault.Powershell.Models.IUpdateSecurityAssoc>) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IUpdateRoleInternal)this).Security, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IUpdateSecurityAssoc>(__y, Commvault.Powershell.Models.UpdateSecurityAssocTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }
    }
    [System.ComponentModel.TypeConverter(typeof(UpdateRoleTypeConverter))]
    public partial interface IUpdateRole

    {

    }
}
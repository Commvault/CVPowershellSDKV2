// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>
    /// Replication options for Azure. Provide both of the name and the guid of the source VM and provide the id and the name
    /// of the security group
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(OverrideReplicationOptionsAzureCreateTypeConverter))]
    public partial class OverrideReplicationOptionsAzureCreate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.OverrideReplicationOptionsAzureCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreate" />.
        /// </returns>
        public static Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OverrideReplicationOptionsAzureCreate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.OverrideReplicationOptionsAzureCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreate" />.
        /// </returns>
        public static Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OverrideReplicationOptionsAzureCreate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OverrideReplicationOptionsAzureCreate" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="OverrideReplicationOptionsAzureCreate" /> model class.
        /// </returns>
        public static Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreate FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.OverrideReplicationOptionsAzureCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OverrideReplicationOptionsAzureCreate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SourceVM"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SourceVM = (Commvault.Powershell.Models.INameGuid) content.GetValueForProperty("SourceVM",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SourceVM, Commvault.Powershell.Models.NameGuidTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityGroup"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SecurityGroup = (Commvault.Powershell.Models.ISecurityGroup) content.GetValueForProperty("SecurityGroup",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SecurityGroup, Commvault.Powershell.Models.SecurityGroupTypeConverter.ConvertFrom);
            }
            if (content.Contains("VMDisplayName"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).VMDisplayName = (string) content.GetValueForProperty("VMDisplayName",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).VMDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroup"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).ResourceGroup = (string) content.GetValueForProperty("ResourceGroup",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).ResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("Region"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).Region = (string) content.GetValueForProperty("Region",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).Region, global::System.Convert.ToString);
            }
            if (content.Contains("StorageAccount"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).StorageAccount = (string) content.GetValueForProperty("StorageAccount",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).StorageAccount, global::System.Convert.ToString);
            }
            if (content.Contains("VMSizeId"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).VMSizeId = (string) content.GetValueForProperty("VMSizeId",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).VMSizeId, global::System.Convert.ToString);
            }
            if (content.Contains("DiskTypeId"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).DiskTypeId = (string) content.GetValueForProperty("DiskTypeId",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).DiskTypeId, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetwork"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).VirtualNetwork = (System.Collections.Generic.List<Commvault.Powershell.Models.INetworkSubnet>) content.GetValueForProperty("VirtualNetwork",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).VirtualNetwork, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.INetworkSubnet>(__y, Commvault.Powershell.Models.NetworkSubnetTypeConverter.ConvertFrom));
            }
            if (content.Contains("CreatePublicIP"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).CreatePublicIP = (bool?) content.GetValueForProperty("CreatePublicIP",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).CreatePublicIP, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RestoreAsManagedVM"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).RestoreAsManagedVM = (bool?) content.GetValueForProperty("RestoreAsManagedVM",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).RestoreAsManagedVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PrivateIPaddress"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).PrivateIPaddress = (string) content.GetValueForProperty("PrivateIPaddress",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).PrivateIPaddress, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPaddress"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).PublicIPaddress = (string) content.GetValueForProperty("PublicIPaddress",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).PublicIPaddress, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPaddressId"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).PublicIPaddressId = (string) content.GetValueForProperty("PublicIPaddressId",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).PublicIPaddressId, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityGroupId"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SecurityGroupId = (string) content.GetValueForProperty("SecurityGroupId",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SecurityGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityGroupName"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SecurityGroupName = (string) content.GetValueForProperty("SecurityGroupName",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SecurityGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceVMGuid"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SourceVMGuid = (string) content.GetValueForProperty("SourceVMGuid",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SourceVMGuid, global::System.Convert.ToString);
            }
            if (content.Contains("SourceVMName"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SourceVMName = (string) content.GetValueForProperty("SourceVMName",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SourceVMName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.OverrideReplicationOptionsAzureCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OverrideReplicationOptionsAzureCreate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SourceVM"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SourceVM = (Commvault.Powershell.Models.INameGuid) content.GetValueForProperty("SourceVM",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SourceVM, Commvault.Powershell.Models.NameGuidTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityGroup"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SecurityGroup = (Commvault.Powershell.Models.ISecurityGroup) content.GetValueForProperty("SecurityGroup",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SecurityGroup, Commvault.Powershell.Models.SecurityGroupTypeConverter.ConvertFrom);
            }
            if (content.Contains("VMDisplayName"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).VMDisplayName = (string) content.GetValueForProperty("VMDisplayName",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).VMDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroup"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).ResourceGroup = (string) content.GetValueForProperty("ResourceGroup",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).ResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("Region"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).Region = (string) content.GetValueForProperty("Region",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).Region, global::System.Convert.ToString);
            }
            if (content.Contains("StorageAccount"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).StorageAccount = (string) content.GetValueForProperty("StorageAccount",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).StorageAccount, global::System.Convert.ToString);
            }
            if (content.Contains("VMSizeId"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).VMSizeId = (string) content.GetValueForProperty("VMSizeId",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).VMSizeId, global::System.Convert.ToString);
            }
            if (content.Contains("DiskTypeId"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).DiskTypeId = (string) content.GetValueForProperty("DiskTypeId",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).DiskTypeId, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetwork"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).VirtualNetwork = (System.Collections.Generic.List<Commvault.Powershell.Models.INetworkSubnet>) content.GetValueForProperty("VirtualNetwork",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).VirtualNetwork, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.INetworkSubnet>(__y, Commvault.Powershell.Models.NetworkSubnetTypeConverter.ConvertFrom));
            }
            if (content.Contains("CreatePublicIP"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).CreatePublicIP = (bool?) content.GetValueForProperty("CreatePublicIP",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).CreatePublicIP, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RestoreAsManagedVM"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).RestoreAsManagedVM = (bool?) content.GetValueForProperty("RestoreAsManagedVM",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).RestoreAsManagedVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PrivateIPaddress"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).PrivateIPaddress = (string) content.GetValueForProperty("PrivateIPaddress",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).PrivateIPaddress, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPaddress"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).PublicIPaddress = (string) content.GetValueForProperty("PublicIPaddress",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).PublicIPaddress, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPaddressId"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).PublicIPaddressId = (string) content.GetValueForProperty("PublicIPaddressId",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).PublicIPaddressId, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityGroupId"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SecurityGroupId = (string) content.GetValueForProperty("SecurityGroupId",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SecurityGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityGroupName"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SecurityGroupName = (string) content.GetValueForProperty("SecurityGroupName",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SecurityGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceVMGuid"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SourceVMGuid = (string) content.GetValueForProperty("SourceVMGuid",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SourceVMGuid, global::System.Convert.ToString);
            }
            if (content.Contains("SourceVMName"))
            {
                ((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SourceVMName = (string) content.GetValueForProperty("SourceVMName",((Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreateInternal)this).SourceVMName, global::System.Convert.ToString);
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
    /// Replication options for Azure. Provide both of the name and the guid of the source VM and provide the id and the name
    /// of the security group
    [System.ComponentModel.TypeConverter(typeof(OverrideReplicationOptionsAzureCreateTypeConverter))]
    public partial interface IOverrideReplicationOptionsAzureCreate

    {

    }
}
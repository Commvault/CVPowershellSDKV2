// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Returns the details of of the user whose userId has been provided</summary>
    [System.ComponentModel.TypeConverter(typeof(UserTypeConverter))]
    public partial class User
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.User"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IUser" />.</returns>
        public static Commvault.Powershell.Models.IUser DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new User(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.User"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IUser" />.</returns>
        public static Commvault.Powershell.Models.IUser DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new User(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="User" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IUser FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.User"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal User(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IUserInternal)this).LockInfo = (Commvault.Powershell.Models.ILockProperties) content.GetValueForProperty("LockInfo",((Commvault.Powershell.Models.IUserInternal)this).LockInfo, Commvault.Powershell.Models.LockPropertiesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUserInternal)this).Company = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Company",((Commvault.Powershell.Models.IUserInternal)this).Company, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUserInternal)this).Plan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Plan",((Commvault.Powershell.Models.IUserInternal)this).Plan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUserInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IUserInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IUserInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IUserInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).Guid = (string) content.GetValueForProperty("Guid",((Commvault.Powershell.Models.IUserInternal)this).Guid, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).FullName = (string) content.GetValueForProperty("FullName",((Commvault.Powershell.Models.IUserInternal)this).FullName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).Email = (string) content.GetValueForProperty("Email",((Commvault.Powershell.Models.IUserInternal)this).Email, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Commvault.Powershell.Models.IUserInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUserInternal)this).Description = (string) content.GetValueForProperty("Description",((Commvault.Powershell.Models.IUserInternal)this).Description, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).ServiceType = (string) content.GetValueForProperty("ServiceType",((Commvault.Powershell.Models.IUserInternal)this).ServiceType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).LastLoggedIn = (long?) content.GetValueForProperty("LastLoggedIn",((Commvault.Powershell.Models.IUserInternal)this).LastLoggedIn, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IUserInternal)this).AuthenticationMethod = (string) content.GetValueForProperty("AuthenticationMethod",((Commvault.Powershell.Models.IUserInternal)this).AuthenticationMethod, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).AssociatedUserGroups = (Commvault.Powershell.Models.IIdNameProvider[]) content.GetValueForProperty("AssociatedUserGroups",((Commvault.Powershell.Models.IUserInternal)this).AssociatedUserGroups, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdNameProvider>(__y, Commvault.Powershell.Models.IdNameProviderTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUserInternal)this).UserPrincipalName = (string) content.GetValueForProperty("UserPrincipalName",((Commvault.Powershell.Models.IUserInternal)this).UserPrincipalName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).LockInfoIsLocked = (bool?) content.GetValueForProperty("LockInfoIsLocked",((Commvault.Powershell.Models.IUserInternal)this).LockInfoIsLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUserInternal)this).LockInfoStartTime = (long?) content.GetValueForProperty("LockInfoStartTime",((Commvault.Powershell.Models.IUserInternal)this).LockInfoStartTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IUserInternal)this).LockInfoEndTime = (long?) content.GetValueForProperty("LockInfoEndTime",((Commvault.Powershell.Models.IUserInternal)this).LockInfoEndTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IUserInternal)this).CompanyId = (long?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IUserInternal)this).CompanyId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IUserInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IUserInternal)this).CompanyName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).PlanId = (long?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.IUserInternal)this).PlanId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IUserInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IUserInternal)this).PlanName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.User"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal User(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IUserInternal)this).LockInfo = (Commvault.Powershell.Models.ILockProperties) content.GetValueForProperty("LockInfo",((Commvault.Powershell.Models.IUserInternal)this).LockInfo, Commvault.Powershell.Models.LockPropertiesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUserInternal)this).Company = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Company",((Commvault.Powershell.Models.IUserInternal)this).Company, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUserInternal)this).Plan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Plan",((Commvault.Powershell.Models.IUserInternal)this).Plan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUserInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IUserInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IUserInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IUserInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).Guid = (string) content.GetValueForProperty("Guid",((Commvault.Powershell.Models.IUserInternal)this).Guid, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).FullName = (string) content.GetValueForProperty("FullName",((Commvault.Powershell.Models.IUserInternal)this).FullName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).Email = (string) content.GetValueForProperty("Email",((Commvault.Powershell.Models.IUserInternal)this).Email, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Commvault.Powershell.Models.IUserInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUserInternal)this).Description = (string) content.GetValueForProperty("Description",((Commvault.Powershell.Models.IUserInternal)this).Description, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).ServiceType = (string) content.GetValueForProperty("ServiceType",((Commvault.Powershell.Models.IUserInternal)this).ServiceType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).LastLoggedIn = (long?) content.GetValueForProperty("LastLoggedIn",((Commvault.Powershell.Models.IUserInternal)this).LastLoggedIn, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IUserInternal)this).AuthenticationMethod = (string) content.GetValueForProperty("AuthenticationMethod",((Commvault.Powershell.Models.IUserInternal)this).AuthenticationMethod, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).AssociatedUserGroups = (Commvault.Powershell.Models.IIdNameProvider[]) content.GetValueForProperty("AssociatedUserGroups",((Commvault.Powershell.Models.IUserInternal)this).AssociatedUserGroups, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdNameProvider>(__y, Commvault.Powershell.Models.IdNameProviderTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUserInternal)this).UserPrincipalName = (string) content.GetValueForProperty("UserPrincipalName",((Commvault.Powershell.Models.IUserInternal)this).UserPrincipalName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).LockInfoIsLocked = (bool?) content.GetValueForProperty("LockInfoIsLocked",((Commvault.Powershell.Models.IUserInternal)this).LockInfoIsLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUserInternal)this).LockInfoStartTime = (long?) content.GetValueForProperty("LockInfoStartTime",((Commvault.Powershell.Models.IUserInternal)this).LockInfoStartTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IUserInternal)this).LockInfoEndTime = (long?) content.GetValueForProperty("LockInfoEndTime",((Commvault.Powershell.Models.IUserInternal)this).LockInfoEndTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IUserInternal)this).CompanyId = (long?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IUserInternal)this).CompanyId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IUserInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IUserInternal)this).CompanyName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUserInternal)this).PlanId = (long?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.IUserInternal)this).PlanId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IUserInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IUserInternal)this).PlanName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// Returns the details of of the user whose userId has been provided
    [System.ComponentModel.TypeConverter(typeof(UserTypeConverter))]
    public partial interface IUser

    {

    }
}
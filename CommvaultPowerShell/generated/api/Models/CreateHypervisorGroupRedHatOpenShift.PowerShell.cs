// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Create a hypervisor group with openShift as the destination vendor</summary>
    [System.ComponentModel.TypeConverter(typeof(CreateHypervisorGroupRedHatOpenShiftTypeConverter))]
    public partial class CreateHypervisorGroupRedHatOpenShift
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.CreateHypervisorGroupRedHatOpenShift"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CreateHypervisorGroupRedHatOpenShift(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("GlusterHostCredentials"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentials = (Commvault.Powershell.Models.IRedHatOpenShiftGluster) content.GetValueForProperty("GlusterHostCredentials",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentials, Commvault.Powershell.Models.RedHatOpenShiftGlusterTypeConverter.ConvertFrom);
            }
            if (content.Contains("HypervisorType"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).HypervisorType = (string) content.GetValueForProperty("HypervisorType",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).HypervisorType, global::System.Convert.ToString);
            }
            if (content.Contains("ServerName"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).ServerName = (string) content.GetValueForProperty("ServerName",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).ServerName, global::System.Convert.ToString);
            }
            if (content.Contains("UserName"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).UserName = (string) content.GetValueForProperty("UserName",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).UserName, global::System.Convert.ToString);
            }
            if (content.Contains("Password"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).Password = (string) content.GetValueForProperty("Password",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).Password, global::System.Convert.ToString);
            }
            if (content.Contains("CredentialsId"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsId = (long?) content.GetValueForProperty("CredentialsId",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CredentialsName"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsName = (string) content.GetValueForProperty("CredentialsName",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsName, global::System.Convert.ToString);
            }
            if (content.Contains("EtcdProtectionPlan"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).EtcdProtectionPlan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("EtcdProtectionPlan",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).EtcdProtectionPlan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("EtcdProtectionEnabled"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).EtcdProtectionEnabled = (bool?) content.GetValueForProperty("EtcdProtectionEnabled",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).EtcdProtectionEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PlanEntityId"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanEntityId = (long?) content.GetValueForProperty("PlanEntityId",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanEntityId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PlanEntityName"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanEntityName = (string) content.GetValueForProperty("PlanEntityName",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanEntityName, global::System.Convert.ToString);
            }
            if (content.Contains("PlanId"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanId = (long?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PlanName"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanName, global::System.Convert.ToString);
            }
            if (content.Contains("Credentials"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Credentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Credentials",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Credentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("EtcdProtection"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).EtcdProtection = (Commvault.Powershell.Models.IEtcdProtectionItem) content.GetValueForProperty("EtcdProtection",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).EtcdProtection, Commvault.Powershell.Models.EtcdProtectionItemTypeConverter.ConvertFrom);
            }
            if (content.Contains("PlanEntity"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanEntity = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("PlanEntity",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanEntity, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("SkipCredentialValidation"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).SkipCredentialValidation = (bool?) content.GetValueForProperty("SkipCredentialValidation",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).SkipCredentialValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AccessNodes"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).AccessNodes = (System.Collections.Generic.List<Commvault.Powershell.Models.IAccessNodeModel>) content.GetValueForProperty("AccessNodes",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).AccessNodes, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IAccessNodeModel>(__y, Commvault.Powershell.Models.AccessNodeModelTypeConverter.ConvertFrom));
            }
            if (content.Contains("GlusterHostCredentialsCredentials"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsCredentials = (Commvault.Powershell.Models.IUserNamePassword) content.GetValueForProperty("GlusterHostCredentialsCredentials",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsCredentials, Commvault.Powershell.Models.UserNamePasswordTypeConverter.ConvertFrom);
            }
            if (content.Contains("GlusterHostCredentialsHostName"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsHostName = (string) content.GetValueForProperty("GlusterHostCredentialsHostName",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsHostName, global::System.Convert.ToString);
            }
            if (content.Contains("GlusterHostCredentialsAuthType"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsAuthType = (long?) content.GetValueForProperty("GlusterHostCredentialsAuthType",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsAuthType, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("GlusterHostCredentialsCredentialsName"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsCredentialsName = (string) content.GetValueForProperty("GlusterHostCredentialsCredentialsName",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsCredentialsName, global::System.Convert.ToString);
            }
            if (content.Contains("CredentialsPassword"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).CredentialsPassword = (string) content.GetValueForProperty("CredentialsPassword",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).CredentialsPassword, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.CreateHypervisorGroupRedHatOpenShift"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CreateHypervisorGroupRedHatOpenShift(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("GlusterHostCredentials"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentials = (Commvault.Powershell.Models.IRedHatOpenShiftGluster) content.GetValueForProperty("GlusterHostCredentials",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentials, Commvault.Powershell.Models.RedHatOpenShiftGlusterTypeConverter.ConvertFrom);
            }
            if (content.Contains("HypervisorType"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).HypervisorType = (string) content.GetValueForProperty("HypervisorType",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).HypervisorType, global::System.Convert.ToString);
            }
            if (content.Contains("ServerName"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).ServerName = (string) content.GetValueForProperty("ServerName",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).ServerName, global::System.Convert.ToString);
            }
            if (content.Contains("UserName"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).UserName = (string) content.GetValueForProperty("UserName",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).UserName, global::System.Convert.ToString);
            }
            if (content.Contains("Password"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).Password = (string) content.GetValueForProperty("Password",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).Password, global::System.Convert.ToString);
            }
            if (content.Contains("CredentialsId"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsId = (long?) content.GetValueForProperty("CredentialsId",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CredentialsName"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsName = (string) content.GetValueForProperty("CredentialsName",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsName, global::System.Convert.ToString);
            }
            if (content.Contains("EtcdProtectionPlan"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).EtcdProtectionPlan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("EtcdProtectionPlan",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).EtcdProtectionPlan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("EtcdProtectionEnabled"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).EtcdProtectionEnabled = (bool?) content.GetValueForProperty("EtcdProtectionEnabled",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).EtcdProtectionEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PlanEntityId"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanEntityId = (long?) content.GetValueForProperty("PlanEntityId",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanEntityId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PlanEntityName"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanEntityName = (string) content.GetValueForProperty("PlanEntityName",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanEntityName, global::System.Convert.ToString);
            }
            if (content.Contains("PlanId"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanId = (long?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PlanName"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanName, global::System.Convert.ToString);
            }
            if (content.Contains("Credentials"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Credentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Credentials",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Credentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("EtcdProtection"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).EtcdProtection = (Commvault.Powershell.Models.IEtcdProtectionItem) content.GetValueForProperty("EtcdProtection",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).EtcdProtection, Commvault.Powershell.Models.EtcdProtectionItemTypeConverter.ConvertFrom);
            }
            if (content.Contains("PlanEntity"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanEntity = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("PlanEntity",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).PlanEntity, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("SkipCredentialValidation"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).SkipCredentialValidation = (bool?) content.GetValueForProperty("SkipCredentialValidation",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).SkipCredentialValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AccessNodes"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).AccessNodes = (System.Collections.Generic.List<Commvault.Powershell.Models.IAccessNodeModel>) content.GetValueForProperty("AccessNodes",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).AccessNodes, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IAccessNodeModel>(__y, Commvault.Powershell.Models.AccessNodeModelTypeConverter.ConvertFrom));
            }
            if (content.Contains("GlusterHostCredentialsCredentials"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsCredentials = (Commvault.Powershell.Models.IUserNamePassword) content.GetValueForProperty("GlusterHostCredentialsCredentials",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsCredentials, Commvault.Powershell.Models.UserNamePasswordTypeConverter.ConvertFrom);
            }
            if (content.Contains("GlusterHostCredentialsHostName"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsHostName = (string) content.GetValueForProperty("GlusterHostCredentialsHostName",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsHostName, global::System.Convert.ToString);
            }
            if (content.Contains("GlusterHostCredentialsAuthType"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsAuthType = (long?) content.GetValueForProperty("GlusterHostCredentialsAuthType",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsAuthType, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("GlusterHostCredentialsCredentialsName"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsCredentialsName = (string) content.GetValueForProperty("GlusterHostCredentialsCredentialsName",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).GlusterHostCredentialsCredentialsName, global::System.Convert.ToString);
            }
            if (content.Contains("CredentialsPassword"))
            {
                ((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).CredentialsPassword = (string) content.GetValueForProperty("CredentialsPassword",((Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShiftInternal)this).CredentialsPassword, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.CreateHypervisorGroupRedHatOpenShift"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShift" />.
        /// </returns>
        public static Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShift DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CreateHypervisorGroupRedHatOpenShift(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.CreateHypervisorGroupRedHatOpenShift"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShift" />.
        /// </returns>
        public static Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShift DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CreateHypervisorGroupRedHatOpenShift(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CreateHypervisorGroupRedHatOpenShift" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="CreateHypervisorGroupRedHatOpenShift" /> model class.
        /// </returns>
        public static Commvault.Powershell.Models.ICreateHypervisorGroupRedHatOpenShift FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Create a hypervisor group with openShift as the destination vendor
    [System.ComponentModel.TypeConverter(typeof(CreateHypervisorGroupRedHatOpenShiftTypeConverter))]
    public partial interface ICreateHypervisorGroupRedHatOpenShift

    {

    }
}
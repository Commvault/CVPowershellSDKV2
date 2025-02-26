// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Used to return details of a company whose companyId has been provided</summary>
    [System.ComponentModel.TypeConverter(typeof(CompanyTypeConverter))]
    public partial class Company
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.Company"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Company(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("General"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).General = (Commvault.Powershell.Models.IGeneral) content.GetValueForProperty("General",((Commvault.Powershell.Models.ICompanyInternal)this).General, Commvault.Powershell.Models.GeneralTypeConverter.ConvertFrom);
            }
            if (content.Contains("EmailSettings"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).EmailSettings = (Commvault.Powershell.Models.IEmailSettings) content.GetValueForProperty("EmailSettings",((Commvault.Powershell.Models.ICompanyInternal)this).EmailSettings, Commvault.Powershell.Models.EmailSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sites"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).Sites = (Commvault.Powershell.Models.ISites) content.GetValueForProperty("Sites",((Commvault.Powershell.Models.ICompanyInternal)this).Sites, Commvault.Powershell.Models.SitesTypeConverter.ConvertFrom);
            }
            if (content.Contains("FileExceptions"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptions = (Commvault.Powershell.Models.IFileExceptions) content.GetValueForProperty("FileExceptions",((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptions, Commvault.Powershell.Models.FileExceptionsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.ICompanyInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CreationTime"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).CreationTime = (long?) content.GetValueForProperty("CreationTime",((Commvault.Powershell.Models.ICompanyInternal)this).CreationTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Security"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).Security = (System.Collections.Generic.List<Commvault.Powershell.Models.ISecurityAssoc>) content.GetValueForProperty("Security",((Commvault.Powershell.Models.ICompanyInternal)this).Security, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.ISecurityAssoc>(__y, Commvault.Powershell.Models.SecurityAssocTypeConverter.ConvertFrom));
            }
            if (content.Contains("Contacts"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).Contacts = (System.Collections.Generic.List<Commvault.Powershell.Models.IContactResp>) content.GetValueForProperty("Contacts",((Commvault.Powershell.Models.ICompanyInternal)this).Contacts, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IContactResp>(__y, Commvault.Powershell.Models.ContactRespTypeConverter.ConvertFrom));
            }
            if (content.Contains("Plans"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).Plans = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>) content.GetValueForProperty("Plans",((Commvault.Powershell.Models.ICompanyInternal)this).Plans, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            }
            if (content.Contains("OperatorsOperationType"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).OperatorsOperationType = (long?) content.GetValueForProperty("OperatorsOperationType",((Commvault.Powershell.Models.ICompanyInternal)this).OperatorsOperationType, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TenantOperators"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).TenantOperators = (System.Collections.Generic.List<Commvault.Powershell.Models.ITenantOperator>) content.GetValueForProperty("TenantOperators",((Commvault.Powershell.Models.ICompanyInternal)this).TenantOperators, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.ITenantOperator>(__y, Commvault.Powershell.Models.TenantOperatorTypeConverter.ConvertFrom));
            }
            if (content.Contains("GeneralNewAlias"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralNewAlias = (string) content.GetValueForProperty("GeneralNewAlias",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralNewAlias, global::System.Convert.ToString);
            }
            if (content.Contains("GeneralEmailSuffix"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralEmailSuffix = (string) content.GetValueForProperty("GeneralEmailSuffix",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralEmailSuffix, global::System.Convert.ToString);
            }
            if (content.Contains("GeneralSupportedSolutions"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralSupportedSolutions = (System.Collections.Generic.List<string>) content.GetValueForProperty("GeneralSupportedSolutions",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralSupportedSolutions, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("GeneralServiceCommcells"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralServiceCommcells = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>) content.GetValueForProperty("GeneralServiceCommcells",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralServiceCommcells, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            }
            if (content.Contains("EmailSettingSenderName"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).EmailSettingSenderName = (string) content.GetValueForProperty("EmailSettingSenderName",((Commvault.Powershell.Models.ICompanyInternal)this).EmailSettingSenderName, global::System.Convert.ToString);
            }
            if (content.Contains("EmailSettingSenderEmail"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).EmailSettingSenderEmail = (string) content.GetValueForProperty("EmailSettingSenderEmail",((Commvault.Powershell.Models.ICompanyInternal)this).EmailSettingSenderEmail, global::System.Convert.ToString);
            }
            if (content.Contains("FileExceptionWindows"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptionWindows = (string) content.GetValueForProperty("FileExceptionWindows",((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptionWindows, global::System.Convert.ToString);
            }
            if (content.Contains("FileExceptionUnix"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptionUnix = (string) content.GetValueForProperty("FileExceptionUnix",((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptionUnix, global::System.Convert.ToString);
            }
            if (content.Contains("GeneralTwoFactorAuth"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralTwoFactorAuth = (Commvault.Powershell.Models.ITwoFactorAuth) content.GetValueForProperty("GeneralTwoFactorAuth",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralTwoFactorAuth, Commvault.Powershell.Models.TwoFactorAuthTypeConverter.ConvertFrom);
            }
            if (content.Contains("GeneralAuthcodeForInstallation"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralAuthcodeForInstallation = (bool?) content.GetValueForProperty("GeneralAuthcodeForInstallation",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralAuthcodeForInstallation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GeneralUpnInsteadOfEmail"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralUpnInsteadOfEmail = (bool?) content.GetValueForProperty("GeneralUpnInsteadOfEmail",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralUpnInsteadOfEmail, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GeneralResellerMode"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralResellerMode = (bool?) content.GetValueForProperty("GeneralResellerMode",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralResellerMode, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GeneralEnableDataEncryption"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralEnableDataEncryption = (bool?) content.GetValueForProperty("GeneralEnableDataEncryption",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralEnableDataEncryption, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GeneralAutoDiscoverApp"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralAutoDiscoverApp = (bool?) content.GetValueForProperty("GeneralAutoDiscoverApp",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralAutoDiscoverApp, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GeneralInfrastructureType"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralInfrastructureType = (string) content.GetValueForProperty("GeneralInfrastructureType",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralInfrastructureType, global::System.Convert.ToString);
            }
            if (content.Contains("GeneralAssignLaptopOwners"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralAssignLaptopOwners = (string) content.GetValueForProperty("GeneralAssignLaptopOwners",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralAssignLaptopOwners, global::System.Convert.ToString);
            }
            if (content.Contains("TwoFactorAuthUserGroups"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).TwoFactorAuthUserGroups = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>) content.GetValueForProperty("TwoFactorAuthUserGroups",((Commvault.Powershell.Models.ICompanyInternal)this).TwoFactorAuthUserGroups, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            }
            if (content.Contains("SitePrimarySiteName"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).SitePrimarySiteName = (string) content.GetValueForProperty("SitePrimarySiteName",((Commvault.Powershell.Models.ICompanyInternal)this).SitePrimarySiteName, global::System.Convert.ToString);
            }
            if (content.Contains("SiteSecondarySiteNames"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).SiteSecondarySiteNames = (System.Collections.Generic.List<string>) content.GetValueForProperty("SiteSecondarySiteNames",((Commvault.Powershell.Models.ICompanyInternal)this).SiteSecondarySiteNames, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("FileExceptionUseCompanyGlobalFilter"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptionUseCompanyGlobalFilter = (bool?) content.GetValueForProperty("FileExceptionUseCompanyGlobalFilter",((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptionUseCompanyGlobalFilter, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TwoFactorAuthEnable"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).TwoFactorAuthEnable = (bool?) content.GetValueForProperty("TwoFactorAuthEnable",((Commvault.Powershell.Models.ICompanyInternal)this).TwoFactorAuthEnable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TwoFactorAuthAll"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).TwoFactorAuthAll = (bool?) content.GetValueForProperty("TwoFactorAuthAll",((Commvault.Powershell.Models.ICompanyInternal)this).TwoFactorAuthAll, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.Company"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Company(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("General"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).General = (Commvault.Powershell.Models.IGeneral) content.GetValueForProperty("General",((Commvault.Powershell.Models.ICompanyInternal)this).General, Commvault.Powershell.Models.GeneralTypeConverter.ConvertFrom);
            }
            if (content.Contains("EmailSettings"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).EmailSettings = (Commvault.Powershell.Models.IEmailSettings) content.GetValueForProperty("EmailSettings",((Commvault.Powershell.Models.ICompanyInternal)this).EmailSettings, Commvault.Powershell.Models.EmailSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sites"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).Sites = (Commvault.Powershell.Models.ISites) content.GetValueForProperty("Sites",((Commvault.Powershell.Models.ICompanyInternal)this).Sites, Commvault.Powershell.Models.SitesTypeConverter.ConvertFrom);
            }
            if (content.Contains("FileExceptions"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptions = (Commvault.Powershell.Models.IFileExceptions) content.GetValueForProperty("FileExceptions",((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptions, Commvault.Powershell.Models.FileExceptionsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.ICompanyInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CreationTime"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).CreationTime = (long?) content.GetValueForProperty("CreationTime",((Commvault.Powershell.Models.ICompanyInternal)this).CreationTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Security"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).Security = (System.Collections.Generic.List<Commvault.Powershell.Models.ISecurityAssoc>) content.GetValueForProperty("Security",((Commvault.Powershell.Models.ICompanyInternal)this).Security, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.ISecurityAssoc>(__y, Commvault.Powershell.Models.SecurityAssocTypeConverter.ConvertFrom));
            }
            if (content.Contains("Contacts"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).Contacts = (System.Collections.Generic.List<Commvault.Powershell.Models.IContactResp>) content.GetValueForProperty("Contacts",((Commvault.Powershell.Models.ICompanyInternal)this).Contacts, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IContactResp>(__y, Commvault.Powershell.Models.ContactRespTypeConverter.ConvertFrom));
            }
            if (content.Contains("Plans"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).Plans = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>) content.GetValueForProperty("Plans",((Commvault.Powershell.Models.ICompanyInternal)this).Plans, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            }
            if (content.Contains("OperatorsOperationType"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).OperatorsOperationType = (long?) content.GetValueForProperty("OperatorsOperationType",((Commvault.Powershell.Models.ICompanyInternal)this).OperatorsOperationType, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TenantOperators"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).TenantOperators = (System.Collections.Generic.List<Commvault.Powershell.Models.ITenantOperator>) content.GetValueForProperty("TenantOperators",((Commvault.Powershell.Models.ICompanyInternal)this).TenantOperators, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.ITenantOperator>(__y, Commvault.Powershell.Models.TenantOperatorTypeConverter.ConvertFrom));
            }
            if (content.Contains("GeneralNewAlias"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralNewAlias = (string) content.GetValueForProperty("GeneralNewAlias",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralNewAlias, global::System.Convert.ToString);
            }
            if (content.Contains("GeneralEmailSuffix"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralEmailSuffix = (string) content.GetValueForProperty("GeneralEmailSuffix",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralEmailSuffix, global::System.Convert.ToString);
            }
            if (content.Contains("GeneralSupportedSolutions"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralSupportedSolutions = (System.Collections.Generic.List<string>) content.GetValueForProperty("GeneralSupportedSolutions",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralSupportedSolutions, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("GeneralServiceCommcells"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralServiceCommcells = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>) content.GetValueForProperty("GeneralServiceCommcells",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralServiceCommcells, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            }
            if (content.Contains("EmailSettingSenderName"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).EmailSettingSenderName = (string) content.GetValueForProperty("EmailSettingSenderName",((Commvault.Powershell.Models.ICompanyInternal)this).EmailSettingSenderName, global::System.Convert.ToString);
            }
            if (content.Contains("EmailSettingSenderEmail"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).EmailSettingSenderEmail = (string) content.GetValueForProperty("EmailSettingSenderEmail",((Commvault.Powershell.Models.ICompanyInternal)this).EmailSettingSenderEmail, global::System.Convert.ToString);
            }
            if (content.Contains("FileExceptionWindows"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptionWindows = (string) content.GetValueForProperty("FileExceptionWindows",((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptionWindows, global::System.Convert.ToString);
            }
            if (content.Contains("FileExceptionUnix"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptionUnix = (string) content.GetValueForProperty("FileExceptionUnix",((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptionUnix, global::System.Convert.ToString);
            }
            if (content.Contains("GeneralTwoFactorAuth"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralTwoFactorAuth = (Commvault.Powershell.Models.ITwoFactorAuth) content.GetValueForProperty("GeneralTwoFactorAuth",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralTwoFactorAuth, Commvault.Powershell.Models.TwoFactorAuthTypeConverter.ConvertFrom);
            }
            if (content.Contains("GeneralAuthcodeForInstallation"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralAuthcodeForInstallation = (bool?) content.GetValueForProperty("GeneralAuthcodeForInstallation",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralAuthcodeForInstallation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GeneralUpnInsteadOfEmail"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralUpnInsteadOfEmail = (bool?) content.GetValueForProperty("GeneralUpnInsteadOfEmail",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralUpnInsteadOfEmail, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GeneralResellerMode"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralResellerMode = (bool?) content.GetValueForProperty("GeneralResellerMode",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralResellerMode, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GeneralEnableDataEncryption"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralEnableDataEncryption = (bool?) content.GetValueForProperty("GeneralEnableDataEncryption",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralEnableDataEncryption, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GeneralAutoDiscoverApp"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralAutoDiscoverApp = (bool?) content.GetValueForProperty("GeneralAutoDiscoverApp",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralAutoDiscoverApp, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GeneralInfrastructureType"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralInfrastructureType = (string) content.GetValueForProperty("GeneralInfrastructureType",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralInfrastructureType, global::System.Convert.ToString);
            }
            if (content.Contains("GeneralAssignLaptopOwners"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).GeneralAssignLaptopOwners = (string) content.GetValueForProperty("GeneralAssignLaptopOwners",((Commvault.Powershell.Models.ICompanyInternal)this).GeneralAssignLaptopOwners, global::System.Convert.ToString);
            }
            if (content.Contains("TwoFactorAuthUserGroups"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).TwoFactorAuthUserGroups = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>) content.GetValueForProperty("TwoFactorAuthUserGroups",((Commvault.Powershell.Models.ICompanyInternal)this).TwoFactorAuthUserGroups, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            }
            if (content.Contains("SitePrimarySiteName"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).SitePrimarySiteName = (string) content.GetValueForProperty("SitePrimarySiteName",((Commvault.Powershell.Models.ICompanyInternal)this).SitePrimarySiteName, global::System.Convert.ToString);
            }
            if (content.Contains("SiteSecondarySiteNames"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).SiteSecondarySiteNames = (System.Collections.Generic.List<string>) content.GetValueForProperty("SiteSecondarySiteNames",((Commvault.Powershell.Models.ICompanyInternal)this).SiteSecondarySiteNames, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("FileExceptionUseCompanyGlobalFilter"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptionUseCompanyGlobalFilter = (bool?) content.GetValueForProperty("FileExceptionUseCompanyGlobalFilter",((Commvault.Powershell.Models.ICompanyInternal)this).FileExceptionUseCompanyGlobalFilter, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TwoFactorAuthEnable"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).TwoFactorAuthEnable = (bool?) content.GetValueForProperty("TwoFactorAuthEnable",((Commvault.Powershell.Models.ICompanyInternal)this).TwoFactorAuthEnable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TwoFactorAuthAll"))
            {
                ((Commvault.Powershell.Models.ICompanyInternal)this).TwoFactorAuthAll = (bool?) content.GetValueForProperty("TwoFactorAuthAll",((Commvault.Powershell.Models.ICompanyInternal)this).TwoFactorAuthAll, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.Company"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ICompany" />.</returns>
        public static Commvault.Powershell.Models.ICompany DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Company(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.Company"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ICompany" />.</returns>
        public static Commvault.Powershell.Models.ICompany DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Company(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Company" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Company" /> model class.</returns>
        public static Commvault.Powershell.Models.ICompany FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Used to return details of a company whose companyId has been provided
    [System.ComponentModel.TypeConverter(typeof(CompanyTypeConverter))]
    public partial interface ICompany

    {

    }
}
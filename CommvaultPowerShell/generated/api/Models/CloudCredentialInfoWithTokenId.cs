// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Applicable only for credentials with Cloud Account and Vendor Type as AT&T Synaptic Storage or EMC Atmos
    /// </summary>
    public partial class CloudCredentialInfoWithTokenId :
        Commvault.Powershell.Models.ICloudCredentialInfoWithTokenId,
        Commvault.Powershell.Models.ICloudCredentialInfoWithTokenIdInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ICommonCredentialInfo" />
        /// </summary>
        private Commvault.Powershell.Models.ICommonCredentialInfo __commonCredentialInfo = new Commvault.Powershell.Models.CommonCredentialInfo();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ICreateCredential" />
        /// </summary>
        private Commvault.Powershell.Models.ICreateCredential __createCredential = new Commvault.Powershell.Models.CreateCredential();

        /// <summary>CredentialAccountType</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string AccountType { get => ((Commvault.Powershell.Models.ICreateCredentialInternal)__createCredential).AccountType; set => ((Commvault.Powershell.Models.ICreateCredentialInternal)__createCredential).AccountType = value ; }

        /// <summary>Internal Acessors for OwnerUser</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICommonCredentialInfoInternal.OwnerUser { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).OwnerUser; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).OwnerUser = value; }

        /// <summary>Internal Acessors for OwnerUserGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICommonCredentialInfoInternal.OwnerUserGroup { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).OwnerUserGroup; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).OwnerUserGroup = value; }

        /// <summary>Internal Acessors for Security</summary>
        Commvault.Powershell.Models.ICredentialSecurity Commvault.Powershell.Models.ICommonCredentialInfoInternal.Security { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).Security; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).Security = value; }

        /// <summary>Internal Acessors for SecurityOwner</summary>
        Commvault.Powershell.Models.ICredentialOwner Commvault.Powershell.Models.ICommonCredentialInfoInternal.SecurityOwner { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).SecurityOwner; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).SecurityOwner = value; }

        /// <summary>Description of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Description { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).Description; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).Description = value ?? null; }

        /// <summary>Name of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Name { get => ((Commvault.Powershell.Models.ICreateCredentialInternal)__createCredential).Name; set => ((Commvault.Powershell.Models.ICreateCredentialInternal)__createCredential).Name = value ; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        internal Commvault.Powershell.Models.IIdName OwnerUser { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).OwnerUser; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).OwnerUser = value ?? null /* model class */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        internal Commvault.Powershell.Models.IIdName OwnerUserGroup { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).OwnerUserGroup; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).OwnerUserGroup = value ?? null /* model class */; }

        /// <summary>Security association of a list of users and user groups</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        internal Commvault.Powershell.Models.ICredentialSecurity Security { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).Security; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).Security = value ?? null /* model class */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.ICredentialSecurityAssociations> SecurityAssociations { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).SecurityAssociations; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).SecurityAssociations = value ?? null /* arrayOf */; }

        /// <summary>Owner of a credential can be a user or user group</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        internal Commvault.Powershell.Models.ICredentialOwner SecurityOwner { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).SecurityOwner; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).SecurityOwner = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="SharedSecret" /> property.</summary>
        private string _sharedSecret;

        /// <summary>Shared secret of Credential and must be in base64 encoded format.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SharedSecret { get => this._sharedSecret; set => this._sharedSecret = value; }

        /// <summary>Backing field for <see cref="TokenId" /> property.</summary>
        private string _tokenId;

        /// <summary>Token ID of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string TokenId { get => this._tokenId; set => this._tokenId = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public long? UserGroupId { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserGroupId; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserGroupId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string UserGroupName { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserGroupName; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserGroupName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public long? UserId { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserId; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string UserName { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserName; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserName = value ?? null; }

        /// <summary>Cloud vendor types appilcable only for Cloud Account type</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string VendorType { get => ((Commvault.Powershell.Models.ICreateCredentialInternal)__createCredential).VendorType; set => ((Commvault.Powershell.Models.ICreateCredentialInternal)__createCredential).VendorType = value ?? null; }

        /// <summary>Creates an new <see cref="CloudCredentialInfoWithTokenId" /> instance.</summary>
        public CloudCredentialInfoWithTokenId()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Commvault.Powershell.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Commvault.Powershell.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__createCredential), __createCredential);
            await eventListener.AssertObjectIsValid(nameof(__createCredential), __createCredential);
            await eventListener.AssertNotNull(nameof(__commonCredentialInfo), __commonCredentialInfo);
            await eventListener.AssertObjectIsValid(nameof(__commonCredentialInfo), __commonCredentialInfo);
        }
    }
    /// Applicable only for credentials with Cloud Account and Vendor Type as AT&T Synaptic Storage or EMC Atmos
    public partial interface ICloudCredentialInfoWithTokenId :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.ICreateCredential,
        Commvault.Powershell.Models.ICommonCredentialInfo
    {
        /// <summary>Shared secret of Credential and must be in base64 encoded format.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Shared secret of Credential and must be in base64 encoded format.",
        SerializedName = @"sharedSecret",
        PossibleTypes = new [] { typeof(string) })]
        string SharedSecret { get; set; }
        /// <summary>Token ID of Credential</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Token ID of Credential",
        SerializedName = @"tokenId",
        PossibleTypes = new [] { typeof(string) })]
        string TokenId { get; set; }

    }
    /// Applicable only for credentials with Cloud Account and Vendor Type as AT&T Synaptic Storage or EMC Atmos
    internal partial interface ICloudCredentialInfoWithTokenIdInternal :
        Commvault.Powershell.Models.ICreateCredentialInternal,
        Commvault.Powershell.Models.ICommonCredentialInfoInternal
    {
        /// <summary>Shared secret of Credential and must be in base64 encoded format.</summary>
        string SharedSecret { get; set; }
        /// <summary>Token ID of Credential</summary>
        string TokenId { get; set; }

    }
}
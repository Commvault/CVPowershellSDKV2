// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Applicable for Credentials with Linux Account, Windows Account, Storage Array Account or Cloud Account with Vendor Type
    /// as Hitachi Content Platform.
    /// </summary>
    public partial class CredentialContent :
        Commvault.Powershell.Models.ICredentialContent,
        Commvault.Powershell.Models.ICredentialContentInternal
    {

        /// <summary>Internal Acessors for OwnerUser</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICredentialContentInternal.OwnerUser { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).OwnerUser; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).OwnerUser = value; }

        /// <summary>Internal Acessors for OwnerUserGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICredentialContentInternal.OwnerUserGroup { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).OwnerUserGroup; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).OwnerUserGroup = value; }

        /// <summary>Internal Acessors for Security</summary>
        Commvault.Powershell.Models.IUpdateCredentialSecurity Commvault.Powershell.Models.ICredentialContentInternal.Security { get => (this._security = this._security ?? new Commvault.Powershell.Models.UpdateCredentialSecurity()); set { {_security = value;} } }

        /// <summary>Internal Acessors for SecurityOwner</summary>
        Commvault.Powershell.Models.ICredentialOwner Commvault.Powershell.Models.ICredentialContentInternal.SecurityOwner { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).Owner; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).Owner = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Updated description of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="NewName" /> property.</summary>
        private string _newName;

        /// <summary>Updated name of credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NewName { get => this._newName; set => this._newName = value; }

        /// <summary>Backing field for <see cref="NewPassword" /> property.</summary>
        private string _newPassword;

        /// <summary>
        /// Updated password of credential. The password has to be provided in Base64 format.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NewPassword { get => this._newPassword; set => this._newPassword = value; }

        /// <summary>Backing field for <see cref="Security" /> property.</summary>
        private Commvault.Powershell.Models.IUpdateCredentialSecurity _security;

        /// <summary>Update Security association of a list of users and user groups</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IUpdateCredentialSecurity Security { get => (this._security = this._security ?? new Commvault.Powershell.Models.UpdateCredentialSecurity()); set => this._security = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.ICredentialSecurityAssociations> SecurityAssociations { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).Associations; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).Associations = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="UserAccount" /> property.</summary>
        private string _userAccount;

        /// <summary>
        /// User account of Credential. If updated the updated user account is considered else the existing user account is considered.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UserAccount { get => this._userAccount; set => this._userAccount = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? UserGroupId { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserGroupId; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserGroupId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserGroupName { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserGroupName; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserGroupName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? UserId { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserId; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserName { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserName; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserName = value ?? null; }

        /// <summary>Creates an new <see cref="CredentialContent" /> instance.</summary>
        public CredentialContent()
        {

        }
    }
    /// Applicable for Credentials with Linux Account, Windows Account, Storage Array Account or Cloud Account with Vendor Type
    /// as Hitachi Content Platform.
    public partial interface ICredentialContent :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Updated description of Credential</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Updated description of Credential",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Updated name of credential</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Updated name of credential",
        SerializedName = @"newName",
        PossibleTypes = new [] { typeof(string) })]
        string NewName { get; set; }
        /// <summary>
        /// Updated password of credential. The password has to be provided in Base64 format.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Updated password of credential. The password has to be provided in Base64 format.",
        SerializedName = @"newPassword",
        PossibleTypes = new [] { typeof(string) })]
        string NewPassword { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"associations",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ICredentialSecurityAssociations) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.ICredentialSecurityAssociations> SecurityAssociations { get; set; }
        /// <summary>
        /// User account of Credential. If updated the updated user account is considered else the existing user account is considered.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User account of Credential. If updated the updated user account is considered else the existing user account is considered.",
        SerializedName = @"userAccount",
        PossibleTypes = new [] { typeof(string) })]
        string UserAccount { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? UserGroupId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string UserGroupName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? UserId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }

    }
    /// Applicable for Credentials with Linux Account, Windows Account, Storage Array Account or Cloud Account with Vendor Type
    /// as Hitachi Content Platform.
    internal partial interface ICredentialContentInternal

    {
        /// <summary>Updated description of Credential</summary>
        string Description { get; set; }
        /// <summary>Updated name of credential</summary>
        string NewName { get; set; }
        /// <summary>
        /// Updated password of credential. The password has to be provided in Base64 format.
        /// </summary>
        string NewPassword { get; set; }

        Commvault.Powershell.Models.IIdName OwnerUser { get; set; }

        Commvault.Powershell.Models.IIdName OwnerUserGroup { get; set; }
        /// <summary>Update Security association of a list of users and user groups</summary>
        Commvault.Powershell.Models.IUpdateCredentialSecurity Security { get; set; }

        System.Collections.Generic.List<Commvault.Powershell.Models.ICredentialSecurityAssociations> SecurityAssociations { get; set; }
        /// <summary>Owner of a credential can be a user or user group</summary>
        Commvault.Powershell.Models.ICredentialOwner SecurityOwner { get; set; }
        /// <summary>
        /// User account of Credential. If updated the updated user account is considered else the existing user account is considered.
        /// </summary>
        string UserAccount { get; set; }

        long? UserGroupId { get; set; }

        string UserGroupName { get; set; }

        long? UserId { get; set; }

        string UserName { get; set; }

    }
}
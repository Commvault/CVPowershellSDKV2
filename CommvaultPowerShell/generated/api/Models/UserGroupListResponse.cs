// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Used to get a list of existing user-groups.</summary>
    public partial class UserGroupListResponse :
        Commvault.Powershell.Models.IUserGroupListResponse,
        Commvault.Powershell.Models.IUserGroupListResponseInternal
    {

        /// <summary>Backing field for <see cref="UserGroups" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IUserGroupSummary> _userGroups;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IUserGroupSummary> UserGroups { get => this._userGroups; set => this._userGroups = value; }

        /// <summary>Creates an new <see cref="UserGroupListResponse" /> instance.</summary>
        public UserGroupListResponse()
        {

        }
    }
    /// Used to get a list of existing user-groups.
    public partial interface IUserGroupListResponse :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"userGroups",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IUserGroupSummary) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IUserGroupSummary> UserGroups { get; set; }

    }
    /// Used to get a list of existing user-groups.
    internal partial interface IUserGroupListResponseInternal

    {
        System.Collections.Generic.List<Commvault.Powershell.Models.IUserGroupSummary> UserGroups { get; set; }

    }
}
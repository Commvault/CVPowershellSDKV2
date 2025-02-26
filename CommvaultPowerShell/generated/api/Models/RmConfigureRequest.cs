// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>RMConfigureRequest</summary>
    public partial class RmConfigureRequest :
        Commvault.Powershell.Models.IRmConfigureRequest,
        Commvault.Powershell.Models.IRmConfigureRequestInternal
    {

        /// <summary>Backing field for <see cref="Approvers" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameDisplayName> _approvers;

        /// <summary>List of approvers for the request</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameDisplayName> Approvers { get => this._approvers; set => this._approvers = value; }

        /// <summary>Backing field for <see cref="ProjectIds" /> property.</summary>
        private System.Collections.Generic.List<long> _projectIds;

        /// <summary>List of project ids</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<long> ProjectIds { get => this._projectIds; set => this._projectIds = value; }

        /// <summary>Backing field for <see cref="Reviewers" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameDisplayName> _reviewers;

        /// <summary>List of reviewers for the request</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameDisplayName> Reviewers { get => this._reviewers; set => this._reviewers = value; }

        /// <summary>Creates an new <see cref="RmConfigureRequest" /> instance.</summary>
        public RmConfigureRequest()
        {

        }
    }
    /// RMConfigureRequest
    public partial interface IRmConfigureRequest :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>List of approvers for the request</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of approvers for the request",
        SerializedName = @"approvers",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdNameDisplayName) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameDisplayName> Approvers { get; set; }
        /// <summary>List of project ids</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of project ids",
        SerializedName = @"projectIds",
        PossibleTypes = new [] { typeof(long) })]
        System.Collections.Generic.List<long> ProjectIds { get; set; }
        /// <summary>List of reviewers for the request</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of reviewers for the request",
        SerializedName = @"reviewers",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdNameDisplayName) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameDisplayName> Reviewers { get; set; }

    }
    /// RMConfigureRequest
    internal partial interface IRmConfigureRequestInternal

    {
        /// <summary>List of approvers for the request</summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameDisplayName> Approvers { get; set; }
        /// <summary>List of project ids</summary>
        System.Collections.Generic.List<long> ProjectIds { get; set; }
        /// <summary>List of reviewers for the request</summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameDisplayName> Reviewers { get; set; }

    }
}
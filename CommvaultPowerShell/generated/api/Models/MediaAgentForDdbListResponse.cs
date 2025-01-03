// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class MediaAgentForDdbListResponse :
        Commvault.Powershell.Models.IMediaAgentForDdbListResponse,
        Commvault.Powershell.Models.IMediaAgentForDdbListResponseInternal
    {

        /// <summary>Backing field for <see cref="MediaAgents" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IMediaAgentForDdbSummary> _mediaAgents;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IMediaAgentForDdbSummary> MediaAgents { get => this._mediaAgents; set => this._mediaAgents = value; }

        /// <summary>Creates an new <see cref="MediaAgentForDdbListResponse" /> instance.</summary>
        public MediaAgentForDdbListResponse()
        {

        }
    }
    public partial interface IMediaAgentForDdbListResponse :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"mediaAgents",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IMediaAgentForDdbSummary) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IMediaAgentForDdbSummary> MediaAgents { get; set; }

    }
    internal partial interface IMediaAgentForDdbListResponseInternal

    {
        System.Collections.Generic.List<Commvault.Powershell.Models.IMediaAgentForDdbSummary> MediaAgents { get; set; }

    }
}
// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>hypervisorAccountDetails</summary>
    public partial class HypervisorAccountDetails :
        Commvault.Powershell.Models.IHypervisorAccountDetails,
        Commvault.Powershell.Models.IHypervisorAccountDetailsInternal
    {

        /// <summary>Backing field for <see cref="HostName" /> property.</summary>
        private string _hostName;

        /// <summary>Host Name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string HostName { get => this._hostName; set => this._hostName = value; }

        /// <summary>Creates an new <see cref="HypervisorAccountDetails" /> instance.</summary>
        public HypervisorAccountDetails()
        {

        }
    }
    /// hypervisorAccountDetails
    public partial interface IHypervisorAccountDetails :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Host Name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Host Name",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get; set; }

    }
    /// hypervisorAccountDetails
    internal partial interface IHypervisorAccountDetailsInternal

    {
        /// <summary>Host Name</summary>
        string HostName { get; set; }

    }
}
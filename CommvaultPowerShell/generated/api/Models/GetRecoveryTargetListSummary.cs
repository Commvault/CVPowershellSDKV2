// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>GetRecoveryTargetListSummary</summary>
    public partial class GetRecoveryTargetListSummary :
        Commvault.Powershell.Models.IGetRecoveryTargetListSummary,
        Commvault.Powershell.Models.IGetRecoveryTargetListSummaryInternal
    {

        /// <summary>Backing field for <see cref="ApplicationType" /> property.</summary>
        private string _applicationType;

        /// <summary>Recovery target application type</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ApplicationType { get => this._applicationType; set => this._applicationType = value; }

        /// <summary>Internal Acessors for DestinationHypervisor</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IGetRecoveryTargetListSummaryInternal.DestinationHypervisor { get => (this._destinationHypervisor = this._destinationHypervisor ?? new Commvault.Powershell.Models.IdName()); set { {_destinationHypervisor = value;} } }

        /// <summary>Backing field for <see cref="DestinationHypervisor" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _destinationHypervisor;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName DestinationHypervisor { get => (this._destinationHypervisor = this._destinationHypervisor ?? new Commvault.Powershell.Models.IdName()); set => this._destinationHypervisor = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? DestinationHypervisorId { get => ((Commvault.Powershell.Models.IIdNameInternal)DestinationHypervisor).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)DestinationHypervisor).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string DestinationHypervisorName { get => ((Commvault.Powershell.Models.IIdNameInternal)DestinationHypervisor).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)DestinationHypervisor).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private long? _id;

        /// <summary>Recovery Target Id</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Recovery Target name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Vendor" /> property.</summary>
        private string _vendor;

        /// <summary>Recovery target vendor name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Vendor { get => this._vendor; set => this._vendor = value; }

        /// <summary>Creates an new <see cref="GetRecoveryTargetListSummary" /> instance.</summary>
        public GetRecoveryTargetListSummary()
        {

        }
    }
    /// GetRecoveryTargetListSummary
    public partial interface IGetRecoveryTargetListSummary :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Recovery target application type</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Recovery target application type",
        SerializedName = @"applicationType",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? DestinationHypervisorId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationHypervisorName { get; set; }
        /// <summary>Recovery Target Id</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Recovery Target Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? Id { get; set; }
        /// <summary>Recovery Target name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Recovery Target name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Recovery target vendor name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Recovery target vendor name",
        SerializedName = @"vendor",
        PossibleTypes = new [] { typeof(string) })]
        string Vendor { get; set; }

    }
    /// GetRecoveryTargetListSummary
    internal partial interface IGetRecoveryTargetListSummaryInternal

    {
        /// <summary>Recovery target application type</summary>
        string ApplicationType { get; set; }

        Commvault.Powershell.Models.IIdName DestinationHypervisor { get; set; }

        long? DestinationHypervisorId { get; set; }

        string DestinationHypervisorName { get; set; }
        /// <summary>Recovery Target Id</summary>
        long? Id { get; set; }
        /// <summary>Recovery Target name</summary>
        string Name { get; set; }
        /// <summary>Recovery target vendor name</summary>
        string Vendor { get; set; }

    }
}
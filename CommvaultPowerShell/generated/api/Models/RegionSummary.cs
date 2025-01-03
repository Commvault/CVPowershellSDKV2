// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Summary of the region</summary>
    public partial class RegionSummary :
        Commvault.Powershell.Models.IRegionSummary,
        Commvault.Powershell.Models.IRegionSummaryInternal
    {

        /// <summary>Backing field for <see cref="AssociatedRegionBasedPlans" /> property.</summary>
        private long? _associatedRegionBasedPlans;

        /// <summary>Number of plans associated to the region</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? AssociatedRegionBasedPlans { get => this._associatedRegionBasedPlans; set => this._associatedRegionBasedPlans = value; }

        /// <summary>Backing field for <see cref="AssociatedServers" /> property.</summary>
        private long? _associatedServers;

        /// <summary>Number of servers associated to the region</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? AssociatedServers { get => this._associatedServers; set => this._associatedServers = value; }

        /// <summary>Internal Acessors for Company</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IRegionSummaryInternal.Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set { {_company = value;} } }

        /// <summary>Internal Acessors for GlobalConfigInfo</summary>
        Commvault.Powershell.Models.IGlobalConfigInfo Commvault.Powershell.Models.IRegionSummaryInternal.GlobalConfigInfo { get => (this._globalConfigInfo = this._globalConfigInfo ?? new Commvault.Powershell.Models.GlobalConfigInfo()); set { {_globalConfigInfo = value;} } }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _company;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set => this._company = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? CompanyId { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name = value ?? null; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="GlobalConfigInfo" /> property.</summary>
        private Commvault.Powershell.Models.IGlobalConfigInfo _globalConfigInfo;

        /// <summary>Only applicable on Global CommCells</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IGlobalConfigInfo GlobalConfigInfo { get => (this._globalConfigInfo = this._globalConfigInfo ?? new Commvault.Powershell.Models.GlobalConfigInfo()); set => this._globalConfigInfo = value; }

        /// <summary>
        /// Decides whether the global configuration should be applied to all the Service commcells, including the newly created ones
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? GlobalConfigInfoApplyOnAllCommCells { get => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).ApplyOnAllCommCells; set => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).ApplyOnAllCommCells = value ?? default(bool); }

        /// <summary>List of Service CommCells where the global configuration is applied</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IGlobalConfigCommcellInfo> GlobalConfigInfoCommcells { get => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).Commcells; set => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).Commcells = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GlobalConfigInfoId { get => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).Id; set => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).Id = value ?? null; }

        /// <summary>Indicates whether global configuration deletion has been started.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? GlobalConfigInfoIsMarkedForDeletion { get => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).IsMarkedForDeletion; set => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).IsMarkedForDeletion = value ?? default(bool); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GlobalConfigInfoName { get => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).Name; set => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).Name = value ?? null; }

        /// <summary>The entity level at which the config is applied.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GlobalConfigInfoScope { get => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).Scope; set => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).Scope = value ?? null; }

        /// <summary>CommCellEntityCache filter query string used for filtering the scope</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GlobalConfigInfoScopeFilterQuery { get => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).ScopeFilterQuery; set => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).ScopeFilterQuery = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GlobalConfigInfoStatus { get => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).Status; set => ((Commvault.Powershell.Models.IGlobalConfigInfoInternal)GlobalConfigInfo).Status = value ?? null; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private long? _id;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Locations" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.ILocationSummary> _locations;

        /// <summary>List of locations in the region</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.ILocationSummary> Locations { get => this._locations; set => this._locations = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="RegionType" /> property.</summary>
        private string _regionType;

        /// <summary>Type of region</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string RegionType { get => this._regionType; set => this._regionType = value; }

        /// <summary>Creates an new <see cref="RegionSummary" /> instance.</summary>
        public RegionSummary()
        {

        }
    }
    /// Summary of the region
    public partial interface IRegionSummary :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Number of plans associated to the region</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of plans associated to the region",
        SerializedName = @"associatedRegionBasedPlans",
        PossibleTypes = new [] { typeof(long) })]
        long? AssociatedRegionBasedPlans { get; set; }
        /// <summary>Number of servers associated to the region</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of servers associated to the region",
        SerializedName = @"associatedServers",
        PossibleTypes = new [] { typeof(long) })]
        long? AssociatedServers { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? CompanyId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>
        /// Decides whether the global configuration should be applied to all the Service commcells, including the newly created ones
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Decides whether the global configuration should be applied to all the Service commcells, including the newly created ones",
        SerializedName = @"applyOnAllCommCells",
        PossibleTypes = new [] { typeof(bool) })]
        bool? GlobalConfigInfoApplyOnAllCommCells { get; set; }
        /// <summary>List of Service CommCells where the global configuration is applied</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of Service CommCells where the global configuration is applied",
        SerializedName = @"commcells",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IGlobalConfigCommcellInfo) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IGlobalConfigCommcellInfo> GlobalConfigInfoCommcells { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string GlobalConfigInfoId { get; set; }
        /// <summary>Indicates whether global configuration deletion has been started.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether global configuration deletion has been started.",
        SerializedName = @"isMarkedForDeletion",
        PossibleTypes = new [] { typeof(bool) })]
        bool? GlobalConfigInfoIsMarkedForDeletion { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string GlobalConfigInfoName { get; set; }
        /// <summary>The entity level at which the config is applied.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The entity level at which the config is applied.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string GlobalConfigInfoScope { get; set; }
        /// <summary>CommCellEntityCache filter query string used for filtering the scope</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"CommCellEntityCache filter query string used for filtering the scope",
        SerializedName = @"scopeFilterQuery",
        PossibleTypes = new [] { typeof(string) })]
        string GlobalConfigInfoScopeFilterQuery { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string GlobalConfigInfoStatus { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? Id { get; set; }
        /// <summary>List of locations in the region</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of locations in the region",
        SerializedName = @"locations",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ILocationSummary) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.ILocationSummary> Locations { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Type of region</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of region",
        SerializedName = @"regionType",
        PossibleTypes = new [] { typeof(string) })]
        string RegionType { get; set; }

    }
    /// Summary of the region
    internal partial interface IRegionSummaryInternal

    {
        /// <summary>Number of plans associated to the region</summary>
        long? AssociatedRegionBasedPlans { get; set; }
        /// <summary>Number of servers associated to the region</summary>
        long? AssociatedServers { get; set; }

        Commvault.Powershell.Models.IIdName Company { get; set; }

        long? CompanyId { get; set; }

        string CompanyName { get; set; }

        string DisplayName { get; set; }
        /// <summary>Only applicable on Global CommCells</summary>
        Commvault.Powershell.Models.IGlobalConfigInfo GlobalConfigInfo { get; set; }
        /// <summary>
        /// Decides whether the global configuration should be applied to all the Service commcells, including the newly created ones
        /// </summary>
        bool? GlobalConfigInfoApplyOnAllCommCells { get; set; }
        /// <summary>List of Service CommCells where the global configuration is applied</summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.IGlobalConfigCommcellInfo> GlobalConfigInfoCommcells { get; set; }

        string GlobalConfigInfoId { get; set; }
        /// <summary>Indicates whether global configuration deletion has been started.</summary>
        bool? GlobalConfigInfoIsMarkedForDeletion { get; set; }

        string GlobalConfigInfoName { get; set; }
        /// <summary>The entity level at which the config is applied.</summary>
        string GlobalConfigInfoScope { get; set; }
        /// <summary>CommCellEntityCache filter query string used for filtering the scope</summary>
        string GlobalConfigInfoScopeFilterQuery { get; set; }

        string GlobalConfigInfoStatus { get; set; }

        long? Id { get; set; }
        /// <summary>List of locations in the region</summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.ILocationSummary> Locations { get; set; }

        string Name { get; set; }
        /// <summary>Type of region</summary>
        string RegionType { get; set; }

    }
}
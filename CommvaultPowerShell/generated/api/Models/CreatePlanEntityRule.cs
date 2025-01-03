// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// This object will send details to create new plan rule. User can provide all rule options or can specify a specific rule
    /// group. Be default, for rule to be applicable for association to a workload, ALL specified rules in that Rule need to be
    /// matched.
    /// </summary>
    public partial class CreatePlanEntityRule :
        Commvault.Powershell.Models.ICreatePlanEntityRule,
        Commvault.Powershell.Models.ICreatePlanEntityRuleInternal
    {

        /// <summary>Internal Acessors for Company</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICreatePlanEntityRuleInternal.Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set { {_company = value;} } }

        /// <summary>Internal Acessors for GlobalConfigInfo</summary>
        Commvault.Powershell.Models.ICreateGlobalConfigInfo Commvault.Powershell.Models.ICreatePlanEntityRuleInternal.GlobalConfigInfo { get => (this._globalConfigInfo = this._globalConfigInfo ?? new Commvault.Powershell.Models.CreateGlobalConfigInfo()); set { {_globalConfigInfo = value;} } }

        /// <summary>Internal Acessors for Plan</summary>
        Commvault.Powershell.Models.IIdNameGuid Commvault.Powershell.Models.ICreatePlanEntityRuleInternal.Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.IdNameGuid()); set { {_plan = value;} } }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _company;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set => this._company = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? CompanyId { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name = value ?? null; }

        /// <summary>Backing field for <see cref="GlobalConfigInfo" /> property.</summary>
        private Commvault.Powershell.Models.ICreateGlobalConfigInfo _globalConfigInfo;

        /// <summary>Only applicable to Global CommCells</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ICreateGlobalConfigInfo GlobalConfigInfo { get => (this._globalConfigInfo = this._globalConfigInfo ?? new Commvault.Powershell.Models.CreateGlobalConfigInfo()); set => this._globalConfigInfo = value; }

        /// <summary>
        /// Action that will be taken on the local entity that has the same name as the global entity that needs to be created
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GlobalConfigInfoActionOnLocalEntity { get => ((Commvault.Powershell.Models.ICreateGlobalConfigInfoInternal)GlobalConfigInfo).ActionOnLocalEntity; set => ((Commvault.Powershell.Models.ICreateGlobalConfigInfoInternal)GlobalConfigInfo).ActionOnLocalEntity = value ?? null; }

        /// <summary>
        /// Decides whether the global configuration should be applied to all the Service commcells, including the newly created ones
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? GlobalConfigInfoApplyOnAllCommCells { get => ((Commvault.Powershell.Models.ICreateGlobalConfigInfoInternal)GlobalConfigInfo).ApplyOnAllCommCells; set => ((Commvault.Powershell.Models.ICreateGlobalConfigInfoInternal)GlobalConfigInfo).ApplyOnAllCommCells = value ?? default(bool); }

        /// <summary>List of Service CommCells where the global configuration should be applied</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IGlobalConfigCommcellInfo> GlobalConfigInfoCommcells { get => ((Commvault.Powershell.Models.ICreateGlobalConfigInfoInternal)GlobalConfigInfo).Commcells; set => ((Commvault.Powershell.Models.ICreateGlobalConfigInfoInternal)GlobalConfigInfo).Commcells = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GlobalConfigInfoName { get => ((Commvault.Powershell.Models.ICreateGlobalConfigInfoInternal)GlobalConfigInfo).Name; set => ((Commvault.Powershell.Models.ICreateGlobalConfigInfoInternal)GlobalConfigInfo).Name = value ?? null; }

        /// <summary>The entity level at which the config has to be applied.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GlobalConfigInfoScope { get => ((Commvault.Powershell.Models.ICreateGlobalConfigInfoInternal)GlobalConfigInfo).Scope; set => ((Commvault.Powershell.Models.ICreateGlobalConfigInfoInternal)GlobalConfigInfo).Scope = value ?? null; }

        /// <summary>CommCellEntityCache filter query string using for filtering the scope</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GlobalConfigInfoScopeFilterQuery { get => ((Commvault.Powershell.Models.ICreateGlobalConfigInfoInternal)GlobalConfigInfo).ScopeFilterQuery; set => ((Commvault.Powershell.Models.ICreateGlobalConfigInfoInternal)GlobalConfigInfo).ScopeFilterQuery = value ?? null; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private Commvault.Powershell.Models.IIdNameGuid _plan;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdNameGuid Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.IdNameGuid()); set => this._plan = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PlanGuid { get => ((Commvault.Powershell.Models.IIdNameGuidInternal)Plan).Guid; set => ((Commvault.Powershell.Models.IIdNameGuidInternal)Plan).Guid = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? PlanId { get => ((Commvault.Powershell.Models.IIdNameGuidInternal)Plan).Id; set => ((Commvault.Powershell.Models.IIdNameGuidInternal)Plan).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PlanName { get => ((Commvault.Powershell.Models.IIdNameGuidInternal)Plan).Name; set => ((Commvault.Powershell.Models.IIdNameGuidInternal)Plan).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Rank" /> property.</summary>
        private long? _rank;

        /// <summary>
        /// Optional field to suggest priority/rank of the rule. If not present, we will process rule in the same order they are created.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? Rank { get => this._rank; set => this._rank = value; }

        /// <summary>Backing field for <see cref="Regions" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameGuid> _regions;

        /// <summary>
        /// This will include list of regions that should be evaluated against workload region for plan association.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameGuid> Regions { get => this._regions; set => this._regions = value; }

        /// <summary>Backing field for <see cref="ServerGroups" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameGuid> _serverGroups;

        /// <summary>
        /// This will include list of Server groups that should be evaluated against workload server group for plan association.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameGuid> ServerGroups { get => this._serverGroups; set => this._serverGroups = value; }

        /// <summary>Backing field for <see cref="Solutions" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> _solutions;

        /// <summary>
        /// This will include list of solutions that should be evaluated against workload for plan association
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> Solutions { get => this._solutions; set => this._solutions = value; }

        /// <summary>Backing field for <see cref="Tags" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IPlanEntityRuleTag> _tags;

        /// <summary>
        /// This will include list of tags that should be evaluated against workload for plan association
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IPlanEntityRuleTag> Tags { get => this._tags; set => this._tags = value; }

        /// <summary>Backing field for <see cref="Workloads" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> _workloads;

        /// <summary>
        /// This will include list of apptypes that should be evaluated against workload apptype for plan association.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> Workloads { get => this._workloads; set => this._workloads = value; }

        /// <summary>Creates an new <see cref="CreatePlanEntityRule" /> instance.</summary>
        public CreatePlanEntityRule()
        {

        }
    }
    /// This object will send details to create new plan rule. User can provide all rule options or can specify a specific rule
    /// group. Be default, for rule to be applicable for association to a workload, ALL specified rules in that Rule need to be
    /// matched.
    public partial interface ICreatePlanEntityRule :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
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
        /// <summary>
        /// Action that will be taken on the local entity that has the same name as the global entity that needs to be created
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Action that will be taken on the local entity that has the same name as the global entity that needs to be created",
        SerializedName = @"actionOnLocalEntity",
        PossibleTypes = new [] { typeof(string) })]
        string GlobalConfigInfoActionOnLocalEntity { get; set; }
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
        /// <summary>List of Service CommCells where the global configuration should be applied</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of Service CommCells where the global configuration should be applied",
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
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string GlobalConfigInfoName { get; set; }
        /// <summary>The entity level at which the config has to be applied.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The entity level at which the config has to be applied.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string GlobalConfigInfoScope { get; set; }
        /// <summary>CommCellEntityCache filter query string using for filtering the scope</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"CommCellEntityCache filter query string using for filtering the scope",
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
        SerializedName = @"GUID",
        PossibleTypes = new [] { typeof(string) })]
        string PlanGuid { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? PlanId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string PlanName { get; set; }
        /// <summary>
        /// Optional field to suggest priority/rank of the rule. If not present, we will process rule in the same order they are created.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional field to suggest priority/rank of the rule. If not present, we will process rule in the same order they are created.",
        SerializedName = @"rank",
        PossibleTypes = new [] { typeof(long) })]
        long? Rank { get; set; }
        /// <summary>
        /// This will include list of regions that should be evaluated against workload region for plan association.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This will include list of regions that should be evaluated against workload region for plan association.",
        SerializedName = @"regions",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdNameGuid) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameGuid> Regions { get; set; }
        /// <summary>
        /// This will include list of Server groups that should be evaluated against workload server group for plan association.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This will include list of Server groups that should be evaluated against workload server group for plan association.",
        SerializedName = @"serverGroups",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdNameGuid) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameGuid> ServerGroups { get; set; }
        /// <summary>
        /// This will include list of solutions that should be evaluated against workload for plan association
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This will include list of solutions that should be evaluated against workload for plan association",
        SerializedName = @"solutions",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> Solutions { get; set; }
        /// <summary>
        /// This will include list of tags that should be evaluated against workload for plan association
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This will include list of tags that should be evaluated against workload for plan association",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IPlanEntityRuleTag) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IPlanEntityRuleTag> Tags { get; set; }
        /// <summary>
        /// This will include list of apptypes that should be evaluated against workload apptype for plan association.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This will include list of apptypes that should be evaluated against workload apptype for plan association.",
        SerializedName = @"workloads",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> Workloads { get; set; }

    }
    /// This object will send details to create new plan rule. User can provide all rule options or can specify a specific rule
    /// group. Be default, for rule to be applicable for association to a workload, ALL specified rules in that Rule need to be
    /// matched.
    internal partial interface ICreatePlanEntityRuleInternal

    {
        Commvault.Powershell.Models.IIdName Company { get; set; }

        long? CompanyId { get; set; }

        string CompanyName { get; set; }
        /// <summary>Only applicable to Global CommCells</summary>
        Commvault.Powershell.Models.ICreateGlobalConfigInfo GlobalConfigInfo { get; set; }
        /// <summary>
        /// Action that will be taken on the local entity that has the same name as the global entity that needs to be created
        /// </summary>
        string GlobalConfigInfoActionOnLocalEntity { get; set; }
        /// <summary>
        /// Decides whether the global configuration should be applied to all the Service commcells, including the newly created ones
        /// </summary>
        bool? GlobalConfigInfoApplyOnAllCommCells { get; set; }
        /// <summary>List of Service CommCells where the global configuration should be applied</summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.IGlobalConfigCommcellInfo> GlobalConfigInfoCommcells { get; set; }

        string GlobalConfigInfoName { get; set; }
        /// <summary>The entity level at which the config has to be applied.</summary>
        string GlobalConfigInfoScope { get; set; }
        /// <summary>CommCellEntityCache filter query string using for filtering the scope</summary>
        string GlobalConfigInfoScopeFilterQuery { get; set; }

        Commvault.Powershell.Models.IIdNameGuid Plan { get; set; }

        string PlanGuid { get; set; }

        long? PlanId { get; set; }

        string PlanName { get; set; }
        /// <summary>
        /// Optional field to suggest priority/rank of the rule. If not present, we will process rule in the same order they are created.
        /// </summary>
        long? Rank { get; set; }
        /// <summary>
        /// This will include list of regions that should be evaluated against workload region for plan association.
        /// </summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameGuid> Regions { get; set; }
        /// <summary>
        /// This will include list of Server groups that should be evaluated against workload server group for plan association.
        /// </summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameGuid> ServerGroups { get; set; }
        /// <summary>
        /// This will include list of solutions that should be evaluated against workload for plan association
        /// </summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> Solutions { get; set; }
        /// <summary>
        /// This will include list of tags that should be evaluated against workload for plan association
        /// </summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.IPlanEntityRuleTag> Tags { get; set; }
        /// <summary>
        /// This will include list of apptypes that should be evaluated against workload apptype for plan association.
        /// </summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> Workloads { get; set; }

    }
}
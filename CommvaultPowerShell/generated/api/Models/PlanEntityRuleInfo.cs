// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>This object will hold each plan rule details.</summary>
    public partial class PlanEntityRuleInfo :
        Commvault.Powershell.Models.IPlanEntityRuleInfo,
        Commvault.Powershell.Models.IPlanEntityRuleInfoInternal
    {

        /// <summary>Internal Acessors for Company</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IPlanEntityRuleInfoInternal.Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set { {_company = value;} } }

        /// <summary>Internal Acessors for Plan</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IPlanEntityRuleInfoInternal.Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.IdName()); set { {_plan = value;} } }

        /// <summary>Internal Acessors for Rule</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IPlanEntityRuleInfoInternal.Rule { get => (this._rule = this._rule ?? new Commvault.Powershell.Models.IdName()); set { {_rule = value;} } }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _company;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set => this._company = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? CompanyId { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _plan;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.IdName()); set => this._plan = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? PlanId { get => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PlanName { get => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Rank" /> property.</summary>
        private long? _rank;

        /// <summary>This will suggest rank/priority of the plan rule.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? Rank { get => this._rank; set => this._rank = value; }

        /// <summary>Backing field for <see cref="Regions" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _regions;

        /// <summary>
        /// This will include list of regions that should be evaluated against workload region for plan association
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] Regions { get => this._regions; set => this._regions = value; }

        /// <summary>Backing field for <see cref="Rule" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _rule;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Rule { get => (this._rule = this._rule ?? new Commvault.Powershell.Models.IdName()); set => this._rule = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? RuleId { get => ((Commvault.Powershell.Models.IIdNameInternal)Rule).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Rule).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RuleName { get => ((Commvault.Powershell.Models.IIdNameInternal)Rule).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Rule).Name = value ?? null; }

        /// <summary>Backing field for <see cref="ServerGroups" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _serverGroups;

        /// <summary>
        /// This will include list of Server groups that should be evaluated against workload server group for plan association
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] ServerGroups { get => this._serverGroups; set => this._serverGroups = value; }

        /// <summary>Backing field for <see cref="Solutions" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _solutions;

        /// <summary>
        /// This will include list of solutions that should be evaluated against workload for plan association.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] Solutions { get => this._solutions; set => this._solutions = value; }

        /// <summary>Backing field for <see cref="Tags" /> property.</summary>
        private Commvault.Powershell.Models.IPlanEntityRuleTag[] _tags;

        /// <summary>
        /// This will include list of tags that should be evaluated against workload tags (if any) for plan association
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IPlanEntityRuleTag[] Tags { get => this._tags; set => this._tags = value; }

        /// <summary>Backing field for <see cref="Workloads" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _workloads;

        /// <summary>
        /// This will include list of apptypes that should be evaluated against workload for plan association
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] Workloads { get => this._workloads; set => this._workloads = value; }

        /// <summary>Creates an new <see cref="PlanEntityRuleInfo" /> instance.</summary>
        public PlanEntityRuleInfo()
        {

        }
    }
    /// This object will hold each plan rule details.
    public partial interface IPlanEntityRuleInfo :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? CompanyId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? PlanId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string PlanName { get; set; }
        /// <summary>This will suggest rank/priority of the plan rule.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This will suggest rank/priority of the plan rule.",
        SerializedName = @"rank",
        PossibleTypes = new [] { typeof(long) })]
        long? Rank { get; set; }
        /// <summary>
        /// This will include list of regions that should be evaluated against workload region for plan association
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This will include list of regions that should be evaluated against workload region for plan association",
        SerializedName = @"regions",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] Regions { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? RuleId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string RuleName { get; set; }
        /// <summary>
        /// This will include list of Server groups that should be evaluated against workload server group for plan association
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This will include list of Server groups that should be evaluated against workload server group for plan association",
        SerializedName = @"serverGroups",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] ServerGroups { get; set; }
        /// <summary>
        /// This will include list of solutions that should be evaluated against workload for plan association.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This will include list of solutions that should be evaluated against workload for plan association.",
        SerializedName = @"solutions",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] Solutions { get; set; }
        /// <summary>
        /// This will include list of tags that should be evaluated against workload tags (if any) for plan association
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This will include list of tags that should be evaluated against workload tags (if any) for plan association",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IPlanEntityRuleTag) })]
        Commvault.Powershell.Models.IPlanEntityRuleTag[] Tags { get; set; }
        /// <summary>
        /// This will include list of apptypes that should be evaluated against workload for plan association
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This will include list of apptypes that should be evaluated against workload for plan association",
        SerializedName = @"workloads",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] Workloads { get; set; }

    }
    /// This object will hold each plan rule details.
    internal partial interface IPlanEntityRuleInfoInternal

    {
        Commvault.Powershell.Models.IIdName Company { get; set; }

        long? CompanyId { get; set; }

        string CompanyName { get; set; }

        Commvault.Powershell.Models.IIdName Plan { get; set; }

        long? PlanId { get; set; }

        string PlanName { get; set; }
        /// <summary>This will suggest rank/priority of the plan rule.</summary>
        long? Rank { get; set; }
        /// <summary>
        /// This will include list of regions that should be evaluated against workload region for plan association
        /// </summary>
        Commvault.Powershell.Models.IIdName[] Regions { get; set; }

        Commvault.Powershell.Models.IIdName Rule { get; set; }

        long? RuleId { get; set; }

        string RuleName { get; set; }
        /// <summary>
        /// This will include list of Server groups that should be evaluated against workload server group for plan association
        /// </summary>
        Commvault.Powershell.Models.IIdName[] ServerGroups { get; set; }
        /// <summary>
        /// This will include list of solutions that should be evaluated against workload for plan association.
        /// </summary>
        Commvault.Powershell.Models.IIdName[] Solutions { get; set; }
        /// <summary>
        /// This will include list of tags that should be evaluated against workload tags (if any) for plan association
        /// </summary>
        Commvault.Powershell.Models.IPlanEntityRuleTag[] Tags { get; set; }
        /// <summary>
        /// This will include list of apptypes that should be evaluated against workload for plan association
        /// </summary>
        Commvault.Powershell.Models.IIdName[] Workloads { get; set; }

    }
}
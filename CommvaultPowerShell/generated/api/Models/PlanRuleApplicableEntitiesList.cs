// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// List of entities that are applicable for plan association via plan assignment rules.
    /// </summary>
    public partial class PlanRuleApplicableEntitiesList :
        Commvault.Powershell.Models.IPlanRuleApplicableEntitiesList,
        Commvault.Powershell.Models.IPlanRuleApplicableEntitiesListInternal
    {

        /// <summary>Backing field for <see cref="Entities" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IPlanRuleApplicableEntity> _entities;

        /// <summary>Details of entity applicable for plan association.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IPlanRuleApplicableEntity> Entities { get => this._entities; set => this._entities = value; }

        /// <summary>Creates an new <see cref="PlanRuleApplicableEntitiesList" /> instance.</summary>
        public PlanRuleApplicableEntitiesList()
        {

        }
    }
    /// List of entities that are applicable for plan association via plan assignment rules.
    public partial interface IPlanRuleApplicableEntitiesList :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Details of entity applicable for plan association.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Details of entity applicable for plan association.",
        SerializedName = @"entities",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IPlanRuleApplicableEntity) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IPlanRuleApplicableEntity> Entities { get; set; }

    }
    /// List of entities that are applicable for plan association via plan assignment rules.
    internal partial interface IPlanRuleApplicableEntitiesListInternal

    {
        /// <summary>Details of entity applicable for plan association.</summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.IPlanRuleApplicableEntity> Entities { get; set; }

    }
}
// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>RuleContent</summary>
    public partial class RuleGroupContent :
        Commvault.Powershell.Models.IRuleGroupContent,
        Commvault.Powershell.Models.IRuleGroupContentInternal
    {

        /// <summary>Backing field for <see cref="MatchRule" /> property.</summary>
        private string _matchRule;

        /// <summary>Enum which specifies the whether to match all rules or any of the rules</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string MatchRule { get => this._matchRule; set => this._matchRule = value; }

        /// <summary>Backing field for <see cref="Rules" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IRuleContent> _rules;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IRuleContent> Rules { get => this._rules; set => this._rules = value; }

        /// <summary>Creates an new <see cref="RuleGroupContent" /> instance.</summary>
        public RuleGroupContent()
        {

        }
    }
    /// RuleContent
    public partial interface IRuleGroupContent :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Enum which specifies the whether to match all rules or any of the rules</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enum which specifies the whether to match all rules or any of the rules",
        SerializedName = @"matchRule",
        PossibleTypes = new [] { typeof(string) })]
        string MatchRule { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"rules",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IRuleContent) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IRuleContent> Rules { get; set; }

    }
    /// RuleContent
    internal partial interface IRuleGroupContentInternal

    {
        /// <summary>Enum which specifies the whether to match all rules or any of the rules</summary>
        string MatchRule { get; set; }

        System.Collections.Generic.List<Commvault.Powershell.Models.IRuleContent> Rules { get; set; }

    }
}
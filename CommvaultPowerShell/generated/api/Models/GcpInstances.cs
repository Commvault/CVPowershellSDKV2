// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class GcpInstances :
        Commvault.Powershell.Models.IGcpInstances,
        Commvault.Powershell.Models.IGcpInstancesInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>
        /// Returns the name to be displayed on UI in the format: instanceName [projectName]
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="InstanceName" /> property.</summary>
        private string _instanceName;

        /// <summary>the google spanner instance name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string InstanceName { get => this._instanceName; set => this._instanceName = value; }

        /// <summary>Backing field for <see cref="ProjectName" /> property.</summary>
        private string _projectName;

        /// <summary>google cloud project the instance belongs to</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ProjectName { get => this._projectName; set => this._projectName = value; }

        /// <summary>Creates an new <see cref="GcpInstances" /> instance.</summary>
        public GcpInstances()
        {

        }
    }
    public partial interface IGcpInstances :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Returns the name to be displayed on UI in the format: instanceName [projectName]
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Returns the name to be displayed on UI in the format: instanceName [projectName]",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>the google spanner instance name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the google spanner instance name",
        SerializedName = @"instanceName",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceName { get; set; }
        /// <summary>google cloud project the instance belongs to</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"google cloud project the instance belongs to",
        SerializedName = @"projectName",
        PossibleTypes = new [] { typeof(string) })]
        string ProjectName { get; set; }

    }
    internal partial interface IGcpInstancesInternal

    {
        /// <summary>
        /// Returns the name to be displayed on UI in the format: instanceName [projectName]
        /// </summary>
        string DisplayName { get; set; }
        /// <summary>the google spanner instance name</summary>
        string InstanceName { get; set; }
        /// <summary>google cloud project the instance belongs to</summary>
        string ProjectName { get; set; }

    }
}
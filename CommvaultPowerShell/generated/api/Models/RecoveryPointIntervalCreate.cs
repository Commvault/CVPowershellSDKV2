// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Recovery point interval inputs for continuous replication group. Provide atleast one of crash consistent and application
    /// consistent interval.
    /// </summary>
    public partial class RecoveryPointIntervalCreate :
        Commvault.Powershell.Models.IRecoveryPointIntervalCreate,
        Commvault.Powershell.Models.IRecoveryPointIntervalCreateInternal
    {

        /// <summary>Backing field for <see cref="ApplicationConsistentRpInterval" /> property.</summary>
        private long? _applicationConsistentRpInterval;

        /// <summary>
        /// Time(in seconds) after which the source VMs are quiesced to create application-consistent recovery points for destination
        /// VMs. Applicable only for Point in time recovery.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? ApplicationConsistentRpInterval { get => this._applicationConsistentRpInterval; set => this._applicationConsistentRpInterval = value; }

        /// <summary>Backing field for <see cref="CrashConsistentRpInterval" /> property.</summary>
        private long? _crashConsistentRpInterval;

        /// <summary>
        /// Minimum time interval(in seconds) between VM recovery points. Applicable only for Point in time recovery.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? CrashConsistentRpInterval { get => this._crashConsistentRpInterval; set => this._crashConsistentRpInterval = value; }

        /// <summary>Creates an new <see cref="RecoveryPointIntervalCreate" /> instance.</summary>
        public RecoveryPointIntervalCreate()
        {

        }
    }
    /// Recovery point interval inputs for continuous replication group. Provide atleast one of crash consistent and application
    /// consistent interval.
    public partial interface IRecoveryPointIntervalCreate :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Time(in seconds) after which the source VMs are quiesced to create application-consistent recovery points for destination
        /// VMs. Applicable only for Point in time recovery.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time(in seconds) after which the source VMs are quiesced to create application-consistent recovery points for destination VMs. Applicable only for Point in time recovery.",
        SerializedName = @"applicationConsistentRpInterval",
        PossibleTypes = new [] { typeof(long) })]
        long? ApplicationConsistentRpInterval { get; set; }
        /// <summary>
        /// Minimum time interval(in seconds) between VM recovery points. Applicable only for Point in time recovery.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Minimum time interval(in seconds) between VM recovery points. Applicable only for Point in time recovery.",
        SerializedName = @"crashConsistentRpInterval",
        PossibleTypes = new [] { typeof(long) })]
        long? CrashConsistentRpInterval { get; set; }

    }
    /// Recovery point interval inputs for continuous replication group. Provide atleast one of crash consistent and application
    /// consistent interval.
    internal partial interface IRecoveryPointIntervalCreateInternal

    {
        /// <summary>
        /// Time(in seconds) after which the source VMs are quiesced to create application-consistent recovery points for destination
        /// VMs. Applicable only for Point in time recovery.
        /// </summary>
        long? ApplicationConsistentRpInterval { get; set; }
        /// <summary>
        /// Minimum time interval(in seconds) between VM recovery points. Applicable only for Point in time recovery.
        /// </summary>
        long? CrashConsistentRpInterval { get; set; }

    }
}
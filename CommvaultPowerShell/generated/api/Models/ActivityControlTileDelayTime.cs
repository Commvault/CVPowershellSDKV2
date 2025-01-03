// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>ActivityControlTileDelayTime</summary>
    public partial class ActivityControlTileDelayTime :
        Commvault.Powershell.Models.IActivityControlTileDelayTime,
        Commvault.Powershell.Models.IActivityControlTileDelayTimeInternal
    {

        /// <summary>Internal Acessors for TimeZone</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IActivityControlTileDelayTimeInternal.TimeZone { get => (this._timeZone = this._timeZone ?? new Commvault.Powershell.Models.IdName()); set { {_timeZone = value;} } }

        /// <summary>Backing field for <see cref="Time" /> property.</summary>
        private long? _time;

        /// <summary>delay time in unix timestamp</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? Time { get => this._time; set => this._time = value; }

        /// <summary>Backing field for <see cref="TimeZone" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _timeZone;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName TimeZone { get => (this._timeZone = this._timeZone ?? new Commvault.Powershell.Models.IdName()); set => this._timeZone = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? TimeZoneId { get => ((Commvault.Powershell.Models.IIdNameInternal)TimeZone).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)TimeZone).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TimeZoneName { get => ((Commvault.Powershell.Models.IIdNameInternal)TimeZone).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)TimeZone).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>actual delay time value in string format according to the timezone</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ActivityControlTileDelayTime" /> instance.</summary>
        public ActivityControlTileDelayTime()
        {

        }
    }
    /// ActivityControlTileDelayTime
    public partial interface IActivityControlTileDelayTime :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>delay time in unix timestamp</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"delay time in unix timestamp",
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(long) })]
        long? Time { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? TimeZoneId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string TimeZoneName { get; set; }
        /// <summary>actual delay time value in string format according to the timezone</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"actual delay time value in string format according to the timezone",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// ActivityControlTileDelayTime
    internal partial interface IActivityControlTileDelayTimeInternal

    {
        /// <summary>delay time in unix timestamp</summary>
        long? Time { get; set; }

        Commvault.Powershell.Models.IIdName TimeZone { get; set; }

        long? TimeZoneId { get; set; }

        string TimeZoneName { get; set; }
        /// <summary>actual delay time value in string format according to the timezone</summary>
        string Value { get; set; }

    }
}
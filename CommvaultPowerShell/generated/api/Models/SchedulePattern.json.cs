// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Used to describe when the schedule runs</summary>
    public partial class SchedulePattern
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Commvault.Powershell.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Commvault.Powershell.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Commvault.Powershell.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Commvault.Powershell.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Commvault.Powershell.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.ISchedulePattern.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.ISchedulePattern.</returns>
        public static Commvault.Powershell.Models.ISchedulePattern FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new SchedulePattern(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="SchedulePattern" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SchedulePattern(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_timezone = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("timezone"), out var __jsonTimezone) ? Commvault.Powershell.Models.IdName.FromJson(__jsonTimezone) : _timezone;}
            {_scheduleFrequencyType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("scheduleFrequencyType"), out var __jsonScheduleFrequencyType) ? (string)__jsonScheduleFrequencyType : (string)_scheduleFrequencyType;}
            {_frequency = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("frequency"), out var __jsonFrequency) ? (long?)__jsonFrequency : _frequency;}
            {_weeklyDays = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("weeklyDays"), out var __jsonWeeklyDays) ? If( __jsonWeeklyDays as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Commvault.Powershell.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _weeklyDays;}
            {_dayOfMonth = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("dayOfMonth"), out var __jsonDayOfMonth) ? (long?)__jsonDayOfMonth : _dayOfMonth;}
            {_weekOfMonth = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("weekOfMonth"), out var __jsonWeekOfMonth) ? (string)__jsonWeekOfMonth : (string)_weekOfMonth;}
            {_dayOfWeek = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("dayOfWeek"), out var __jsonDayOfWeek) ? (string)__jsonDayOfWeek : (string)_dayOfWeek;}
            {_monthOfYear = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("monthOfYear"), out var __jsonMonthOfYear) ? (string)__jsonMonthOfYear : (string)_monthOfYear;}
            {_repeatIntervalInMinutes = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("repeatIntervalInMinutes"), out var __jsonRepeatIntervalInMinutes) ? (long?)__jsonRepeatIntervalInMinutes : _repeatIntervalInMinutes;}
            {_repeatUntilTime = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("repeatUntilTime"), out var __jsonRepeatUntilTime) ? (long?)__jsonRepeatUntilTime : _repeatUntilTime;}
            {_startTime = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("startTime"), out var __jsonStartTime) ? (long?)__jsonStartTime : _startTime;}
            {_startDate = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("startDate"), out var __jsonStartDate) ? (long?)__jsonStartDate : _startDate;}
            {_endDate = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("endDate"), out var __jsonEndDate) ? (long?)__jsonEndDate : _endDate;}
            {_noOfTimes = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("noOfTimes"), out var __jsonNoOfTimes) ? (long?)__jsonNoOfTimes : _noOfTimes;}
            {_exceptions = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("exceptions"), out var __jsonExceptions) ? If( __jsonExceptions as Commvault.Powershell.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Commvault.Powershell.Models.IScheduleRunException>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Commvault.Powershell.Models.IScheduleRunException) (Commvault.Powershell.Models.ScheduleRunException.FromJson(__p) )) ))() : null : _exceptions;}
            {_daysBetweenSyntheticFulls = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("daysBetweenSyntheticFulls"), out var __jsonDaysBetweenSyntheticFulls) ? (long?)__jsonDaysBetweenSyntheticFulls : _daysBetweenSyntheticFulls;}
            {_maxBackupIntervalInMins = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("maxBackupIntervalInMins"), out var __jsonMaxBackupIntervalInMins) ? (long?)__jsonMaxBackupIntervalInMins : _maxBackupIntervalInMins;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SchedulePattern" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SchedulePattern" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </returns>
        public Commvault.Powershell.Runtime.Json.JsonNode ToJson(Commvault.Powershell.Runtime.Json.JsonObject container, Commvault.Powershell.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Commvault.Powershell.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._timezone ? (Commvault.Powershell.Runtime.Json.JsonNode) this._timezone.ToJson(null,serializationMode) : null, "timezone" ,container.Add );
            AddIf( null != (((object)this._scheduleFrequencyType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._scheduleFrequencyType.ToString()) : null, "scheduleFrequencyType" ,container.Add );
            AddIf( null != this._frequency ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._frequency) : null, "frequency" ,container.Add );
            if (null != this._weeklyDays)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._weeklyDays )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("weeklyDays",__w);
            }
            AddIf( null != this._dayOfMonth ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._dayOfMonth) : null, "dayOfMonth" ,container.Add );
            AddIf( null != (((object)this._weekOfMonth)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._weekOfMonth.ToString()) : null, "weekOfMonth" ,container.Add );
            AddIf( null != (((object)this._dayOfWeek)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._dayOfWeek.ToString()) : null, "dayOfWeek" ,container.Add );
            AddIf( null != (((object)this._monthOfYear)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._monthOfYear.ToString()) : null, "monthOfYear" ,container.Add );
            AddIf( null != this._repeatIntervalInMinutes ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._repeatIntervalInMinutes) : null, "repeatIntervalInMinutes" ,container.Add );
            AddIf( null != this._repeatUntilTime ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._repeatUntilTime) : null, "repeatUntilTime" ,container.Add );
            AddIf( null != this._startTime ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._startTime) : null, "startTime" ,container.Add );
            AddIf( null != this._startDate ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._startDate) : null, "startDate" ,container.Add );
            AddIf( null != this._endDate ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._endDate) : null, "endDate" ,container.Add );
            AddIf( null != this._noOfTimes ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._noOfTimes) : null, "noOfTimes" ,container.Add );
            if (null != this._exceptions)
            {
                var __r = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __s in this._exceptions )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("exceptions",__r);
            }
            AddIf( null != this._daysBetweenSyntheticFulls ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._daysBetweenSyntheticFulls) : null, "daysBetweenSyntheticFulls" ,container.Add );
            AddIf( null != this._maxBackupIntervalInMins ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._maxBackupIntervalInMins) : null, "maxBackupIntervalInMins" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}
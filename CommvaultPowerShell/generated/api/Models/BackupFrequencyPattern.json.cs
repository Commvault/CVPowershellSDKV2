// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Used to describe the frequency of backup</summary>
    public partial class BackupFrequencyPattern
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
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="BackupFrequencyPattern" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal BackupFrequencyPattern(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_scheduleFrequencyType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("scheduleFrequencyType"), out var __jsonScheduleFrequencyType) ? (string)__jsonScheduleFrequencyType : (string)_scheduleFrequencyType;}
            {_frequency = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("frequency"), out var __jsonFrequency) ? (long?)__jsonFrequency : _frequency;}
            {_weeklyDays = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("weeklyDays"), out var __jsonWeeklyDays) ? If( __jsonWeeklyDays as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Commvault.Powershell.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _weeklyDays;}
            {_dayOfMonth = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("dayOfMonth"), out var __jsonDayOfMonth) ? (long?)__jsonDayOfMonth : _dayOfMonth;}
            {_weekOfMonth = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("weekOfMonth"), out var __jsonWeekOfMonth) ? (string)__jsonWeekOfMonth : (string)_weekOfMonth;}
            {_dayOfWeek = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("dayOfWeek"), out var __jsonDayOfWeek) ? (string)__jsonDayOfWeek : (string)_dayOfWeek;}
            {_monthOfYear = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("monthOfYear"), out var __jsonMonthOfYear) ? (string)__jsonMonthOfYear : (string)_monthOfYear;}
            {_startTime = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("startTime"), out var __jsonStartTime) ? (long?)__jsonStartTime : _startTime;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IBackupFrequencyPattern.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IBackupFrequencyPattern.</returns>
        public static Commvault.Powershell.Models.IBackupFrequencyPattern FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new BackupFrequencyPattern(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="BackupFrequencyPattern" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="BackupFrequencyPattern" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._startTime ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((long)this._startTime) : null, "startTime" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}
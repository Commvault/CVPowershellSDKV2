// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Used to describe when the schedule runs</summary>
    [System.ComponentModel.TypeConverter(typeof(SchedulePatternTypeConverter))]
    public partial class SchedulePattern
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.SchedulePattern"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ISchedulePattern" />.</returns>
        public static Commvault.Powershell.Models.ISchedulePattern DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SchedulePattern(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.SchedulePattern"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ISchedulePattern" />.</returns>
        public static Commvault.Powershell.Models.ISchedulePattern DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SchedulePattern(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SchedulePattern" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SchedulePattern" /> model class.</returns>
        public static Commvault.Powershell.Models.ISchedulePattern FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.SchedulePattern"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SchedulePattern(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Timezone"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).Timezone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Timezone",((Commvault.Powershell.Models.ISchedulePatternInternal)this).Timezone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScheduleFrequencyType"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).ScheduleFrequencyType = (string) content.GetValueForProperty("ScheduleFrequencyType",((Commvault.Powershell.Models.ISchedulePatternInternal)this).ScheduleFrequencyType, global::System.Convert.ToString);
            }
            if (content.Contains("Frequency"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).Frequency = (long?) content.GetValueForProperty("Frequency",((Commvault.Powershell.Models.ISchedulePatternInternal)this).Frequency, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("WeeklyDays"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeeklyDays = (System.Collections.Generic.List<string>) content.GetValueForProperty("WeeklyDays",((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeeklyDays, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DayOfMonth"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfMonth = (long?) content.GetValueForProperty("DayOfMonth",((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfMonth, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("WeekOfMonth"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeekOfMonth = (string) content.GetValueForProperty("WeekOfMonth",((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeekOfMonth, global::System.Convert.ToString);
            }
            if (content.Contains("DayOfWeek"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfWeek = (string) content.GetValueForProperty("DayOfWeek",((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfWeek, global::System.Convert.ToString);
            }
            if (content.Contains("MonthOfYear"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).MonthOfYear = (string) content.GetValueForProperty("MonthOfYear",((Commvault.Powershell.Models.ISchedulePatternInternal)this).MonthOfYear, global::System.Convert.ToString);
            }
            if (content.Contains("RepeatIntervalInMinutes"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatIntervalInMinutes = (long?) content.GetValueForProperty("RepeatIntervalInMinutes",((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatIntervalInMinutes, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RepeatUntilTime"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatUntilTime = (long?) content.GetValueForProperty("RepeatUntilTime",((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatUntilTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("StartTime"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartTime = (long?) content.GetValueForProperty("StartTime",((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("StartDate"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartDate = (long?) content.GetValueForProperty("StartDate",((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartDate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("EndDate"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).EndDate = (long?) content.GetValueForProperty("EndDate",((Commvault.Powershell.Models.ISchedulePatternInternal)this).EndDate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("NoOfTimes"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).NoOfTimes = (long?) content.GetValueForProperty("NoOfTimes",((Commvault.Powershell.Models.ISchedulePatternInternal)this).NoOfTimes, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Exceptions"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).Exceptions = (System.Collections.Generic.List<Commvault.Powershell.Models.IScheduleRunException>) content.GetValueForProperty("Exceptions",((Commvault.Powershell.Models.ISchedulePatternInternal)this).Exceptions, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IScheduleRunException>(__y, Commvault.Powershell.Models.ScheduleRunExceptionTypeConverter.ConvertFrom));
            }
            if (content.Contains("DaysBetweenSyntheticFulls"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).DaysBetweenSyntheticFulls = (long?) content.GetValueForProperty("DaysBetweenSyntheticFulls",((Commvault.Powershell.Models.ISchedulePatternInternal)this).DaysBetweenSyntheticFulls, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MaxBackupIntervalInMins"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).MaxBackupIntervalInMins = (long?) content.GetValueForProperty("MaxBackupIntervalInMins",((Commvault.Powershell.Models.ISchedulePatternInternal)this).MaxBackupIntervalInMins, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TimezoneId"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneId = (long?) content.GetValueForProperty("TimezoneId",((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TimezoneName"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneName = (string) content.GetValueForProperty("TimezoneName",((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.SchedulePattern"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SchedulePattern(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Timezone"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).Timezone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Timezone",((Commvault.Powershell.Models.ISchedulePatternInternal)this).Timezone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScheduleFrequencyType"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).ScheduleFrequencyType = (string) content.GetValueForProperty("ScheduleFrequencyType",((Commvault.Powershell.Models.ISchedulePatternInternal)this).ScheduleFrequencyType, global::System.Convert.ToString);
            }
            if (content.Contains("Frequency"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).Frequency = (long?) content.GetValueForProperty("Frequency",((Commvault.Powershell.Models.ISchedulePatternInternal)this).Frequency, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("WeeklyDays"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeeklyDays = (System.Collections.Generic.List<string>) content.GetValueForProperty("WeeklyDays",((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeeklyDays, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DayOfMonth"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfMonth = (long?) content.GetValueForProperty("DayOfMonth",((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfMonth, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("WeekOfMonth"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeekOfMonth = (string) content.GetValueForProperty("WeekOfMonth",((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeekOfMonth, global::System.Convert.ToString);
            }
            if (content.Contains("DayOfWeek"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfWeek = (string) content.GetValueForProperty("DayOfWeek",((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfWeek, global::System.Convert.ToString);
            }
            if (content.Contains("MonthOfYear"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).MonthOfYear = (string) content.GetValueForProperty("MonthOfYear",((Commvault.Powershell.Models.ISchedulePatternInternal)this).MonthOfYear, global::System.Convert.ToString);
            }
            if (content.Contains("RepeatIntervalInMinutes"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatIntervalInMinutes = (long?) content.GetValueForProperty("RepeatIntervalInMinutes",((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatIntervalInMinutes, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RepeatUntilTime"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatUntilTime = (long?) content.GetValueForProperty("RepeatUntilTime",((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatUntilTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("StartTime"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartTime = (long?) content.GetValueForProperty("StartTime",((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("StartDate"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartDate = (long?) content.GetValueForProperty("StartDate",((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartDate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("EndDate"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).EndDate = (long?) content.GetValueForProperty("EndDate",((Commvault.Powershell.Models.ISchedulePatternInternal)this).EndDate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("NoOfTimes"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).NoOfTimes = (long?) content.GetValueForProperty("NoOfTimes",((Commvault.Powershell.Models.ISchedulePatternInternal)this).NoOfTimes, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Exceptions"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).Exceptions = (System.Collections.Generic.List<Commvault.Powershell.Models.IScheduleRunException>) content.GetValueForProperty("Exceptions",((Commvault.Powershell.Models.ISchedulePatternInternal)this).Exceptions, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IScheduleRunException>(__y, Commvault.Powershell.Models.ScheduleRunExceptionTypeConverter.ConvertFrom));
            }
            if (content.Contains("DaysBetweenSyntheticFulls"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).DaysBetweenSyntheticFulls = (long?) content.GetValueForProperty("DaysBetweenSyntheticFulls",((Commvault.Powershell.Models.ISchedulePatternInternal)this).DaysBetweenSyntheticFulls, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MaxBackupIntervalInMins"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).MaxBackupIntervalInMins = (long?) content.GetValueForProperty("MaxBackupIntervalInMins",((Commvault.Powershell.Models.ISchedulePatternInternal)this).MaxBackupIntervalInMins, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TimezoneId"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneId = (long?) content.GetValueForProperty("TimezoneId",((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TimezoneName"))
            {
                ((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneName = (string) content.GetValueForProperty("TimezoneName",((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Used to describe when the schedule runs
    [System.ComponentModel.TypeConverter(typeof(SchedulePatternTypeConverter))]
    public partial interface ISchedulePattern

    {

    }
}
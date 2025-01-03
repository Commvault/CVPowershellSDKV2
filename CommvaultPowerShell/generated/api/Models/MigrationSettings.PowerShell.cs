// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Name the migration group and define the frequency</summary>
    [System.ComponentModel.TypeConverter(typeof(MigrationSettingsTypeConverter))]
    public partial class MigrationSettings
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.MigrationSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IMigrationSettings" />.</returns>
        public static Commvault.Powershell.Models.IMigrationSettings DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MigrationSettings(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.MigrationSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IMigrationSettings" />.</returns>
        public static Commvault.Powershell.Models.IMigrationSettings DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MigrationSettings(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MigrationSettings" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MigrationSettings" /> model class.</returns>
        public static Commvault.Powershell.Models.IMigrationSettings FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.MigrationSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MigrationSettings(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MigrationFrequency"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequency = (Commvault.Powershell.Models.IPlanPattern) content.GetValueForProperty("MigrationFrequency",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequency, Commvault.Powershell.Models.PlanPatternTypeConverter.ConvertFrom);
            }
            if (content.Contains("MigrationWindow"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationWindow = (System.Collections.Generic.List<Commvault.Powershell.Models.ICreateBlackoutWindow>) content.GetValueForProperty("MigrationWindow",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationWindow, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.ICreateBlackoutWindow>(__y, Commvault.Powershell.Models.CreateBlackoutWindowTypeConverter.ConvertFrom));
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationFrequencyMinuteFrequency"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMinuteFrequency = (long?) content.GetValueForProperty("MigrationFrequencyMinuteFrequency",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMinuteFrequency, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationFrequencyHourlyFrequency"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyHourlyFrequency = (long?) content.GetValueForProperty("MigrationFrequencyHourlyFrequency",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyHourlyFrequency, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationFrequencyDailyFrequency"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyDailyFrequency = (long?) content.GetValueForProperty("MigrationFrequencyDailyFrequency",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyDailyFrequency, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationFrequencyWeeklyFrequency"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyWeeklyFrequency = (long?) content.GetValueForProperty("MigrationFrequencyWeeklyFrequency",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyWeeklyFrequency, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationFrequencyWeeklyFrequencyDays"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyWeeklyFrequencyDays = (System.Collections.Generic.List<string>) content.GetValueForProperty("MigrationFrequencyWeeklyFrequencyDays",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyWeeklyFrequencyDays, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("MigrationFrequencyMonthlyFrequency"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequency = (long?) content.GetValueForProperty("MigrationFrequencyMonthlyFrequency",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequency, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationFrequencyMonthlyFrequencyWeekOfMonth"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequencyWeekOfMonth = (string) content.GetValueForProperty("MigrationFrequencyMonthlyFrequencyWeekOfMonth",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequencyWeekOfMonth, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationFrequencyMonthlyFrequencyDayOfWeek"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequencyDayOfWeek = (string) content.GetValueForProperty("MigrationFrequencyMonthlyFrequencyDayOfWeek",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequencyDayOfWeek, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationFrequencyMonthlyFrequencyDayOfMonth"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequencyDayOfMonth = (long?) content.GetValueForProperty("MigrationFrequencyMonthlyFrequencyDayOfMonth",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequencyDayOfMonth, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationFrequencyYearlyFrequencyWeekOfMonth"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyWeekOfMonth = (string) content.GetValueForProperty("MigrationFrequencyYearlyFrequencyWeekOfMonth",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyWeekOfMonth, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationFrequencyYearlyFrequencyDayOfWeek"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyDayOfWeek = (string) content.GetValueForProperty("MigrationFrequencyYearlyFrequencyDayOfWeek",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyDayOfWeek, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationFrequencyYearlyFrequencyDayOfMonth"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyDayOfMonth = (long?) content.GetValueForProperty("MigrationFrequencyYearlyFrequencyDayOfMonth",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyDayOfMonth, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationFrequencyYearlyFrequencyMonthOfYear"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyMonthOfYear = (string) content.GetValueForProperty("MigrationFrequencyYearlyFrequencyMonthOfYear",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyMonthOfYear, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationFrequencyStartTime"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyStartTime = (long?) content.GetValueForProperty("MigrationFrequencyStartTime",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyStartTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.MigrationSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MigrationSettings(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MigrationFrequency"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequency = (Commvault.Powershell.Models.IPlanPattern) content.GetValueForProperty("MigrationFrequency",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequency, Commvault.Powershell.Models.PlanPatternTypeConverter.ConvertFrom);
            }
            if (content.Contains("MigrationWindow"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationWindow = (System.Collections.Generic.List<Commvault.Powershell.Models.ICreateBlackoutWindow>) content.GetValueForProperty("MigrationWindow",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationWindow, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.ICreateBlackoutWindow>(__y, Commvault.Powershell.Models.CreateBlackoutWindowTypeConverter.ConvertFrom));
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationFrequencyMinuteFrequency"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMinuteFrequency = (long?) content.GetValueForProperty("MigrationFrequencyMinuteFrequency",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMinuteFrequency, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationFrequencyHourlyFrequency"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyHourlyFrequency = (long?) content.GetValueForProperty("MigrationFrequencyHourlyFrequency",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyHourlyFrequency, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationFrequencyDailyFrequency"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyDailyFrequency = (long?) content.GetValueForProperty("MigrationFrequencyDailyFrequency",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyDailyFrequency, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationFrequencyWeeklyFrequency"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyWeeklyFrequency = (long?) content.GetValueForProperty("MigrationFrequencyWeeklyFrequency",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyWeeklyFrequency, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationFrequencyWeeklyFrequencyDays"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyWeeklyFrequencyDays = (System.Collections.Generic.List<string>) content.GetValueForProperty("MigrationFrequencyWeeklyFrequencyDays",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyWeeklyFrequencyDays, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("MigrationFrequencyMonthlyFrequency"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequency = (long?) content.GetValueForProperty("MigrationFrequencyMonthlyFrequency",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequency, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationFrequencyMonthlyFrequencyWeekOfMonth"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequencyWeekOfMonth = (string) content.GetValueForProperty("MigrationFrequencyMonthlyFrequencyWeekOfMonth",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequencyWeekOfMonth, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationFrequencyMonthlyFrequencyDayOfWeek"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequencyDayOfWeek = (string) content.GetValueForProperty("MigrationFrequencyMonthlyFrequencyDayOfWeek",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequencyDayOfWeek, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationFrequencyMonthlyFrequencyDayOfMonth"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequencyDayOfMonth = (long?) content.GetValueForProperty("MigrationFrequencyMonthlyFrequencyDayOfMonth",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyMonthlyFrequencyDayOfMonth, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationFrequencyYearlyFrequencyWeekOfMonth"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyWeekOfMonth = (string) content.GetValueForProperty("MigrationFrequencyYearlyFrequencyWeekOfMonth",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyWeekOfMonth, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationFrequencyYearlyFrequencyDayOfWeek"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyDayOfWeek = (string) content.GetValueForProperty("MigrationFrequencyYearlyFrequencyDayOfWeek",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyDayOfWeek, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationFrequencyYearlyFrequencyDayOfMonth"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyDayOfMonth = (long?) content.GetValueForProperty("MigrationFrequencyYearlyFrequencyDayOfMonth",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyDayOfMonth, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MigrationFrequencyYearlyFrequencyMonthOfYear"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyMonthOfYear = (string) content.GetValueForProperty("MigrationFrequencyYearlyFrequencyMonthOfYear",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyYearlyFrequencyMonthOfYear, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationFrequencyStartTime"))
            {
                ((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyStartTime = (long?) content.GetValueForProperty("MigrationFrequencyStartTime",((Commvault.Powershell.Models.IMigrationSettingsInternal)this).MigrationFrequencyStartTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
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
    /// Name the migration group and define the frequency
    [System.ComponentModel.TypeConverter(typeof(MigrationSettingsTypeConverter))]
    public partial interface IMigrationSettings

    {

    }
}
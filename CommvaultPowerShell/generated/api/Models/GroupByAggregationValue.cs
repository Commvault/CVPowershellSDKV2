// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>This is the data model for return aggregation result for single group</summary>
    public partial class GroupByAggregationValue :
        Commvault.Powershell.Models.IGroupByAggregationValue,
        Commvault.Powershell.Models.IGroupByAggregationValueInternal
    {

        /// <summary>Backing field for <see cref="FuncValue" /> property.</summary>
        private string _funcValue;

        /// <summary>
        /// value returned by aggregation function for global search entities for a particular group
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string FuncValue { get => this._funcValue; set => this._funcValue = value; }

        /// <summary>Backing field for <see cref="GroupByVals" /> property.</summary>
        private Commvault.Powershell.Models.INameValue[] _groupByVals;

        /// <summary>list of groupby attribute's Name and value pair.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.INameValue[] GroupByVals { get => this._groupByVals; set => this._groupByVals = value; }

        /// <summary>Creates an new <see cref="GroupByAggregationValue" /> instance.</summary>
        public GroupByAggregationValue()
        {

        }
    }
    /// This is the data model for return aggregation result for single group
    public partial interface IGroupByAggregationValue :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// value returned by aggregation function for global search entities for a particular group
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"value returned by aggregation function for global search entities for a particular group",
        SerializedName = @"funcValue",
        PossibleTypes = new [] { typeof(string) })]
        string FuncValue { get; set; }
        /// <summary>list of groupby attribute's Name and value pair.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"list of groupby attribute's Name and value pair.",
        SerializedName = @"groupByVals",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.INameValue) })]
        Commvault.Powershell.Models.INameValue[] GroupByVals { get; set; }

    }
    /// This is the data model for return aggregation result for single group
    internal partial interface IGroupByAggregationValueInternal

    {
        /// <summary>
        /// value returned by aggregation function for global search entities for a particular group
        /// </summary>
        string FuncValue { get; set; }
        /// <summary>list of groupby attribute's Name and value pair.</summary>
        Commvault.Powershell.Models.INameValue[] GroupByVals { get; set; }

    }
}
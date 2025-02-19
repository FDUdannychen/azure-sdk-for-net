// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Schedule-based autoscale request parameters. </summary>
    public partial class AutoscaleRecurrence
    {
        /// <summary> Initializes a new instance of AutoscaleRecurrence. </summary>
        public AutoscaleRecurrence()
        {
            Schedule = new ChangeTrackingList<AutoscaleSchedule>();
        }

        /// <summary> Initializes a new instance of AutoscaleRecurrence. </summary>
        /// <param name="timeZone"> The time zone for the autoscale schedule times. </param>
        /// <param name="schedule"> Array of schedule-based autoscale rules. </param>
        internal AutoscaleRecurrence(string timeZone, IList<AutoscaleSchedule> schedule)
        {
            TimeZone = timeZone;
            Schedule = schedule;
        }

        /// <summary> The time zone for the autoscale schedule times. </summary>
        public string TimeZone { get; set; }
        /// <summary> Array of schedule-based autoscale rules. </summary>
        public IList<AutoscaleSchedule> Schedule { get; }
    }
}

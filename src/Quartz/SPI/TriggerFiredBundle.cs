/* 
* Copyright 2004-2005 OpenSymphony 
* 
* Licensed under the Apache License, Version 2.0 (the "License"); you may not 
* use this file except in compliance with the License. You may obtain a copy 
* of the License at 
* 
*   http://www.apache.org/licenses/LICENSE-2.0 
*   
* Unless required by applicable law or agreed to in writing, software 
* distributed under the License is distributed on an "AS IS" BASIS, WITHOUT 
* WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the 
* License for the specific language governing permissions and limitations 
* under the License.
* 
*/

/*
* Previously Copyright (c) 2001-2004 James House
*/
using System;
using Nullables;
using Quartz.Core;

namespace Quartz.Spi
{
    /// <summary>
    /// A simple class (structure) used for returning execution-time data from the
    /// JobStore to the <code>QuartzSchedulerThread</code>.
    /// </summary>
    /// <seealso cref="QuartzScheduler" />
    /// <author>James House</author>
    [Serializable]
    public class TriggerFiredBundle
    {
        private JobDetail job;
        private Trigger trigger;
        private ICalendar cal;
        private bool jobIsRecovering;
        private NullableDateTime fireTime;
        private NullableDateTime scheduledFireTime;
        private NullableDateTime prevFireTime;
        private NullableDateTime nextFireTime;

        /// <summary>
        /// Gets the job detail.
        /// </summary>
        /// <value>The job detail.</value>
        public virtual JobDetail JobDetail
        {
            get { return job; }
        }

        /// <summary>
        /// Gets the trigger.
        /// </summary>
        /// <value>The trigger.</value>
        public virtual Trigger Trigger
        {
            get { return trigger; }
        }

        /// <summary>
        /// Gets the calendar.
        /// </summary>
        /// <value>The calendar.</value>
        public virtual ICalendar Calendar
        {
            get { return cal; }
        }

        /// <summary>
        /// Gets a value indicating whether this <see cref="TriggerFiredBundle"/> is recovering.
        /// </summary>
        /// <value><c>true</c> if recovering; otherwise, <c>false</c>.</value>
        public virtual bool Recovering
        {
            get { return jobIsRecovering; }
        }

        /// <returns> Returns the fireTime.
        /// </returns>
        public virtual NullableDateTime FireTime
        {
            get { return fireTime; }
        }

        /// <summary>
        /// Gets the next fire time.
        /// </summary>
        /// <value>The next fire time.</value>
        /// <returns> Returns the nextFireTime.
        /// </returns>
        public virtual NullableDateTime NextFireTime
        {
            get { return nextFireTime; }
        }

        /// <summary>
        /// Gets the prev fire time.
        /// </summary>
        /// <value>The prev fire time.</value>
        /// <returns> Returns the prevFireTime.
        /// </returns>
        public virtual NullableDateTime PrevFireTime
        {
            get { return prevFireTime; }
        }

        /// <returns> Returns the scheduledFireTime.
        /// </returns>
        public virtual NullableDateTime ScheduledFireTime
        {
            get { return scheduledFireTime; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerFiredBundle"/> class.
        /// </summary>
        /// <param name="job">The job.</param>
        /// <param name="trigger">The trigger.</param>
        /// <param name="cal">The calendar.</param>
        /// <param name="jobIsRecovering">if set to <c>true</c> [job is recovering].</param>
        /// <param name="fireTime">The fire time.</param>
        /// <param name="scheduledFireTime">The scheduled fire time.</param>
        /// <param name="prevFireTime">The previous fire time.</param>
        /// <param name="nextFireTime">The next fire time.</param>
        public TriggerFiredBundle(JobDetail job, Trigger trigger, ICalendar cal, bool jobIsRecovering,
                                  NullableDateTime fireTime, NullableDateTime scheduledFireTime,
                                  NullableDateTime prevFireTime,
                                  NullableDateTime nextFireTime)
        {
            this.job = job;
            this.trigger = trigger;
            this.cal = cal;
            this.jobIsRecovering = jobIsRecovering;
            this.fireTime = fireTime;
            this.scheduledFireTime = scheduledFireTime;
            this.prevFireTime = prevFireTime;
            this.nextFireTime = nextFireTime;
        }
    }
}
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

namespace Quartz.Impl.AdoJobStore
{
	/// <summary>
	/// This interface can be implemented by any <code>IDriverDelegate</code>
	/// class that needs to use the constants contained herein.
	/// </summary>
	/// <author><a href="mailto:jeff@binaryfeed.org">Jeffrey Wescott</a></author>
	/// <author>James House</author>
	public class AdoConstants
	{
		// Table names
		public const string TableJobDetails = "JOB_DETAILS";
		public const string TableTriggers = "TRIGGERS";
		public const string TableSimpleTriggers = "SIMPLE_TRIGGERS";
		public const string TableCronTriggers = "CRON_TRIGGERS";
		public const string TableBlobTriggers = "BLOB_TRIGGERS";
		public const string TableFiredTriggers = "FIRED_TRIGGERS";
		public const string TableJobListeners = "JOB_LISTENERS";
		public const string TableTriggerListeners = "TRIGGER_LISTENERS";
		public const string TableCalendars = "CALENDARS";
		public const string TablePausedTriggers = "PAUSED_TRIGGER_GRPS";
		public const string TableLocks = "LOCKS";
		public const string TableSchedulerState = "SCHEDULER_STATE";
		
		// TableJobDetails columns names
		public const string ColumnJobName = "JOB_NAME";
		public const string ColumnJobGroup = "JOB_GROUP";
		public const string ColumnIsDurable = "IS_DURABLE";
		public const string ColumnIsVolatile = "IS_VOLATILE";
		public const string ColumnIsStateful = "IS_STATEFUL";
		public const string ColumnRequestsRecovery = "REQUESTS_RECOVERY";
		public const string ColumnJobDataMap = "JOB_DATA";
		public const string ColumnJobClass = "JOB_CLASS_NAME";
		public const string ColumnDescription = "DESCRIPTION";
		
		// TableJobListeners columns names
		public const string ColumnJobListener = "JOB_LISTENER";
		
		// TableTriggers columns names
		public const string ColumnTriggerName = "TRIGGER_NAME";
		public const string ColumnTriggerGroup = "TRIGGER_GROUP";
		public const string ColumnNextFireTime = "NEXT_FIRE_TIME";
		public const string ColumnPreviousFireTime = "PREV_FIRE_TIME";
		public const string ColumnTriggerState = "TRIGGER_STATE";
		public const string ColumnTriggerType = "TRIGGER_TYPE";
		public const string ColumnStartTime = "START_TIME";
		public const string ColumnEndTime = "END_TIME";
		public const string ColumnMifireInstruction = "MISFIRE_INSTR";
        public const string ColumnPriority = "PRIORITY";
		public const string AliasColumnNextFireTime = "ALIAS_NXT_FR_TM";
		
		// TableSimpleTriggers columns names
		public const string ColumnRepeatCount = "REPEAT_COUNT";
		public const string ColumnRepeatInterval = "REPEAT_INTERVAL";
		public const string ColumnTimesTriggered = "TIMES_TRIGGERED";
		
		// TableCronTriggers columns names
		public const string ColumnCronExpression = "CRON_EXPRESSION";
		
		// TableBlobTriggers columns names
		public const string ColumnBlob = "BLOB_DATA";
		public const string ColumnTimeZoneId = "TIME_ZONE_ID";
		
		// TableTriggerListeners
		public const string ColumnTriggerListener = "TRIGGER_LISTENER";
		
		// TableFiredTriggers columns names
		public const string ColumnInstanceName = "INSTANCE_NAME";
		public const string ColumnFiredTime = "FIRED_TIME";
		public const string ColumnEntryId = "ENTRY_ID";
		public const string ColumnEntryState = "STATE";
		
		// TableCalendars columns names
		public const string ColumnCalendarName = "CALENDAR_NAME";
		public const string ColumnCalendar = "CALENDAR";
		
		// TableLocks columns names
		public const string ColumnLockName = "LOCK_NAME";
		
		// TableLocks columns names
		public const string ColumnLastCheckinTime = "LAST_CHECKIN_TIME";
		public const string ColumnCheckinInterval = "CHECKIN_INTERVAL";
		
		// MISC CONSTANTS
		public const string DefaultTablePrefix = "QRTZ_";
		
		// STATES
		public const string StateWaiting = "WAITING";
		public const string StateAcquired = "ACQUIRED";
		public const string StateExecuting = "EXECUTING";
		public const string StateComplete = "COMPLETE";
		public const string StateBlocked = "BLOCKED";
		public const string StateError = "ERROR";
		public const string StatePaused = "PAUSED";
		public const string StatePausedBlocked = "PAUSED_BLOCKED";
		public const string StateDeleted = "DELETED";
        /**
 * @deprecated Whether a trigger has misfired is no longer a state, but 
 * rather now identified dynamically by whether the trigger's next fire 
 * time is more than the misfire threshold time in the past.
 */
        public const string StateMisfired = "MISFIRED";
		public const string AllGroupsPaused = "_$_ALL_GROUPS_PAUSED_$_";
		
		// TRIGGER TYPES
		public const string TriggerTypeSimple = "SIMPLE";
		public const string TriggerTypeCron = "CRON";
		public const string TriggerTypeBlob = "BLOB";
	}
}
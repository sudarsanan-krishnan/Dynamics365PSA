//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Common.Model
{
    /// <summary>
    /// Resources that have capacity and their capacity can be allocated to work.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
	public partial class BookableResource : Microsoft.Xrm.Sdk.Samples.Entity, System.ComponentModel.INotifyPropertyChanged
	{
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public BookableResource() :  base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "bookableresource";
		
		public const int EntityTypeCode = 1150;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Select the account that represents this resource.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference AccountId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("accountid");
			}
			set
			{
				this.SetAttributeValue("accountid", value);
				this.OnPropertyChanged("AccountId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the resource.
		/// </summary>
		public System.Nullable<System.Guid> BookableResourceId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("bookableresourceid");
			}
			set
			{
				this.SetAttributeValue("bookableresourceid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("BookableResourceId");
			}
		}
		
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.BookableResourceId = value;
			}
		}
		
		/// <summary>
		/// Specifies the working days and hours of the resource.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference CalendarId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("calendarid");
			}
			set
			{
				this.SetAttributeValue("calendarid", value);
				this.OnPropertyChanged("CalendarId");
			}
		}
		
		/// <summary>
		/// Select the contact that represents this resource.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference ContactId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("contactid");
			}
			set
			{
				this.SetAttributeValue("contactid", value);
				this.OnPropertyChanged("ContactId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the bookableresource with respect to the base currency.
		/// </summary>
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// The number of bookings to drip on the Mobile . This field is disabled/enabled based on Enable Drip Scheduling field
		/// </summary>
		public System.Nullable<int> msdyn_BookingsToDrip
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("msdyn_bookingstodrip");
			}
			set
			{
				this.SetAttributeValue("msdyn_bookingstodrip", value);
				this.OnPropertyChanged("msdyn_BookingsToDrip");
			}
		}
		
		/// <summary>
		/// Specify if this resource should be enabled for availablity search.
		/// </summary>
		public System.Nullable<bool> msdyn_DisplayOnScheduleAssistant
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_displayonscheduleassistant");
			}
			set
			{
				this.SetAttributeValue("msdyn_displayonscheduleassistant", value);
				this.OnPropertyChanged("msdyn_DisplayOnScheduleAssistant");
			}
		}
		
		/// <summary>
		/// Specify if this resource should be displayed on the schedule board.
		/// </summary>
		public System.Nullable<bool> msdyn_DisplayOnScheduleBoard
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_displayonscheduleboard");
			}
			set
			{
				this.SetAttributeValue("msdyn_displayonscheduleboard", value);
				this.OnPropertyChanged("msdyn_DisplayOnScheduleBoard");
			}
		}
		
		/// <summary>
		/// Enables drip scheduling on the mobile app.
		/// </summary>
		public System.Nullable<bool> msdyn_EnableDripScheduling
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_enabledripscheduling");
			}
			set
			{
				this.SetAttributeValue("msdyn_enabledripscheduling", value);
				this.OnPropertyChanged("msdyn_EnableDripScheduling");
			}
		}
		
		/// <summary>
		/// Shows the default ending location type when booking daily schedules for this resource.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.OptionSetValue msdyn_EndLocation
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.OptionSetValue>("msdyn_endlocation");
			}
			set
			{
				this.SetAttributeValue("msdyn_endlocation", value);
				this.OnPropertyChanged("msdyn_EndLocation");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.OptionSetValue msdyn_GenericType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.OptionSetValue>("msdyn_generictype");
			}
			set
			{
				this.SetAttributeValue("msdyn_generictype", value);
				this.OnPropertyChanged("msdyn_GenericType");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference msdyn_glympseagent
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("msdyn_glympseagent");
			}
			set
			{
				this.SetAttributeValue("msdyn_glympseagent", value);
				this.OnPropertyChanged("msdyn_glympseagent");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.Money msdyn_HourlyRate
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.Money>("msdyn_hourlyrate");
			}
			set
			{
				this.SetAttributeValue("msdyn_hourlyrate", value);
				this.OnPropertyChanged("msdyn_HourlyRate");
			}
		}
		
		/// <summary>
		/// Value of the Hourly Rate in base currency.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.Money msdyn_hourlyrate_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.Money>("msdyn_hourlyrate_base");
			}
		}
		
		/// <summary>
		/// Is Default
		/// </summary>
		public System.Nullable<bool> msdyn_isgenericresourceprojectscoped
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_isgenericresourceprojectscoped");
			}
			set
			{
				this.SetAttributeValue("msdyn_isgenericresourceprojectscoped", value);
				this.OnPropertyChanged("msdyn_isgenericresourceprojectscoped");
			}
		}
		
		/// <summary>
		/// Field to indicate if the bookable resource is glympse enabled.
		/// </summary>
		public System.Nullable<bool> msdyn_isglympseenabled
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_isglympseenabled");
			}
			set
			{
				this.SetAttributeValue("msdyn_isglympseenabled", value);
				this.OnPropertyChanged("msdyn_isglympseenabled");
			}
		}
		
		/// <summary>
		/// Organizational Unit that resource belong to
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference msdyn_organizationalunit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("msdyn_organizationalunit");
			}
			set
			{
				this.SetAttributeValue("msdyn_organizationalunit", value);
				this.OnPropertyChanged("msdyn_organizationalunit");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		public string msdyn_PrimaryEMail
		{
			get
			{
				return this.GetAttributeValue<string>("msdyn_primaryemail");
			}
			set
			{
				this.SetAttributeValue("msdyn_primaryemail", value);
				this.OnPropertyChanged("msdyn_PrimaryEMail");
			}
		}
		
		/// <summary>
		/// Shows the default starting location type when booking daily schedules for this resource.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.OptionSetValue msdyn_StartLocation
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.OptionSetValue>("msdyn_startlocation");
			}
			set
			{
				this.SetAttributeValue("msdyn_startlocation", value);
				this.OnPropertyChanged("msdyn_StartLocation");
			}
		}
		
		/// <summary>
		/// Shows the target utilization for the resource.
		/// </summary>
		public System.Nullable<int> msdyn_targetutilization
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("msdyn_targetutilization");
			}
			set
			{
				this.SetAttributeValue("msdyn_targetutilization", value);
				this.OnPropertyChanged("msdyn_targetutilization");
			}
		}
		
		/// <summary>
		/// Specifies if approval required for Time Off Requests.
		/// </summary>
		public System.Nullable<bool> msdyn_TimeOffApprovalRequired
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_timeoffapprovalrequired");
			}
			set
			{
				this.SetAttributeValue("msdyn_timeoffapprovalrequired", value);
				this.OnPropertyChanged("msdyn_TimeOffApprovalRequired");
			}
		}
		
		/// <summary>
		/// Default Warehouse for this resource.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference msdyn_Warehouse
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("msdyn_warehouse");
			}
			set
			{
				this.SetAttributeValue("msdyn_warehouse", value);
				this.OnPropertyChanged("msdyn_Warehouse");
			}
		}
		
		/// <summary>
		/// Type the name of the resource.
		/// </summary>
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user or team who owns the record.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("ownerid");
			}
			set
			{
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Shows the ID of the process.
		/// </summary>
		public System.Nullable<System.Guid> ProcessId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			set
			{
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Select whether the resource is a user, equipment, contact, account, generic resource or a group of resources.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.OptionSetValue ResourceType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.OptionSetValue>("resourcetype");
			}
			set
			{
				this.SetAttributeValue("resourcetype", value);
				this.OnPropertyChanged("ResourceType");
			}
		}
		
		/// <summary>
		/// Shows the ID of the stage.
		/// </summary>
		public System.Nullable<System.Guid> StageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			set
			{
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
		
		/// <summary>
		/// Status of the Bookable Resource
		/// </summary>
		public System.Nullable<Common.Model.BookableResourceState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.Samples.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Common.Model.BookableResourceState)(System.Enum.ToObject(typeof(Common.Model.BookableResourceState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			set
			{
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.Samples.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Bookable Resource
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.OptionSetValue StatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.OptionSetValue>("statuscode");
			}
			set
			{
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// Specifies the timezone for the resource's working hours.
		/// </summary>
		public System.Nullable<int> TimeZone
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezone");
			}
			set
			{
				this.SetAttributeValue("timezone", value);
				this.OnPropertyChanged("TimeZone");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the BookableResource with respect to the base currency.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		public string TraversedPath
		{
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			set
			{
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
		
		/// <summary>
		/// Select the user who represents this resource.
		/// </summary>
		public Microsoft.Xrm.Sdk.Samples.EntityReference UserId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Samples.EntityReference>("userid");
			}
			set
			{
				this.SetAttributeValue("userid", value);
				this.OnPropertyChanged("UserId");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N bookableresource_bookableresourcebooking_Resource
		/// </summary>
		public System.Collections.Generic.IEnumerable<Common.Model.BookableResourceBooking> bookableresource_bookableresourcebooking_Resource
		{
			get
			{
				return this.GetRelatedEntities<Common.Model.BookableResourceBooking>("bookableresource_bookableresourcebooking_Resource", null);
			}
			set
			{
				this.SetRelatedEntities<Common.Model.BookableResourceBooking>("bookableresource_bookableresourcebooking_Resource", null, value);
				this.OnPropertyChanged("bookableresource_bookableresourcebooking_Resource");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bookableresource_bookableresourcebooking_ResourceGroup
		/// </summary>
		public System.Collections.Generic.IEnumerable<Common.Model.BookableResourceBooking> msdyn_bookableresource_bookableresourcebooking_ResourceGroup
		{
			get
			{
				return this.GetRelatedEntities<Common.Model.BookableResourceBooking>("msdyn_bookableresource_bookableresourcebooking_ResourceGroup", null);
			}
			set
			{
				this.SetRelatedEntities<Common.Model.BookableResourceBooking>("msdyn_bookableresource_bookableresourcebooking_ResourceGroup", null, value);
				this.OnPropertyChanged("msdyn_bookableresource_bookableresourcebooking_ResourceGroup");
			}
		}
	}
}
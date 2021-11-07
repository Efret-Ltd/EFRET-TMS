﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace EFRET_TMS.axs
{

    [Persistent(@"Movement_xpoView")]
    public partial class Movement : XPLiteObject
    {
        int fidMovement;
        [Key(true)]
        [Persistent(@"XpoIdentityColumn")]
        public int idMovement
        {
            get { return fidMovement; }
            set { SetPropertyValue<int>("idMovement", ref fidMovement, value); }
        }
        NewCo fCO;
        [Persistent(@"IdCO")]
        [Association(@"MovementReferencesNewCO")]
        public NewCo CO
        {
            get { return fCO; }
            set { SetPropertyValue<NewCo>("CO", ref fCO, value); }
        }
        DateTime fContractualdate;
        public DateTime Contractualdate
        {
            get { return fContractualdate; }
            set { SetPropertyValue<DateTime>("Contractualdate", ref fContractualdate, value); }
        }
        DateTime fContractualTime;
        public DateTime ContractualTime
        {
            get { return fContractualTime; }
            set { SetPropertyValue<DateTime>("ContractualTime", ref fContractualTime, value); }
        }
        DateTime fEffectiveDate;
        public DateTime EffectiveDate
        {
            get { return fEffectiveDate; }
            set { SetPropertyValue<DateTime>("EffectiveDate", ref fEffectiveDate, value); }
        }
        DateTime fEffectiveTime;
        public DateTime EffectiveTime
        {
            get { return fEffectiveTime; }
            set { SetPropertyValue<DateTime>("EffectiveTime", ref fEffectiveTime, value); }
        }
        DateTime fCompletedDate;
        public DateTime CompletedDate
        {
            get { return fCompletedDate; }
            set { SetPropertyValue<DateTime>("CompletedDate", ref fCompletedDate, value); }
        }
        DateTime fCompletedTime;
        public DateTime CompletedTime
        {
            get { return fCompletedTime; }
            set { SetPropertyValue<DateTime>("CompletedTime", ref fCompletedTime, value); }
        }
        string fOperation;
        [Size(255)]
        public string Operation
        {
            get { return fOperation; }
            set { SetPropertyValue<string>("Operation", ref fOperation, value); }
        }
        string fcompanyCode;
        [Size(6)]
        public string companyCode
        {
            get { return fcompanyCode; }
            set { SetPropertyValue<string>("companyCode", ref fcompanyCode, value); }
        }
        float fKM;
        public float KM
        {
            get { return fKM; }
            set { SetPropertyValue<float>("KM", ref fKM, value); }
        }
        float fCost;
        public float Cost
        {
            get { return fCost; }
            set { SetPropertyValue<float>("Cost", ref fCost, value); }
        }
        string fCurrency;
        [Size(255)]
        public string Currency
        {
            get { return fCurrency; }
            set { SetPropertyValue<string>("Currency", ref fCurrency, value); }
        }
        string fCostVATCode;
        [Size(3)]
        public string CostVATCode
        {
            get { return fCostVATCode; }
            set { SetPropertyValue<string>("CostVATCode", ref fCostVATCode, value); }
        }
        DateTime fDateCreation;
        [ColumnDbDefaultValue("(getdate())")]
        public DateTime DateCreation
        {
            get { return fDateCreation; }
            set { SetPropertyValue<DateTime>("DateCreation", ref fDateCreation, value); }
        }
        string fUserCreation;
        [Size(50)]
        public string UserCreation
        {
            get { return fUserCreation; }
            set { SetPropertyValue<string>("UserCreation", ref fUserCreation, value); }
        }
        string fCostProvider;
        [Size(6)]
        public string CostProvider
        {
            get { return fCostProvider; }
            set { SetPropertyValue<string>("CostProvider", ref fCostProvider, value); }
        }
        string fCostProviderFerry;
        [Size(6)]
        public string CostProviderFerry
        {
            get { return fCostProviderFerry; }
            set { SetPropertyValue<string>("CostProviderFerry", ref fCostProviderFerry, value); }
        }
        bool fDone;
        [ColumnDbDefaultValue("((0))")]
        public bool Done
        {
            get { return fDone; }
            set { SetPropertyValue<bool>("Done", ref fDone, value); }
        }
        string fMvtSpecialInstruction;
        [Size(200)]
        public string MvtSpecialInstruction
        {
            get { return fMvtSpecialInstruction; }
            set { SetPropertyValue<string>("MvtSpecialInstruction", ref fMvtSpecialInstruction, value); }
        }
        bool fMvtBookingNeeded;
        [ColumnDbDefaultValue("((0))")]
        public bool MvtBookingNeeded
        {
            get { return fMvtBookingNeeded; }
            set { SetPropertyValue<bool>("MvtBookingNeeded", ref fMvtBookingNeeded, value); }
        }
        string fMvtReference;
        [Size(50)]
        public string MvtReference
        {
            get { return fMvtReference; }
            set { SetPropertyValue<string>("MvtReference", ref fMvtReference, value); }
        }
        string fMvtComment;
        [Size(255)]
        public string MvtComment
        {
            get { return fMvtComment; }
            set { SetPropertyValue<string>("MvtComment", ref fMvtComment, value); }
        }
        string fVehicleDetails;
        [Size(50)]
        public string VehicleDetails
        {
            get { return fVehicleDetails; }
            set { SetPropertyValue<string>("VehicleDetails", ref fVehicleDetails, value); }
        }
        string fDriverName;
        [Size(30)]
        public string DriverName
        {
            get { return fDriverName; }
            set { SetPropertyValue<string>("DriverName", ref fDriverName, value); }
        }
        string fDriverMobilPhone;
        [Size(15)]
        public string DriverMobilPhone
        {
            get { return fDriverMobilPhone; }
            set { SetPropertyValue<string>("DriverMobilPhone", ref fDriverMobilPhone, value); }
        }
        short fNumberOfDriver;
        public short NumberOfDriver
        {
            get { return fNumberOfDriver; }
            set { SetPropertyValue<short>("NumberOfDriver", ref fNumberOfDriver, value); }
        }
        string fTractorNumber;
        [Size(30)]
        public string TractorNumber
        {
            get { return fTractorNumber; }
            set { SetPropertyValue<string>("TractorNumber", ref fTractorNumber, value); }
        }
        string fMvtcontact;
        [Size(50)]
        public string Mvtcontact
        {
            get { return fMvtcontact; }
            set { SetPropertyValue<string>("Mvtcontact", ref fMvtcontact, value); }
        }
        string fMvtEmail;
        [Size(200)]
        public string MvtEmail
        {
            get { return fMvtEmail; }
            set { SetPropertyValue<string>("MvtEmail", ref fMvtEmail, value); }
        }
        string fMvtTelephone;
        [Size(25)]
        public string MvtTelephone
        {
            get { return fMvtTelephone; }
            set { SetPropertyValue<string>("MvtTelephone", ref fMvtTelephone, value); }
        }
        string fMvtMobile;
        [Size(25)]
        public string MvtMobile
        {
            get { return fMvtMobile; }
            set { SetPropertyValue<string>("MvtMobile", ref fMvtMobile, value); }
        }
        string fCPSpecialInstruction;
        [Size(255)]
        public string CPSpecialInstruction
        {
            get { return fCPSpecialInstruction; }
            set { SetPropertyValue<string>("CPSpecialInstruction", ref fCPSpecialInstruction, value); }
        }
        short fCPPaymentTerms;
        [ColumnDbDefaultValue("((0))")]
        public short CPPaymentTerms
        {
            get { return fCPPaymentTerms; }
            set { SetPropertyValue<short>("CPPaymentTerms", ref fCPPaymentTerms, value); }
        }
        bool fCPEOM;
        [ColumnDbDefaultValue("((0))")]
        public bool CPEOM
        {
            get { return fCPEOM; }
            set { SetPropertyValue<bool>("CPEOM", ref fCPEOM, value); }
        }
        string fCodeRoute;
        [Size(6)]
        public string CodeRoute
        {
            get { return fCodeRoute; }
            set { SetPropertyValue<string>("CodeRoute", ref fCodeRoute, value); }
        }
        string fCodeMichelin1;
        [Size(10)]
        public string CodeMichelin1
        {
            get { return fCodeMichelin1; }
            set { SetPropertyValue<string>("CodeMichelin1", ref fCodeMichelin1, value); }
        }
        string fCodeMichelin2;
        [Size(10)]
        public string CodeMichelin2
        {
            get { return fCodeMichelin2; }
            set { SetPropertyValue<string>("CodeMichelin2", ref fCodeMichelin2, value); }
        }
        bool fCarrierInfo;
        [ColumnDbDefaultValue("((0))")]
        public bool CarrierInfo
        {
            get { return fCarrierInfo; }
            set { SetPropertyValue<bool>("CarrierInfo", ref fCarrierInfo, value); }
        }
        decimal fCancellation;
        [ColumnDbDefaultValue("((0))")]
        public decimal Cancellation
        {
            get { return fCancellation; }
            set { SetPropertyValue<decimal>("Cancellation", ref fCancellation, value); }
        }
        decimal fHotelPark;
        [ColumnDbDefaultValue("((0))")]
        public decimal HotelPark
        {
            get { return fHotelPark; }
            set { SetPropertyValue<decimal>("HotelPark", ref fHotelPark, value); }
        }
        decimal fRedirection;
        [ColumnDbDefaultValue("((0))")]
        public decimal Redirection
        {
            get { return fRedirection; }
            set { SetPropertyValue<decimal>("Redirection", ref fRedirection, value); }
        }
        decimal fToll;
        [ColumnDbDefaultValue("((0))")]
        public decimal Toll
        {
            get { return fToll; }
            set { SetPropertyValue<decimal>("Toll", ref fToll, value); }
        }
        decimal fDemurageLoading;
        [ColumnDbDefaultValue("((0))")]
        public decimal DemurageLoading
        {
            get { return fDemurageLoading; }
            set { SetPropertyValue<decimal>("DemurageLoading", ref fDemurageLoading, value); }
        }
        decimal fDemurageDelivery;
        [ColumnDbDefaultValue("((0))")]
        public decimal DemurageDelivery
        {
            get { return fDemurageDelivery; }
            set { SetPropertyValue<decimal>("DemurageDelivery", ref fDemurageDelivery, value); }
        }
        decimal fBasicCost;
        [ColumnDbDefaultValue("((0))")]
        public decimal BasicCost
        {
            get { return fBasicCost; }
            set { SetPropertyValue<decimal>("BasicCost", ref fBasicCost, value); }
        }
        decimal fCustomClearence;
        [ColumnDbDefaultValue("((0))")]
        public decimal CustomClearence
        {
            get { return fCustomClearence; }
            set { SetPropertyValue<decimal>("CustomClearence", ref fCustomClearence, value); }
        }
        string fP44StatusCode;
        [Size(255)]
        public string P44StatusCode
        {
            get { return fP44StatusCode; }
            set { SetPropertyValue<string>("P44StatusCode", ref fP44StatusCode, value); }
        }
        string fP44ArrivalCode;
        [Size(255)]
        public string P44ArrivalCode
        {
            get { return fP44ArrivalCode; }
            set { SetPropertyValue<string>("P44ArrivalCode", ref fP44ArrivalCode, value); }
        }
        DateTime fP44Arrival;
        public DateTime P44Arrival
        {
            get { return fP44Arrival; }
            set { SetPropertyValue<DateTime>("P44Arrival", ref fP44Arrival, value); }
        }
        DateTime fP44Departure;
        public DateTime P44Departure
        {
            get { return fP44Departure; }
            set { SetPropertyValue<DateTime>("P44Departure", ref fP44Departure, value); }
        }
        DateTime fP44ETAStart;
        public DateTime P44ETAStart
        {
            get { return fP44ETAStart; }
            set { SetPropertyValue<DateTime>("P44ETAStart", ref fP44ETAStart, value); }
        }
        DateTime fP44ETAEnd;
        public DateTime P44ETAEnd
        {
            get { return fP44ETAEnd; }
            set { SetPropertyValue<DateTime>("P44ETAEnd", ref fP44ETAEnd, value); }
        }
        bool fP44Override;
        [ColumnDbDefaultValue("((0))")]
        public bool P44Override
        {
            get { return fP44Override; }
            set { SetPropertyValue<bool>("P44Override", ref fP44Override, value); }
        }
        DateTime fP44ETAUpdate;
        public DateTime P44ETAUpdate
        {
            get { return fP44ETAUpdate; }
            set { SetPropertyValue<DateTime>("P44ETAUpdate", ref fP44ETAUpdate, value); }
        }
    }

}
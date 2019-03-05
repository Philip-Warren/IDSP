using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDSP7_pw
{
    class ClassConstants
    {
        public const int TruckSiteID = 1;
        public const int wareHouseSiteID = 2;
        public const int CorpHq = 3;

        //type**
        //        Back Order
        //Correction
        //Damage
        //Gain
        //Loss
        //Rejected
        //Return
        //Sale
        //Store Order
        //Supplier Order

        public const string type_BackOrder = "Back Order";
        public const string type_SupplierOrder = "Supplier Order";
        public const string type_Gain = "Gain";


        //*************************************************************
        //status*******

        //    Assembled
        //Assembling

        //    Cancelled
        //    Complete

        //    Delivered
        //    In progress
        //    In Transit
        //    Pending Back Order

        //    Rejected
        //    Submitted
        public const string status_pendingBackOrder = "Pending Back Order";
        public const string status_assembling = "Assembling";
        public const string status_InProgress = "In progress";
        public const string status_Assembled = "Assembled";
        public const string status_Submitted = "Submitted";

        public const string status_Complete = "Complete";
        public const string status_Delivered = "Delivered";

        public const string SubbedSuppOrderINTO_WH = "SELECT * FROM txn  WHERE siteIDTo = 2 AND siteIDFrom = 2 AND txntype= 'Supplier Order' AND status = 'In progress' ";





    }
}

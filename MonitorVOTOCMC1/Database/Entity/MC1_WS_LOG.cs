//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonitorVOTOCMC1.Database.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class MC1_WS_LOG
    {
        public long nID { get; set; }
        public System.DateTime dLog { get; set; }
        public string cTable { get; set; }
        public string cBatch { get; set; }
        public string cTrackBatch { get; set; }
        public string cType { get; set; }
        public string cMessage { get; set; }
        public Nullable<int> nRows { get; set; }
    }
}
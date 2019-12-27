//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KazanTestAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assets
    {
        public long ID { get; set; }
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
        public long DepartmentLocationID { get; set; }
        public long EmployeeID { get; set; }
        public long AssetGroupID { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> WarrantyDate { get; set; }

        public Assets()
        {
        }

        public Assets(string assetSN, string assetName)
        {
            AssetSN = assetSN;
            AssetName = assetName;
        }
    }
}

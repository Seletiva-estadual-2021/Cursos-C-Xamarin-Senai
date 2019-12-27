using System;
using System.Collections.Generic;
using System.Text;

namespace KazanTest.model
{
    class Assets
    {
        public long ID { get; set; }
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
        public long DepartmentLocationID { get; set; }
        public long EmployeeID { get; set; }
        public long AssetGroupID { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> WarrantyDate { get; set; }


        public string DeptName { get; set; }
    }
}

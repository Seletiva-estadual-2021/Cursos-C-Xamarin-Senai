using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KazanTestAPI.Models
{
    public class AssetsResult
    {
        public string AssetSN { get; set; }
        public string AssetName { get; set; }
        public string DeptName { get; set; }

        public AssetsResult(string assetSN, string assetName, string deptName)
        {
            AssetSN = assetSN;
            AssetName = assetName;
            DeptName = deptName;
        }
    }
}
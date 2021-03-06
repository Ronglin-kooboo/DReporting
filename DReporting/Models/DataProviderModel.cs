﻿using DReporting.Core;

namespace DReporting.Models
{
    public class DataProviderModel
    {
        public string DataProviderID { get; set; }

        public string CategoryID { get; set; }

        public IDataProvider Entity { get; set; }
    }
}

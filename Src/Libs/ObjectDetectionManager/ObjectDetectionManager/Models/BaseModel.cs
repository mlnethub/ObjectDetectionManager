﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectDetectionManager.Models
{
    public class BaseModel
    {
        public string id { get; set; }
        public string OwnerId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public string PartitionId { get; set; }
    }
}

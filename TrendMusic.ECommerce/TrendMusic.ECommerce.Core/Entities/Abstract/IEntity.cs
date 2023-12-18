﻿namespace TrendMusic.ECommerce.Core.Entities.Abstract
{
    public interface IEntity
    {
        public int Id { get; set; } // PK
        public string ConcurrencyStamp { get; set; } // 
        public bool IsActive { get; set; } // Safe Delete 
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate{ get; set; }
    }
}

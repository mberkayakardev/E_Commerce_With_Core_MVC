using System;

namespace TrendMusic.ECommerce.Core.Entities.Abstract
{
    public interface IEntity
    {
        public int Id { get; set; }
        public string ConcurrencyStamp { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate{ get; set; }


    }
}

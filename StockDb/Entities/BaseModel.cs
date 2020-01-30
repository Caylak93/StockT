using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockDb
{
    public abstract class BaseModel
    {
        public DateTime? CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }

        [NotMapped]
        public long TimeStampValue
        {
            get { return TimeStamp.GetTimeStampValue(); }
        }
    }
}
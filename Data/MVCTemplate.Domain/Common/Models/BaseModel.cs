namespace MVCTemplate.Domain.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using MVCTemplate.Domain.Common.Interfaces;

    public abstract class BaseModel<TKey> : ITimeTrackable
    {
        [Key]
        public TKey Id { get; set; }

        public DateTime AddedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }
    }
}

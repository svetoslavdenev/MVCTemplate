namespace MVCTemplate.Domain.Identity
{
    using System;

    using Microsoft.AspNetCore.Identity;
    using MVCTemplate.Domain.Common.Interfaces;

    public class ApplicationRole : IdentityRole, IDeletable, ITimeTrackable
    {
        public ApplicationRole()
            : this(null)
        {
        }

        public ApplicationRole(string name)
            : base(name)
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public DateTime AddedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }
    }
}

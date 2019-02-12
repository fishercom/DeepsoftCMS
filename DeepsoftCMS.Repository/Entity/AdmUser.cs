using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeepsoftCMS.Repository.Entity
{
    public class AdmUser : Entity
    {
        public int AdmProfileId { get; set; }

        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string LastName { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Default { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public string AccountId { get; set; } //Identity integration

        public virtual AdmProfile AdmProfile { get; set; }
        public virtual ICollection<CmsArticle> Article { get; set; }
        public virtual ICollection<Post> Post { get; set; }

    }
}

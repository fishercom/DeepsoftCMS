using System;
using System.ComponentModel.DataAnnotations;

namespace DeepsoftCMS.Repository.Entity
{
    public class AdmMenu : Entity
    {
        public Nullable<int> MenuParentId { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Icon { get; set; }
        public int Position { get; set; }
        public bool Active { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual AdmMenu MenuParent { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace DeepsoftCMS.Repository.Entity
{
    public class CmsSchema : Entity
    {
        public Nullable<int> SchemaParentId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(50)]
        public string AdminView { get; set; }

        [StringLength(50)]
        public string FrontView { get; set; }

        public Nullable<int> Iterations { get; set; }
        public bool IsPage { get; set; }
        public short Position { get; set; }
        public bool Active { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual CmsSchema SchemaParent { get; set; }
    }
}

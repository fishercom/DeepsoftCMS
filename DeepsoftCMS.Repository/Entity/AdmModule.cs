using System;
using System.ComponentModel.DataAnnotations;

namespace DeepsoftCMS.Repository.Entity
{
    public class AdmModule : Entity
    {
        public int MenuId { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Controller { get; set; }
        [StringLength(255)]
        public string Params { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }
        public int Position { get; set; }
        public bool Active { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual AdmMenu AdmMenu { get; set; }

    }
}

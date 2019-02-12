using System;
using System.ComponentModel.DataAnnotations;

namespace DeepsoftCMS.Repository.Entity
{
    public class AdmProfile : Entity
    {
        [StringLength(255)]
        public string Name { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Sa { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}

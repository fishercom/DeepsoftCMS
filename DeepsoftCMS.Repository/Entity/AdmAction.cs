using System;
using System.ComponentModel.DataAnnotations;

namespace DeepsoftCMS.Repository.Entity
{
    public class AdmAction : Entity
    {
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Alias { get; set; }
        public bool Write_Log { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}

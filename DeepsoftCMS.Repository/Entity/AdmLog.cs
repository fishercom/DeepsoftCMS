using System;
using System.ComponentModel.DataAnnotations;

namespace DeepsoftCMS.Repository.Entity
{
    public class AdmLog : Entity
    {
        public int EventId { get; set; }
        public int UserId { get; set; }
        [StringLength(512)]
        public string Comment { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual AdmUser AdmUser { get; set; }
        public virtual AdmEvent AdmEvent { get; set; }

    }
}

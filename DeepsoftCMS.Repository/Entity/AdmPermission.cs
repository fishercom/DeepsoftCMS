using System;
using System.ComponentModel.DataAnnotations;

namespace DeepsoftCMS.Repository.Entity
{
    public class AdmPermission : Entity
    {
        public int ProfileId { get; set; }
        public int EventId { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual AdmProfile AdmProfile { get; set; }
        public virtual AdmEvent AdmEvent { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace DeepsoftCMS.Repository.Entity
{
    public class AdmEvent : Entity
    {
        public int ModuleId { get; set; }
        public int ActionId { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual AdmModule AdmModule { get; set; }
        public virtual AdmAction AdmAction { get; set; }

    }
}

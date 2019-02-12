using System;
using System.ComponentModel.DataAnnotations;

namespace DeepsoftCMS.Repository.Entity
{
    public class CmsLang : Entity
    {
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(10)]
        public string CodeISO { get; set; }

        public Nullable<bool> Active { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}

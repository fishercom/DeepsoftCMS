using System;
using System.Collections.Generic;

namespace DeepsoftCMS.Service.Dto
{
    public class CommentDto
    {
        public int PostId { get; set; }
        public string Message { get; set; }

        public DateTime RegisterDate { get; set; }
        public WebUserDto WebUser { get; set; }
    }
}

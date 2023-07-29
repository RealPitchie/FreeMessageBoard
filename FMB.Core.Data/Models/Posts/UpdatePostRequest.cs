using FMB.Core.Data.Models.BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace FMB.Core.Data.Models.Posts
{
    public class UpdatePostRequest : IEntity<long>
    {
        public string NewBody { get; set; }
        public string NewTitle { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Domain
{
    public abstract class BaseDomainModel
    {
        public DateTime DateCreated { get; set; }
    }
}

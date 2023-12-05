using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Domain
{
    public class Team: BaseDomainModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

    }
}

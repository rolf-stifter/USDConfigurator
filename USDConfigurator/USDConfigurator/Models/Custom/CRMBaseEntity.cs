using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDConfigurator.Models.Custom
{
    public abstract class CRMBaseEntity
    {
        public Guid Id { get; set; }
        public Statecode Status { get; set; }

    }
}

using System;
using USDConfigurator.Helpers.Enums;

namespace USDConfigurator.Models.Custom
{
    public abstract class CRMBaseEntity
    {
        public Guid Id { get; set; }
        public Statecode Status { get; set; }
    }
}
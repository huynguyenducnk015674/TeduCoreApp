using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeduCoreApp.Data.EF.Extensions;
using TeduCoreApp.Data.Entities;

namespace TeduCoreApp.Data.EF.Configurations
{
    public class BillConfiguration : DbEntityConfiguration<Bill>
    {
        public override void Configure(EntityTypeBuilder<Bill> entity)
        {
            
        }
    }
}

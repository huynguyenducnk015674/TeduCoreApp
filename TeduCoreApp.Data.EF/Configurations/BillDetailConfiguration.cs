using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeduCoreApp.Data.EF.Extensions;
using TeduCoreApp.Data.Entities;

namespace TeduCoreApp.Data.EF.Configurations
{
    public class BillDetailConfiguration : DbEntityConfiguration<BillDetail>
    {
        public override void Configure(EntityTypeBuilder<BillDetail> entity)
        {
           
        }
    }
}

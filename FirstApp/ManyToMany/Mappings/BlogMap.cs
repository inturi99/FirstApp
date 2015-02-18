using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany.Mappings
{
   public class BlogMap:EntityTypeConfiguration<Blog>
    {
        public BlogMap()
        {
            HasKey(p => p.BlogId);
            Property(p => p.BlogId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.BloggerName).IsRequired().HasMaxLength(50);
            Property(p => p.Title).IsRequired();
           
        }
    }
}

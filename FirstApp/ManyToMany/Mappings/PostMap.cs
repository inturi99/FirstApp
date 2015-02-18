using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany.Mappings
{
   public  class PostMap:EntityTypeConfiguration<Post>
   {
       public PostMap()
        {
            HasKey(p => p.PostId);
            Property(p => p.PostId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.DateCreated).IsRequired();
            Property(p => p.Title).IsRequired();
           Property(p => p.Content).IsRequired();
           HasRequired(l => l.Blogs).WithMany(l => l.Posts).HasForeignKey(l => l.BlogId);

        }
    }
}

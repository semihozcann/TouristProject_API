using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Core.Entities.Concrete;
using touristProject.DataAccess.Mapping;
using touristProject.Entities.Concrete;

namespace touristProject.DataAccess.Concrete.EntityFramework.Context
{
    public class TouristProjectContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-5R6CJJ3\SQLEXPRESS;Database=TouristProjectApıDb;Trusted_Connection=true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Nutrient> Nutrients { get; set; }
        public DbSet<NutrientComment> NutrientComments { get; set; }
        public DbSet<NutrientFavorite> NutrientFavorites { get; set; }
        public DbSet<NutrientImage> NutrientImages { get; set; }


        //db kurallarını burada db olusturken veriyoruz. 
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new OperationClaimMap());
            builder.ApplyConfiguration(new UserOperationClaimMap());


            builder.ApplyConfiguration(new CategoryMap());

            builder.ApplyConfiguration(new NutrientMap());
            builder.ApplyConfiguration(new NutrientCommentMap());
            builder.ApplyConfiguration(new NutrientFavoriteMap());
            builder.ApplyConfiguration(new NutrientImageMap());


        }

        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    //ChangeTracker mekanizması varlıkların durumlarını takip eden bir yapıdır. Bu sayede işlem yaparken varlıklar üzerinde ne işlem yapıldığını anlayabilir. Burada Bundan faydalanarak varlıklar üzerindeki değişime göre işlem esnasında yapılmasını istediğimiz eylemleri gereçekleştirebiliriz.
        //    var datas = ChangeTracker.Entries<BaseEntity>(); // varlığın yakalanması
        //    foreach (var data in datas)
        //    {
        //        _ = data.State switch
        //        {
        //            EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow, //ekleme işlemi ise işlem anındaki tarihi CreatedDate stununa ekle
        //            EntityState.Modified => data.Entity.ModifiedDate = DateTime.UtcNow, //Güncelleme işlemi ise işlem anındaki tarihi UpdatedDate stununa ekle

        //            //Bu kısıma işlem anında yapılmasını istediğiniz şeyleri ekleyebilirsiniz.
        //        };
        //    }
        //    return base.SaveChangesAsync(cancellationToken); //Değişiklikleri kaydet
        //}
    }
}

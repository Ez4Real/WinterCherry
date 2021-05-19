using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Hotel.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Hotel.API.EfDBContext
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<CheckIn> CheckIns { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<RoomImages> RoomImages { get; set; }
        public HotelDbContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuation = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var connectionString = configuation.Build().GetSection("connectionString").GetSection("DefaultConnection").Value;
            optionsBuilder.UseSqlServer(connectionString);
        }

        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //  modelBuilder.Ignore<Company>();                                                             //pruklad inoruvanya stvorenya tabluci
            //  modelBuilder.Entity<Product>().Ignore(b => b.Description);                                  //pruklad inoruvanya stvorenya stovpca v tabluci
            modelBuilder.Entity<Comments>().ToTable("Comments");                                              //puvyazka tabluci People do User
            modelBuilder.Entity<CheckIn>().ToTable("CheckIn");
            //  modelBuilder.Entity<User>().ToTable("People", schema: "userstore");                         //pruklad  perevuznachenya shemu do yakoi bude nalejutu tablucya
            //  modelBuilder.Entity<User>().Property(u=>u.Id).HasColumnName("user_id");                     //puklad perevuznacenya spivstavlenya stovpcya
            //  modelBuilder.Entity<User>().HasKey(u => u.Ident);                                           //pruklad vstanovlenya kluca
            //  modelBuilder.Entity<User>().HasKey(u => new { u.PassportSeria, u.PassportNumber});          //pruklad stvorenya kluca z dekilkox vlastuvostey
            //  modelBuilder.Entity<User>().HasKey(u => u.Id).HasName("UsersPrimaryKey");                   //pruklad nalashtuvanya IMYA obmejenya, uake zadayetsya dlya primary key
            //  modelBuilder.Entity<User>().HasAlternateKey(u => u.Passport);                               //pruklad stvorenya alternatuvnogo klyuca
            //  modelBuilder.Entity<User>().HasAlternateKey(u => new { u.Passport, u.PhoneNumber });        //pruklad stvorenya alternatuvnux klyuciv
            //  modelBuilder.Entity<User>().HasIndex(u => u.Passport);                                      //pruklad vstanovlenya indexsu
            //  modelBuilder.Entity<User>().HasIndex(u => u.Passport).IsUnique();                           //pruklad vstanovlenya indexsu yakuy maye bytu ynicalnum
            //  modelBuilder.Entity<User>().HasIndex(u => new { u.Passport, u.PhoneNumber });               //pruklad vstanovlenya indexsiv dlya dekilkoh vlastuvostey
            //  modelBuilder.Entity<User>().HasIndex(u => u.PhoneNumber).HasDatabaseName("PhoneIndex");     //pruklad vstanovlenya imya indexsa
            //  modelBuilder.Entity<User>().HasIndex(u => u.PhoneNumber).HasFilter("[PhoneNumber] IS NOT NULL");
        }
    }
}

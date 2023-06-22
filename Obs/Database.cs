using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Obs.Models;
using System;
using System.Collections.Generic;

namespace Obs
{
    public class DatabaseContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        /*
        Nesneyi veritaban� tablosuna d�n��t�rmek i�in
        1. <Foo> yerine s�n�f�n�n ad�n� girin 
        2. Genel isimlendirme kurallar�na g�re 
            s�n�f�n�z�n ismi Car ise property ismi Cars olmal�d�r.
        */
        public DbSet<User> Ogrenciler { get; set; }

        public DbSet<Akademisyen> Akademisyenler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Not> Notlar { get; set; }
        public DbSet<Yariyil> Yariyillar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*
             * bu yorum sat�r�n� a�may� a�t�ktan sonra MyDatabase yerine
             * kendi kullanaca��n�z database ismini yazmay� unutmay�n!
             */
            optionsBuilder.UseSqlServer("Server=.;Database=MyDatabaseTu;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }

        
        }
    }
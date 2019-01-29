using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace fatura
{
    class FaturaContext:DbContext
    {
        public FaturaContext():base("baglanti")
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<FaturaMaster> faturamaster { get; set; }
        public virtual DbSet<FaturaDetay> faturadetay { get; set; }
        public virtual DbSet<Musteri> musteriler { get; set; }
        public virtual DbSet<Urun> urunler { get; set; }
        public virtual DbSet<Birim> birimler { get; set; }
        public virtual DbSet<Ilce> ilceler { get; set; }
        public virtual DbSet<Il> iller { get; set; }
        
    }
    [Table("IL")]
    public class Il
    {
        public Il()
        {
            this.ilce = new HashSet<Ilce>();
              
        }
        [Key]
        public int IlId { get; set; }
        public string IlAdi { get; set; }
        public virtual ICollection<Ilce> ilce { get; set; }
    }
    [Table("ILce")]
    public class Ilce {
        public Ilce()
        {
            this.musteri = new HashSet<Musteri>();
        }
        
        [Key]
        public int IlceId { get; set; }
        public string IlceAdi { get; set; }
        public int IlId { get; set; }
        public virtual Il il{ get; set; }
        public virtual ICollection<Musteri> musteri { get; set; }
    }
    [Table("Urun")]
    public class Urun
    {
        public Urun()
        {
            this.faturaDetay = new HashSet<FaturaDetay>();
        }

        [Key]
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public string UrunKodu { get; set; }
        public int BirimId { get; set; }
        public decimal BirimFiyat { get; set; }
        public virtual Birim birim { get; set; }
        public virtual ICollection<FaturaDetay> faturaDetay { get; set; }
    }
    [Table("Birim")]
    public class Birim
    {
        public Birim()
        {
            this.urun = new HashSet<Urun>();
        }
        [Key]
        public int BirimId { get; set; }
        public string BirimAdi { get; set; }
        public virtual ICollection<Urun> urun {get;set;}

    }
    [Table("Musteri")]
    public class Musteri
    {
        public Musteri()
        {
            this.faturaMaster = new HashSet<FaturaMaster>();
        }
        [Key]
        public int MusteriId { get; set; }
        public string MusteriUnvani { get; set; }
        public int IlceId { get; set; }
        public string MusteriAdresi { get; set; }
        public virtual Ilce ilce { get; set; }
        public virtual ICollection<FaturaMaster> faturaMaster { get; set; }
    }
    [Table("FaturaMaster")]
    public class FaturaMaster
    {
        public FaturaMaster()
        {
            this.faturaDetay = new HashSet<FaturaDetay>();
            this.FaturaTarihi = DateTime.Now;
        }
        [Key]
        public int FaturaId { get; set; }
        public int MusteriId { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public int IrsaliyeNo { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public virtual Musteri musteri { get; set; }
        public virtual ICollection<FaturaDetay> faturaDetay { get; set; }


    }
    [Table("FaturaDetay")]
    public class FaturaDetay
    {
        public FaturaDetay()
        {
            this.Aciklama = "Vadesinden sonra odenen faturalara %5 ceza uygulanır.";
        }

        [Key][Column(Order =0)]
        public int FaturaId { get; set; }

        [Key][Column(Order=1)]
        public int UrunId { get; set; }
        
        public decimal Miktar { get; set; }
        public decimal ToplamFiyat { get; set; }
        public decimal Kdv { get; set; }
        public decimal KdvliFiyat { get; set; }
        public decimal FaturaToplami { get; set; }
        public string Aciklama { get; set; }
        public virtual FaturaMaster faturaMaster { get; set; }
        public virtual Urun urun{ get; set; }


    }
}



using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    class DbHelper
    {
        private static string _connectionString;
        public static void ReadSettings()
        {
            string yol = Path.Combine(Application.StartupPath, "connection.txt");
            _connectionString = File.ReadAllText(yol);
        }
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = _connectionString;
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu.\n{ex.Message}");
                return null;
            }
        }
        internal static void AddUye(Uye Uye)
        {
            var conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Uye (Ad, Soyad,KayitTar) values(@Ad, @Soyad,@KayitTar)";
            cmd.Parameters.AddWithValue("@Ad", Uye.Ad);
            cmd.Parameters.AddWithValue("@Soyad", Uye.Soyad);
            cmd.Parameters.AddWithValue("@KayitTar", Uye.KayitTar);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        internal static void AddKitap(Kitap kitap)
        {
            var Baglanti = GetConnection();
            SqlCommand KitapDurumuSorgu = new SqlCommand();
            KitapDurumuSorgu.Connection = Baglanti ;
            int alinmaDurumu = 0;
            using (SqlCommand checkCmd = new SqlCommand("SELECT AlinmaDurum FROM KitapHareket WHERE KitapId = @KitapId", Baglanti))
            {
                checkCmd.Parameters.AddWithValue("@KitapId", kitap.KitapId);
                alinmaDurumu = Convert.ToInt32(checkCmd.ExecuteScalar());
            }

            if (alinmaDurumu == 1)
            {
                Console.WriteLine("Kitap zaten alınmış.");
                // burada gerekli işlemleri yapabilirsiniz
            }
            else
            {
                KitapDurumuSorgu.ExecuteNonQuery();
                Console.WriteLine("Kitap eklendi.");
                var conn = GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Kitap (YayineviId, Ad, Yazar, KayitTar, AlinmaDurum) values (@YayineviId, @Ad, @Yazar, @KayitTar, @AlinmaDurum)";
                cmd.Parameters.AddWithValue("@YayineviId", kitap.YayineviId);
                cmd.Parameters.AddWithValue("@Ad", kitap.Ad);
                cmd.Parameters.AddWithValue("@Yazar", kitap.Yazar);
                cmd.Parameters.AddWithValue("@KayitTar", kitap.VerilisTar);
                cmd.Parameters.AddWithValue("@AlinmaDurum", kitap.AlinmaDurum);


                conn.Close();
            }

        }
        public static List<Yayinevi> GetYayineviList()
        {
            var list = new List<Yayinevi>();
            var conn = GetConnection();
            if (conn is null) return list;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select  YayineviId, Ad from Yayinevi order by Ad";
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var yayinevi = new Yayinevi
                {
                    YayineviId = Convert.ToInt32(dr["YayineviId"]),
                    Ad = dr["Ad"].ToString()
                };
                list.Add(yayinevi);
            }
            dr.Close();
            conn.Close();

            return list;
        }
        internal static void AddYayınevi(Yayinevi yayınevi)
        {
            var conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Yayinevi (Ad, Aciklama) values(@Ad, @Aciklama)";
            cmd.Parameters.AddWithValue("@Ad", yayınevi.Ad);
            cmd.Parameters.AddWithValue("@Aciklama", yayınevi.Aciklama);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static List<Uye> GetUyeList()
        {
            var list = new List<Uye>();
            var conn = GetConnection();
            if (conn is null) return list;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Ad,Soyad from Uye order by Ad";
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var uye = new Uye
                {
                    Ad=($"{dr["Ad"]} {dr["Soyad"]}".ToString()),
                };
                list.Add(uye);
            }
            dr.Close();
            conn.Close();

            return list;
        }
        public static List<Kitap> GetKitapList()
        {
            var list = new List<Kitap>();
            var conn = GetConnection();
            if (conn is null) return list;
        
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select KitapId, Ad from Kitap order by Ad";
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var kitap = new Kitap
                {
                    KitapId = Convert.ToInt32(dr["KitapId"]),
                    Ad = dr["Ad"].ToString()
                };
                list.Add(kitap);
            }
            dr.Close();
            conn.Close();
            
            return list;

        }
        internal static void AddKitapHareket(KitapHareket kitapHareket)
        {
            var conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into KitapHareket (UyeId,KitapId,VerilisTar,Aciklama,AlinmaDurum) values(@UyeId,@KitapId, @VerilisTar,@Aciklama,@AlinmaDurum)";
            cmd.Parameters.AddWithValue("@UyeId", kitapHareket.UyeId);
            cmd.Parameters.AddWithValue("@KitapId", kitapHareket.KitapId);
            cmd.Parameters.AddWithValue("@VerilisTar", kitapHareket.VerilisTar);
            cmd.Parameters.AddWithValue("@Aciklama", kitapHareket.Aciklama);
            cmd.Parameters.AddWithValue("AlinmaDurum", kitapHareket.AlinmaDurum);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static List<Kitap> GetKitaplarList()
        {
            var list = new List<Kitap>();
            var conn = GetConnection();
            if (conn is null) return list;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select KitapId,YayineviId,Ad,Yazar,KayitTar from Kitap order by KitapId";
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var kitap = new Kitap
                {
                    KitapId = Convert.ToInt32(dr["KitapId"]),
                    YayineviId = Convert.ToInt32(dr["YayineviId"]),
                    Ad = dr["Ad"].ToString(),
                    Yazar = dr["Yazar"].ToString(),
                    VerilisTar = Convert.ToDateTime(dr["VerilisTar"]),
                };
                list.Add(kitap);
            }
            dr.Close();
            conn.Close();

            return list;

        }
    }


}

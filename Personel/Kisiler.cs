using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel
{
    public class Kisiler
    {


        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=PersonelVeriTabani;integrated security=true");
        public List<Kisi> GetAll()
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Tbl_Personel", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Kisi> tbl_Personel = new List<Kisi>();
            while (reader.Read())
            {
                Kisi kisi = new Kisi
                {
                    Perid = Convert.ToInt32(reader["Perid"]),
                    PerAd = reader["PerAd"].ToString(),
                    PerSoyad = reader["PerSoyad"].ToString(),
                    PerSehir = reader["PerSehir"].ToString(),
                    PerMaas = Convert.ToInt32(reader["PerMaas"]),
                    PerDurum = reader["PerDurum"].ToString(),
                    PerMeslek = reader["PerMeslek"].ToString()

                };
                tbl_Personel.Add(kisi);
            }

            reader.Close();
            _connection.Close();
            return tbl_Personel;



        }
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

        }
        public void Add (Kisi kisi)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand
            ("Insert into Tbl_Personel values(@PerAd,@PerSoyad,@PerSehir,@PerMaas,@PerDurum,@PerMeslek) ", _connection);
            command.Parameters.AddWithValue("@PerAd", kisi.PerAd);
            command.Parameters.AddWithValue("@PerSoyad", kisi.PerSoyad);
            command.Parameters.AddWithValue("@PerSehir", kisi.PerSehir);
            command.Parameters.AddWithValue("@PerMaas", kisi.PerMaas);
            command.Parameters.AddWithValue("@PerDurum", kisi.PerDurum);
            command.Parameters.AddWithValue("@PerMeslek", kisi.PerMeslek);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Update(Kisi kisi)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand
            ("Update Tbl_Personel set PerAd=@Perad,PerSoyad=@PerSoyad,PerSehir=@PerSehir,PerMaas=@PerMaas,PerDurum=@PerDurum,PerMeslek=@PerMeslek where Perid=@PerId", _connection);
            command.Parameters.AddWithValue("@PerAd",kisi.PerAd);
            command.Parameters.AddWithValue("@PerSoyad",kisi.PerSoyad);
            command.Parameters.AddWithValue("@PerSehir",kisi.PerSehir);
            command.Parameters.AddWithValue("@PerMaas", kisi.PerMaas);
            command.Parameters.AddWithValue("@PerDurum", kisi.PerDurum);
            command.Parameters.AddWithValue("@PerMeslek", kisi.PerMeslek);
            command.Parameters.AddWithValue("@PerId",kisi.Perid);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from Tbl_Personel where Perid=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Бипит_5
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        string connectionString = @"workstation id=Bipit33333.mssql.somee.com;packet size=4096;user id=Gashuk_SQLLogin_1;pwd=7jv4k2zihb;data source=Bipit33333.mssql.somee.com;persist security info=False;initial catalog=Bipit33333";

        public DataSet GetData()
        {
            var query = "Select ID_RABOT as 'Код работы', Firma_oboryd as 'Фирма оборудования', Model_oboryd as 'Модель оборудования', Name_vid_rabot as 'Название вида работ'," +
               "format(Data_polychen, 'dd.MM.yyyy') as 'Дата получения', format(DATEADD(day, Plan_vid_rabot , Data_polychen), 'dd.MM.yyyy') as 'Дата по плану', format(Data_vipolnen, 'dd.MM.yyyy') as 'Дата выполнения'," +
               " CASE WHEN DATEDIFF(day, Data_vipolnen , DATEADD(day, Plan_vid_rabot , Data_polychen)) > 0  then  0 ELSE -DATEDIFF(day, Data_vipolnen , DATEADD(day, Plan_vid_rabot , Data_polychen)) END as 'Кол-во просроченных дней'," +
               " Cost_vid_rabot as 'Цена по плану'," +
               " CASE WHEN DATEDIFF(day, Data_vipolnen , DATEADD(day, Plan_vid_rabot , Data_polychen)) < 0  then  Cost_vid_rabot + (Cost_vid_rabot * (0.05 * DATEDIFF(day, Data_vipolnen , DATEADD(day, Plan_vid_rabot , Data_polychen)))) " +
               "ELSE Cost_vid_rabot END as 'Цена итогавая' from  Oboryd, Vid_rabot, Rabot  WHERE  Rabot.ID_oboryd = Oboryd.ID_OBORYD AND Rabot.ID_vid_rabot = Vid_rabot.ID_VID_RABOT";
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds, "Rabot");
                return ds;
            }
        }

        public DataSet FillOboryd()
        {
            string query = "SELECT * FROM Oboryd";
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds, "Oboryd");
                return ds;
            }
        }

        public DataSet FillVid_rabot()
        {
            string query = "SELECT * FROM Vid_rabot";
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds, "Vid_rabot");
                return ds;
            }
           
        }

        public void NewRec(string ID_OBORYD, string ID_VID_RABOT, string Data_polychen, string Data_vipolnen)
        {
            var query = $"INSERT INTO Rabot VALUES ({ID_OBORYD},{ID_VID_RABOT},'{Data_polychen}','{Data_vipolnen}')";
            var connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}

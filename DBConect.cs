using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Confeitaria
{
    class DBConect
    {
        private readonly string path = @"C:\Unifenas\4periodo\AtvIntegradoras\Confeitaria\Logs\logError.txt";

        private SqlConnection cn = new();
        private SqlCommand cmd = new();
        public SqlDataReader dr;
        public DataSet ds;
        SqlDataAdapter da;

        public string Campos { get; set; }

        public void Conect()
        {
            try
            {
                string s = "";
                s = @"SERVER=localhost;Database=Confeitaria;UID=sa;PWD=12345678";
                cn.ConnectionString = s;
                cn.Open();
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Erro ao estabelecer conexão com o Banco de dados - " + DateTime.Now.ToString() + " - " + ex.Message.ToString());
                }
                throw new Exception();
            }
        }

        public void Disconnect()
        {
            cn.Close();
        }

        public void Execute(string sql)//Executar SQL
        {
            try
            {
                Conect();
                cmd.Connection = cn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Erro ao executar comando SQL - " + DateTime.Now.ToString() + " - " + ex.Message.ToString());
                }
                cn.Close();
                throw new Exception();

            }
        }


        public void Get(string sql) //exibir apenas um resultado de consulta
        {
            try
            {
                Campos = "";
                Conect();
                cmd.Connection = cn;
                cmd.CommandText = sql;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        Campos += dr[i].ToString() + ";";
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Erro no comando SQL (GET)- " + DateTime.Now.ToString() + " - " + ex.Message.ToString());
                }
                cn.Close();
                throw new Exception();
            }
        }
        public DataSet List(string sql) //Listar varios resultados de consulta
        {
            try
            {
                Conect();
                da = new(sql, cn);
                ds = new();
                da.Fill(ds);
                cn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Erro no comando SQL (LIST)- " + DateTime.Now.ToString() + " - " + ex.Message.ToString());
                }
                cn.Close();
                throw new Exception();
            }
        }

        //public List<string> ListTel (string sql)
        //{

        //}

        public void Consultar(string sql)
        {
            Conect();
            cmd.CommandText = sql;
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            Disconnect();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace _10_11_ANDRES
{
    class Problema
    {
        SQLiteConnection conector;//declaro el conector
        SQLiteCommand comando;//declaro el comando
        string sql;
        public Problema()//ctor
        {
            conector = new SQLiteConnection("Data Source=Pareja.db");//crea el conector
            comando = new SQLiteCommand();//crea el comando

            sql = "";//inicializa sql

        }
        public Usuario Buscar(int UserID)//se le pasa la clase usuario y se le pase el userID
        {
            Usuario u = new Usuario();// crea el objeto
            conector.Open();// se conecta con la base de datos
            sql = $@" SELECT UserID,UserName,Edad FROM Usuarios
                    WHERE UserID={UserID}";//sql y paso USER ID con $ y {} para hacerlo variable
            comando.Connection = conector;//se conecta con el comando
            comando.CommandType = CommandType.Text;//tipo de comando
            comando.CommandText = sql;//le paso el comando sql
            SQLiteDataReader dr = comando.ExecuteReader();//ejecuta la instruccion
            if (dr.HasRows==true)//pregunta si dr tiene filas
            {
                dr.Read();
                u.UserID = Convert.ToInt32(dr["UserID"]);
                u.UserName = dr["UserName"].ToString();
                u.Edad = Convert.ToInt32(dr["Edad"]);
            }
            else
            {
                u.UserID = 0;
                u.UserName = "";
                u.Edad = 0;
            }
            

            conector.Close();//cierra la coneccion
            return u;

        }
    }
}

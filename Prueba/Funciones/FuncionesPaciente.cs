using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Prueba.Funciones
{
    public class FuncionesPaciente
    {
        public static bool RegistrarPaciente(Paciente paciente)
        {
            using (SqlConnection conect = new SqlConnection(BDConexion.conexionbd)) // Establecer conexion a la BD
            {
                SqlCommand res = new SqlCommand("sp_registrar", conect); // Consultar Store Procedure en BD
                res.CommandType = System.Data.CommandType.StoredProcedure; // Trae el SP de la BD
                res.Parameters.AddWithValue("@documento", paciente.Documento); //Datos envios al SP
                res.Parameters.AddWithValue("@nombres", paciente.Nombres); //Datos envios al SP
                res.Parameters.AddWithValue("@direccion", paciente.Direccion); //Datos envios al SP

                try
                {
                    conect.Open(); //Valida si la conexion a la BD esta activa
                    res.ExecuteNonQuery(); //Ejecuta una instruccion de transact SQL 
                    return true; // Si todas las instrucciones anteriores fueron cumplidas retorna true
                }
                catch (Exception ex)
                {
                    return false; // Si todas las instrucciones anteriores no fueron cumplidas retorna false                 
                }
            }
        }
        public static bool ModificarPaciente(Paciente paciente)
        {
            using (SqlConnection conect = new SqlConnection(BDConexion.conexionbd)) // Establecer conexion a la BD
            {
                SqlCommand res = new SqlCommand("sp_modificar", conect); // Consultar Store Procedure en BD
                res.CommandType = System.Data.CommandType.StoredProcedure; // Trae el SP de la BD
                res.Parameters.AddWithValue("@idPaciente", paciente.idPaciente); //Datos envios al SP
                res.Parameters.AddWithValue("@documento", paciente.Documento); //Datos envios al SP
                res.Parameters.AddWithValue("@nombres", paciente.Nombres); //Datos envios al SP
                res.Parameters.AddWithValue("@direccion", paciente.Direccion); //Datos envios al SP.

                try
                {
                    conect.Open(); //Valida si la conexion a la BD esta activa
                    res.ExecuteNonQuery(); //Ejecuta una instruccion de transact SQL 
                    return true; // Si todas las instrucciones anteriores fueron cumplidas retorna true
                }
                catch (Exception ex)
                {
                    return false; // Si todas las instrucciones anteriores no fueron cumplidas retorna false                 
                }
            }
        }
        public static bool EliminarPaciente(int id)
        {
            using (SqlConnection conect = new SqlConnection(BDConexion.conexionbd)) // Establecer conexion a la BD
            {
                SqlCommand res = new SqlCommand("sp_eliminar", conect); // Consultar Store Procedure en BD
                res.CommandType = System.Data.CommandType.StoredProcedure; // Trae el SP de la BD
                res.Parameters.AddWithValue("@idPaciente", id); //Datos envios al SP

                try
                {
                    conect.Open(); //Valida si la conexion a la BD esta activa
                    res.ExecuteNonQuery(); //Ejecuta una instruccion de transact SQL 
                    return true; // Si todas las instrucciones anteriores fueron cumplidas retorna true
                }
                catch (Exception ex)
                {
                    return false; // Si todas las instrucciones anteriores no fueron cumplidas retorna false                 
                }
            }
        }
    }
}
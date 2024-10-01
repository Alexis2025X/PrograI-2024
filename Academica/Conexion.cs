﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Esta libreria nos servira para conectarnos a la BD.
using System.Data.SqlClient; //Libreria necesaria para conectarnos a SQL Server.


namespace academica {
    internal class Conexion {
        SqlConnection miConexion = new SqlConnection();//Conectarme a la BD.
        SqlCommand misComandos = new SqlCommand();//ejecutar SQL en la BD.
        SqlDataAdapter miAdaptador = new SqlDataAdapter();//Intermediario entre mi BD y la aplicacion.
        DataSet ds = new DataSet();//es la representacion grafica de la BD en memoria RAM.

        //metodo Conexión
        public Conexion() {
            //Cadena de conexión de la base de datos nos permite jalar los datos de la BD al programa y viceversa
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            //Asigna a mi conexión la cadenaConexión
            miConexion.ConnectionString = cadenaConexion;
            //Nos permite conectarnos a la base de datos
            miConexion.Open();
        }
        public DataSet obtenerDatos() {
            ds.Clear();
            //misComandos nos permite ejecutar los codigos, miConexion conecta las ordenes con la base de datos
            misComandos.Connection = miConexion;

            miAdaptador.SelectCommand = misComandos;
            misComandos.CommandText = "SELECT * FROM alumnos";
            miAdaptador.Fill(ds, "alumnos");
            //para los datos materias
            misComandos.CommandText = "SELECT * FROM materias";
            miAdaptador.Fill(ds, "materias");
            //para los datos docente
            misComandos.CommandText = "SELECT * FROM docentes";
            miAdaptador.Fill(ds, "docentes");
            
            return ds;
        }
        public String administrarAlumnos(String[] datos) {
            String sql = "";
            if (datos[0] == "nuevo") {
                sql = "INSERT INTO alumnos(codigo, nombre, direccion, telefono, dui) VALUES('" + 
                    datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "')";
            }else if (datos[0] == "modificar") {
                sql = "UPDATE alumnos SET codigo='" + datos[2] + "', nombre='" + datos[3] + "', direccion='" + datos[4] + "', telefono='" + 
                    datos[5] + "', dui='" + datos[6] + "' WHERE idAlumno=" + datos[1];
            } else if (datos[0] == "eliminar") {
                sql = "DELETE FROM alumnos WHERE idAlumno=" + datos[1];
            }
            return ejecutarSQL(sql);
        }

        //Para insertar, actualizar y eliminar materias
        public String administrarMaterias(String[] datos)
        {
            String sql = "";
            if (datos[0] == "nuevo"){
                sql = "INSERT INTO materias(codigo, nombre, uv) VALUES('" +
                    datos[2] + "','" + datos[3] + "','" + datos[4] + "')";
            }else if (datos[0] == "modificar"){
                sql = "UPDATE materias SET codigo='" + datos[2] + "', nombre='" + datos[3] + "', uv='" + datos[4] +
                    "' WHERE idMateria=" + datos[1];
            }else if (datos[0] == "eliminar"){
                sql = "DELETE FROM materias WHERE idMateria=" + datos[1];
            }
            return ejecutarSQL(sql);
        }

        //Para insertar, actualizar y eliminar docentes
        //Este codigo esta bien
        public String administrarDocentes(String[] datos)
        {
            String sql = "";
            if (datos[0] == "nuevo")
            {
                sql = "INSERT INTO docentes(codigo, nombre, materia1, materia2, nivel_academico) VALUES('" +
                    datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "')";
            }
            else if (datos[0] == "modificar"){
                sql = "UPDATE docentes SET codigo='" + datos[2] + "', nombre='" + datos[3] + "', materia1='" + datos[4] + "', materia2='" + datos[5] + "', nivel_academico='" + datos[6] + "', especialidad='" + datos[7] +
                    "' WHERE idDocente=" + datos[1];
            }
            else if (datos[0] == "eliminar"){
                sql = "DELETE FROM docentes WHERE idDocente=" + datos[1];
            }
            return ejecutarSQL(sql);
        }

        //Codigo para conectar base de datos con el datagridview y así poder eliminar, insertar y más
        private String ejecutarSQL(String sql) {
            try {
                misComandos.Connection = miConexion;
                misComandos.CommandText = sql;
                return misComandos.ExecuteNonQuery().ToString();
            } catch (Exception ex) {
                return "Error: " + ex.Message;
            }
        }
    }
}

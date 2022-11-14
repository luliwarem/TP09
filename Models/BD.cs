namespace TP09_Szmedra_Waremkraut.Models;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

public class BD
{

    private static string _connectionString = @"Server=A-PHZ2-CIDI-009;DataBase=TheBookFair;Trusted_Connection=True";

    public static List<Genero> ObtenerGenero()
    {
        List<Genero> lista = new List<Genero>();
        string sql = "SELECT * FROM Genero";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            lista = db.Query<Genero>(sql).ToList();
        }
        return lista;
    }

    public static Genero ObtenerGenero(int id){
        
        Genero genero = null;
        string sql = "SELECT * FROM Genero WHERE IdGenero = @pId ";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            genero = db.QueryFirstOrDefault<Genero>(sql, new { pId = id });
        }
        return genero;
    }

    public static void AgregarGenero(string nombre){
        string sql = "INSERT INTO Genero VALUES (@pNombre)";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new {pNombre = nombre});
        }
    }  public static Genero EliminarGenero(int id){
        
        Genero genero = null;
        string sql = "DELETE * FROM Genero WHERE IdGenero = @pId ";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            genero = db.QueryFirstOrDefault<Genero>(sql, new { pId = id });
        }
        return genero;
    }

    public static Genero ModificarGenero(int id, string nombre){
        
        Genero genero = null;
        string sql = "UPDATE Genero SET nombre = @pNombre WHERE IdGenero = @pId ";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            genero = db.QueryFirstOrDefault<Genero>(sql, new { pId = id, pNombre = nombre });
        }
        return genero;
    }

}
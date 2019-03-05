using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


/// <summary>
/// Descrição resumida de Exercicio
/// </summary>
public class ExercicioDal
{

    private string strCon = Conexao.getConexao();

    private SqlConnection conexao;

    public List<Exercicio> Select()
    {

        List<Exercicio> exercicios = new List<Exercicio>();
        conexao = new SqlConnection(strCon);
        string sql = "Select * from Exercicio";
        SqlCommand cmd = new SqlCommand(sql, conexao);
       
        try
        {
            conexao.Open();

            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                Exercicio exercicio = new Exercicio();
                exercicio.idExercicio = Convert.ToInt32(reader[0].ToString());
                exercicio.nome = reader["nome"].ToString();
                exercicio.tipo = reader["tipo"].ToString();
                exercicio.repeticoes = reader["repeticoes"].ToString();
                exercicio.observacao = reader["observacoes"].ToString();

                exercicios.Add(exercicio);
            }


        }
        catch(SqlException ex)
        {
            Console.WriteLine("Deu Erro no Select do ExercicioDal" + ex.ToString());
        }
        finally
        {
            conexao.Close();

        }


        return exercicios;
    }


    public void Insert(Exercicio exercicio)
    {
        conexao = new SqlConnection(strCon);
        string sql = "Insert into Exercicio values(@tipo,@nome,@repeticoes, @observacoes)";
        SqlCommand cmd = new SqlCommand(sql, conexao);
        cmd.Parameters.AddWithValue("@tipo", exercicio.tipo);
        cmd.Parameters.AddWithValue("@nome", exercicio.nome);
        cmd.Parameters.AddWithValue("@repeticoes", exercicio.repeticoes);
        cmd.Parameters.AddWithValue("@observacoes", exercicio.observacao);

        try
        {
            conexao.Open();
            cmd.ExecuteNonQuery();


        }
        catch(SqlException ex)
        {

            Console.WriteLine("Deu erro no Insert do Exercicio " + ex.ToString());
        }
        finally
        {

            conexao.Close();
        }
    }

    public void Update(Exercicio exercicio)
    {
        conexao = new SqlConnection(strCon);
        string sql = "Update Exercicio set nome =@nome, tipo=@tipo, repeticoes=@repeticoes, observacoes=@observacoes" +
            "where idexercicio=@id; ";
        SqlCommand cmd = new SqlCommand(sql, conexao);
        cmd.Parameters.AddWithValue("@id", exercicio.idExercicio);
        cmd.Parameters.AddWithValue("@nome", exercicio.nome);
        cmd.Parameters.AddWithValue("@tipo", exercicio.tipo);
        cmd.Parameters.AddWithValue("@repeticoes", exercicio.repeticoes);
        cmd.Parameters.AddWithValue("@observacoes", exercicio.observacao);

        try
        {

            conexao.Open();
            cmd.ExecuteNonQuery();

        }
        catch (SqlException ex)
        {

            Console.WriteLine("Erro no Update do ExercicioDal " + ex.ToString());
        }
        finally
        {
            conexao.Close();
        }

    }

    public void Delete(int idExercicio)
    {
        conexao = new SqlConnection(strCon);
        string sql = "Delete from Exercicio where idexercicio=@id";
        SqlCommand cmd = new SqlCommand(sql, conexao);
        cmd.Parameters.AddWithValue("@id", idExercicio);

        try
        {

            conexao.Open();
            cmd.ExecuteNonQuery();
        }
        catch(SqlException ex)
        {
            Console.WriteLine("Erro no Delete do ExercicioDal " + ex.ToString());
        }
        finally
        {
            conexao.Close();
        }
    }
        
    
}
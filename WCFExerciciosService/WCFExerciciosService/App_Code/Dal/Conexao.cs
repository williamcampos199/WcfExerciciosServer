using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Conexao
/// </summary>
public class Conexao
{

public static string getConexao()
    {
        return @"Data Source=.\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True";
    }
}
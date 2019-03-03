using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descrição resumida de Exercicio
/// </summary>
/// 

[DataContract]
public class Exercicio
{
    [DataMember]
    public int idExercicio { get; set; }
    [DataMember]
    public string tipo { get; set; }
    [DataMember]
    public string nome { get; set; }
    [DataMember]
    public string repeticoes { get; set; }
    [DataMember]
    public string observacao { get; set; }

    public Exercicio()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }




}
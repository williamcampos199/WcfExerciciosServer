using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService" no arquivo de código e configuração ao mesmo tempo.
[ServiceContract]
public interface IService
{
    [OperationContract]
    List<Exercicio> SelectExercicios();
    [OperationContract]
    void InsertExercicios(Exercicio exercicio);
    [OperationContract]
    void UpdateExercicios(Exercicio exercicio);
    [OperationContract]
    void DeleteExercicios(int idExercicio);

   
}




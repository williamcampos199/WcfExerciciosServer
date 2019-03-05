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
    void Insert(Exercicio exercicio);
    void Update(Exercicio exercicio);
    void Delete(int idExercicio);

   
}




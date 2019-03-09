using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service" no arquivo de código, svc e configuração ao mesmo tempo.
public class Service : IService
{
    public void DeleteExercicios(int idExercicio)
    {
        ExercicioDal exercicioDal = new ExercicioDal();
        exercicioDal.Delete(idExercicio);
    }

    public void InsertExercicios(Exercicio exercicio)
    {
        ExercicioDal exercicioDal = new ExercicioDal();
        exercicioDal.Insert(exercicio);
    }

    public List<Exercicio> SelectExercicios()
    {
        ExercicioDal exercicioDal = new ExercicioDal();
        return exercicioDal.Select();
    }

    public void UpdateExercicios(Exercicio exercicio)
    {
        ExercicioDal exercicioDal = new ExercicioDal();
        exercicioDal.Update(exercicio);
    }
}

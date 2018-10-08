
using DadosEntityFramework;

namespace ModeloDados
{
    public class Dados
    {

        public bool Inserir(LaboratorioVO laboratorioVO)
        {

            DB_LaboratorioEntities context = new DB_LaboratorioEntities();
            context.tb_laboratorio.Add(Converte.ToLaboratorio(laboratorioVO));
            int retorno = context.SaveChanges();


            if (retorno == 1)
                return true;
            return false;

        }
}
}

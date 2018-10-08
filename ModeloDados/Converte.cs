using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDados;

using DadosEntityFramework;

namespace ModeloDados
{
    class Converte
    {

        public static tb_laboratorio ToLaboratorio(LaboratorioVO laboratorioVO)
        {

            return new tb_laboratorio()
            {

                id = laboratorioVO.id,
                nome = laboratorioVO.nome,
                qtdComputadores = laboratorioVO.qtdComputadores,
                qtdAlunos = laboratorioVO.qtdAlunos,
                projetor = laboratorioVO.projetor,
                software1 = laboratorioVO.software1,
                software2 = laboratorioVO.software2,
                software3 = laboratorioVO.software3,
                sistemaOperacional = laboratorioVO.sistemaOperacional

            };
        }

        public static LaboratorioVO ToLaboratorioVO(tb_laboratorio laboratorio)
        {

            return new LaboratorioVO()
            {

                id = laboratorio.id,
                nome = laboratorio.nome,
                qtdComputadores = laboratorio.qtdComputadores,
                qtdAlunos = laboratorio.qtdAlunos,
                projetor = laboratorio.projetor,
                software1 = laboratorio.software1,
                software2 = laboratorio.software2,
                software3 = laboratorio.software3,
                sistemaOperacional = laboratorio.sistemaOperacional
            };
        }

    }
}

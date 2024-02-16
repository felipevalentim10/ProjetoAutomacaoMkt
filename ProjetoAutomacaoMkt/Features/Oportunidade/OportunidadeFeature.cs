using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoAutomacaoMkt;
using ProjetoAutomacaoMkt.Steps.Oportunidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAutomacaoMkt.Features.Oportunidade
{
    [TestClass]
    public class OportunidadeFeature : Hooks
    {
        [TestMethod]
        [TestCategory("Caso de teste XXX")] //Número gerado através do Azure ou JIRA
        [TestCategory("User Story XXX")] //Número gerado através do Azure ou JIRA
        //[DynamicData(nameof(RetornaInformacoes), DynamicDataSourceType.Method)]  //Retorna informações do banco de dados caso precise

        public void CriarOportunidade()
        {
            Report.LogMessage("Dado que eu já esteja logado no ORG");
            Report.LogMessage("E deseje criar uma nova oportunidade");
            Report.LogMessage("Quando clicar no objeto 'Oportunidade' ");
            Report.LogMessage("E clico em 'Criar' ");
            Report.LogMessage("E no tipo de registro selecionar 'Cliente alvo' ");
            Report.LogMessage("E clico em 'Avançar' ");
            Report.LogMessage("E clico no campo 'Conta' ");
            Report.LogMessage("E digito o nome da conta");
            Report.LogMessage("E clico na conta digitada");
            Report.LogMessage("E clico no campo 'Endereço' ");
            Report.LogMessage("E digito o endereço");
            Report.LogMessage("E clique no endereço digitado");
            Report.LogMessage("E clico no campo 'Contato' ");
            Report.LogMessage("E seleciono o contato");
            Report.LogMessage("E clico no campo 'Nome da oportunidade' ");
            Report.LogMessage("E Digito o nome da oportunidade");
            Report.LogMessage("E clico no campo 'Data da conclusão' ");
            Report.LogMessage("E seleciono uma data");
            Report.LogMessage("E clico no campo 'Território' ");
            Report.LogMessage("E seleciono um território");
            Report.LogMessage("E clicar em 'Avancar' ");
            Report.LogMessage("Então um nova oportunidade seria criada");
            Report.LogMessage("E uma mensagem de sucesso na operação será exibida em tela");
            Report.LogMessage("");
            //Report.Logmessage = Gera um HTML demonstando ações em tela com prints 

            OportunidadesSteps.CriarOportunidade("felipe.franca@sottelli.com.qamkt", "05312500Ff@@");
        }
    }
}
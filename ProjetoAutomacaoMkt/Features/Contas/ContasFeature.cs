using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoAutomacaoMkt.Steps.Conta;


namespace ProjetoAutomacaoMkt.Features.Contas
{
    [TestClass]
    public class ContasFeature : Hooks
    {
        [TestMethod]
        [TestCategory("Caso de teste XXX")] //Número gerado através do JIRA
        [TestCategory("User Story XXX")] //Número gerado através do JIRA
        //[DynamicData(nameof(RetornaInformacoes), DynamicDataSourceType.Method)]  
        //Retorna informações do banco de dados caso precise

        public void CriarConta()
        {
            Report.LogMessage("Dado que eu já esteja logado no ORG");
            Report.LogMessage("E deseje criar uma nova conta");
            Report.LogMessage("E clicar em 'Criar' ");
            Report.LogMessage("Quando preencher todos os campos solicitados");
            Report.LogMessage("Então a nova conta será criada com sucesso");
            Report.LogMessage("E uma mensagem de sucesso será exibida em tela");
            Report.LogMessage("");
            //Report.Logmessage = Gera um HTML demonstando ações em tela com prints


            ContasSteps.CriarConta("felipe.franca@sottelli.com.qamkt", "05312500Ff@@");
        }
    }
}
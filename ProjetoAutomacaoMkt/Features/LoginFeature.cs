using ProjetoAutomacaoMkt.Steps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoAutomacaoMkt;

namespace ProjetoAutomacaoMkt.Features
{
    [TestClass]
    public class LoginFeature : Hooks
    {
        [MyTestMethod]
        [TestCategory("Caso de teste XXX")] //Número gerado através do JIRA
        [TestCategory("User Story XXX")] // Número gerado através do JIRA
        //[DynamicDta(nameof(RetornaInformacoes), DynamicDataSourceType.Method)] //Retorna informações do banco de dados caso a aplicação necessite
        public void ValidarLoginSucesso()
        {
            Report.LogMessage("Dado que eu acesse o site da Salesforce");
            Report.LogMessage("E digite um E-mail válido");
            Report.LogMessage("E uma senha válida");
            Report.LogMessage("Quando clicar em 'Faça login na Sandbox' ");
            Report.LogMessage("Então o sistema fará o login");
            Report.LogMessage("");
            //Report.LogMessage = Gera um HTML demostrando ações em tela com prints

            LoginSteps.ValidarLoginSucesso("**********", "*************");

        }
    }
}

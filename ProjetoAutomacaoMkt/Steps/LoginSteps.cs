using ProjetoAutomacaoMkt.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoAutomacaoMkt;
using System;


namespace ProjetoAutomacaoMkt.Steps
{
    public class LoginSteps : Hooks
    {
        public static void ValidarLoginSucesso(string Email, string Senha)
        {
            Driver.FindElement(LoginPage.DigiteEmail).SendKeys(Email);
            Driver.FindElement(LoginPage.DigiteSenha).SendKeys(Senha);
            Driver.FindElement(LoginPage.CliqueEmFaçaLoginNaSendbox).Click();
            Thread.Sleep(1000);
            //Asert abaixo = Validar acesso a página de deshboard
            Assert.IsTrue(Driver.FindElement(LoginPage.LogoSalesforce).Displayed);

        }

    }
}
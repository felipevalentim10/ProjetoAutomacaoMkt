using OpenQA.Selenium;
using System;
using System.Diagnostics.Metrics;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoAutomacaoMkt.PageObjects.Contas;



namespace ProjetoAutomacaoMkt.Steps.Conta
{
    public class ContasSteps : Hooks
    {
        public static void CriarConta(string Email, string Senha)
        {

            LoginSteps.ValidarLoginSucesso(Email, Senha);
            Thread.Sleep(5000);

            //Foi necessário essa primeira linha de código mais robusta pois automação com Salesforce da muito erro de Javascript nas linhas iniciais pela demora adocional no carregamento das telas 
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Driver;
            IWebElement element = Driver.FindElement(By.XPath("//a[@title='Contas']"));
            jsExecutor.ExecuteScript("arguments[0].click();", element);

            
        }
    }
}
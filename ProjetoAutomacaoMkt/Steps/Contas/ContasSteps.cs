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
            Thread.Sleep(10000);
            Driver.FindElement(ContasPage.BotaoContas).Click();
            Thread.Sleep(7000);
        }
    }
}
using OpenQA.Selenium;
using System;
using System.Diagnostics.Metrics;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoAutomacaoMkt.PageObjects.Oportunidade;


namespace ProjetoAutomacaoMkt.Steps.Oportunidade
{
    public class OportunidadesSteps : Hooks
    {
        public static void CriarOportunidade(string Email, string Senha)
        {

            LoginSteps.ValidarLoginSucesso(Email, Senha);
            Thread.Sleep(10000);
            Driver.FindElement(OportunidadePage.ClicarEmOportunidades).Click();
            Thread.Sleep(7000);
            Driver.FindElement(OportunidadePage.ClicarEmCriar).Click();
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.ClicarEmClienteAlvo).Click();
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.ClicarEmAvançar).Click();
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.CliqueNoCampoConta).Click();
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.DigiteONomeDaConta).SendKeys("A Sementeira");
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.CliqueNaContaDigitada).Click();
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.CliqueNoCampoEndereco).Click();
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.DigiteONomeDoEndereco).SendKeys("R.NENZINHA ARANHA ESQC/AV.JOSÉ 1425");
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.CliqueNoEndereco).Click();
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.CliqueNoContato).Click();
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.CliqueNoContato).Click();
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.CliqueNoCampoNomeDaOportunidade).Click();
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.DigiteONomeDaOportunidade).SendKeys("Oportunidade automatizada");
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.CliqueNoCampoDataDaConclusao).Click();
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.DigiteADataDeConclusao).SendKeys("05/12/2024");
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.CliqueNoCampoTerritorio).Click();
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.CliqueNoTerritorio).Click();
            Thread.Sleep(3000);
            Driver.FindElement(OportunidadePage.CliqueAvancar).Click();


        }
    }
}
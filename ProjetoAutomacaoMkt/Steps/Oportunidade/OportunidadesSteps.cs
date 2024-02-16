using OpenQA.Selenium;
using System;
using System.Diagnostics.Metrics;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoAutomacaoMkt.PageObjects.Oportunidade;
using OpenQA.Selenium.Chrome;


namespace ProjetoAutomacaoMkt.Steps.Oportunidade
{
    public class OportunidadesSteps : Hooks
    {
        public static void CriarOportunidade(string parametro1, string parametro2)
        {
           
            LoginSteps.ValidarLoginSucesso(parametro1, parametro2);
            Thread.Sleep(6000);

            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Driver;
            IWebElement element = Driver.FindElement(By.XPath("//a[@title='Oportunidades']"));
            jsExecutor.ExecuteScript("arguments[0].click();", element);

            
            Thread.Sleep(3000);
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
            Thread.Sleep(300);
            Driver.FindElement(OportunidadePage.CliqueAvancar).Click();


        }
    }
}
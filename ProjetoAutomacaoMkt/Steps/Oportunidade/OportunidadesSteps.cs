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
        private static void AguardarAcao()
        {
            // Ação para que seja respesitado o time antes da execução da linha de código
            Thread.Sleep(1000);
        }

        public static void CriarOportunidade(string parametro1, string parametro2)
        {
            LoginSteps.ValidarLoginSucesso(parametro1, parametro2);
            Thread.Sleep(5000);

            //Foi necessário essa primeira linha de código mais robusta pois automação com Salesforce da muito erro de Javascript nas linhas iniciais pela demora adocional no carregamento das telas 
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Driver;
            IWebElement element = Driver.FindElement(By.XPath("//a[@title='Oportunidades']"));
            jsExecutor.ExecuteScript("arguments[0].click();", element);


            AguardarAcao();
            Driver.FindElement(OportunidadePage.ClicarEmCriar).Click();

            AguardarAcao();
            Driver.FindElement(OportunidadePage.ClicarEmClienteAlvo).Click();

            AguardarAcao();
            Driver.FindElement(OportunidadePage.ClicarEmAvançar).Click();

            AguardarAcao();
            Driver.FindElement(OportunidadePage.CliqueNoCampoConta).Click();

            AguardarAcao();
            Driver.FindElement(OportunidadePage.DigiteONomeDaConta).SendKeys("A Sementeira");

            AguardarAcao();
            Driver.FindElement(OportunidadePage.CliqueNaContaDigitada).Click();

            AguardarAcao();
            Driver.FindElement(OportunidadePage.CliqueNoCampoEndereco).Click();

            AguardarAcao();
            Driver.FindElement(OportunidadePage.DigiteONomeDoEndereco).SendKeys("R.NENZINHA ARANHA ESQC/AV.JOSÉ 1425");

            AguardarAcao();
            Driver.FindElement(OportunidadePage.CliqueNoEndereco).Click();

            AguardarAcao();
            Driver.FindElement(OportunidadePage.CliqueNoCampoContato).Click();

            AguardarAcao();
            Driver.FindElement(OportunidadePage.CliqueNoContatoJoaoSilva).Click();

            AguardarAcao();
            Driver.FindElement(OportunidadePage.CliqueNoCampoNomeDaOportunidade).Click();

            AguardarAcao();
            Driver.FindElement(OportunidadePage.DigiteONomeDaOportunidade).SendKeys("Oportunidade automatizada");

            AguardarAcao();
            Driver.FindElement(OportunidadePage.CliqueNoCampoDataDaConclusao).Click();

            AguardarAcao();
            Driver.FindElement(OportunidadePage.DigiteADataDeConclusao).SendKeys("05/12/2024");

            AguardarAcao();
            Driver.FindElement(OportunidadePage.CliqueNoCampoTerritorio).Click();

            AguardarAcao();
            Driver.FindElement(OportunidadePage.CliqueNoTerritorio).Click();
            
            AguardarAcao();
            Driver.FindElement(OportunidadePage.CliqueAvancar).Click();


        }
    }
}
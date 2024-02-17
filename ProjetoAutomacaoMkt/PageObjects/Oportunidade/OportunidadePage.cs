using OpenQA.Selenium;
using System;


namespace ProjetoAutomacaoMkt.PageObjects.Oportunidade
{
    public class OportunidadePage
    {

        public static By ClicarEmOportunidades = By.XPath("//a[@title='Oportunidades']");

        public static By ClicarEmCriar = By.XPath("//div[@title='Criar']");

        public static By ClicarEmClienteAlvo = By.XPath("/html/body/div[4]/div[2]/div/div[2]/div/div[2]/div/div/div[1]/div/div/div[1]/fieldset/div[1]/div[3]/label/div[2]/span");

        public static By ClicarEmAvançar = By.XPath("/html/body/div[4]/div[2]/div/div[2]/div/div[2]/div/div/div[2]/div/button[2]");

        public static By CliqueNoCampoConta = By.XPath("//*[@id=\"input-223\"]");

        public static By DigiteONomeDaConta = By.XPath("//*[@id=\"input-223\"]");

        public static By CliqueNaContaDigitada = By.XPath("/html/body/div[4]/div[1]/section/div[1]/div[2]/div[2]/div[1]/div/div/div/div[3]/div/div/c-sales-simulation-customer-data/main/section/div/div[1]/section/c-sales-simulation-acc-data-info/section[1]/c-generic-custom-lookup[1]/div/div/div/div[2]/ul/li[1]/div");

        public static By CliqueNoCampoEndereco = By.XPath("/html/body/div[4]/div[1]/section/div[1]/div[2]/div[2]/div[1]/div/div/div/div[3]/div/div/c-sales-simulation-customer-data/main/section/div/div[1]/section/c-sales-simulation-acc-data-info/section[1]/c-generic-custom-lookup[2]/div/div/div/div[1]/div[1]/lightning-input/lightning-primitive-input-simple/div[1]/div/input");

        public static By DigiteONomeDoEndereco = By.XPath("/html/body/div[4]/div[1]/section/div[1]/div[2]/div[2]/div[1]/div/div/div/div[3]/div/div/c-sales-simulation-customer-data/main/section/div/div[1]/section/c-sales-simulation-acc-data-info/section[1]/c-generic-custom-lookup[2]/div/div/div/div[1]/div[1]/lightning-input/lightning-primitive-input-simple/div[1]/div/input");

        public static By CliqueNoEndereco = By.XPath("/html/body/div[4]/div[1]/section/div[1]/div[2]/div[2]/div[1]/div/div/div/div[3]/div/div/c-sales-simulation-customer-data/main/section/div/div[1]/section/c-sales-simulation-acc-data-info/section[1]/c-generic-custom-lookup[2]/div/div/div/div[2]/ul/li/div");

        public static By CliqueNoCampoContato = By.XPath("//input[@id='input-208']");

        public static By CliqueNoContatoJoaoSilva = By.XPath("//div[@data-recid='0036C00000tGdKuQAK']");

        public static By CliqueNoCampoNomeDaOportunidade = By.XPath("/html/body/div[4]/div[1]/section/div[1]/div[2]/div[2]/div[1]/div/div/div/div[3]/div/div/c-sales-simulation-customer-data/main/section/div/div[1]/div[3]/section[1]/lightning-input[1]/lightning-primitive-input-simple/div[1]/div/input");

        public static By DigiteONomeDaOportunidade = By.XPath("/html/body/div[4]/div[1]/section/div[1]/div[2]/div[2]/div[1]/div/div/div/div[3]/div/div/c-sales-simulation-customer-data/main/section/div/div[1]/div[3]/section[1]/lightning-input[1]/lightning-primitive-input-simple/div[1]/div/input");

        public static By CliqueNoCampoDataDaConclusao = By.XPath("/html/body/div[4]/div[1]/section/div[1]/div[2]/div[2]/div[1]/div/div/div/div[3]/div/div/c-sales-simulation-customer-data/main/section/div/div[1]/div[3]/section[1]/lightning-input[2]/lightning-datepicker/div[1]/div/input");

        public static By DigiteADataDeConclusao = By.XPath("/html/body/div[4]/div[1]/section/div[1]/div[2]/div[2]/div[1]/div/div/div/div[3]/div/div/c-sales-simulation-customer-data/main/section/div/div[1]/div[3]/section[1]/lightning-input[2]/lightning-datepicker/div[1]/div/input");

        public static By CliqueNoCampoTerritorio = By.XPath("/html/body/div[4]/div[1]/section/div[1]/div[2]/div[2]/div[1]/div/div/div/div[3]/div/div/c-sales-simulation-customer-data/main/section/div/div[1]/div[3]/section[2]/c-generic-custom-lookup/div/div/div/div[1]/div[1]/lightning-input/lightning-primitive-input-simple/div[1]/div/input");

        public static By CliqueNoTerritorio = By.XPath("/html/body/div[4]/div[1]/section/div[1]/div[2]/div[2]/div[1]/div/div/div/div[3]/div/div/c-sales-simulation-customer-data/main/section/div/div[1]/div[3]/section[2]/c-generic-custom-lookup/div/div/div/div[2]/ul/li[2]/div");

        public static By CliqueAvancar = By.XPath("/html/body/div[4]/div[1]/section/div[1]/div[2]/div[2]/div[1]/div/div/div/div[3]/div/div/c-sales-simulation-customer-data/main/section/div/div[2]/c-sales-simulation-footer/section/section[2]/lightning-button[2]/button");

    }
}
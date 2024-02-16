using OpenQA.Selenium;
using System;


namespace ProjetoAutomacaoMkt.PageObjects
{
    public class LoginPage
    {
        public static By DigiteEmail = By.XPath("//*[@id='username']");
        public static By DigiteSenha = By.XPath("//*[@id='password']");
        public static By CliqueEmFaçaLoginNaSendbox = By.XPath("//*[@id='Login']");
        public static By LogoSalesforce = By.XPath("//*[@id=\"oneHeader\"]/div[2]/div[1]/div");
    }
}
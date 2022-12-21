using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Specialized;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Interactions;
using Cookie = OpenQA.Selenium.Cookie;
namespace MySoliqApp
{
    public class General
    {
        public IWebDriver driver;
        //MySoliq Page
        protected readonly By _buttonLanguageRu = By.XPath("//a[@class='rus ']");
        protected readonly By _buttonEnterCabinet = By.XPath("//a[@class='show_auth_modal_legal_entity_button']");
        protected readonly By _buttonsEsiOrUsb = By.XPath("//a[@class='thumbnail text-center dl-link']");
        protected readonly By _buttonsSignIn = By.XPath("//a[@class='btn btn-default sign-in']");
        protected readonly By _fieldcheckNumber = By.Id("checkNumber");
        protected readonly By _buttonFindCheck = By.Id("findButton");
        protected readonly By _fieldVat = By.XPath("//input[@name='vat']");
        protected readonly By _arrowIkpu = By.XPath("//span[@class='select2-selection__arrow']");
        protected readonly By _fieldIkpu = By.XPath("//input[@class='select2-search__field']");
        protected readonly By _labelSelectIkpu = By.XPath("//li[@role='option']");
        protected readonly By _buttonUnit = By.XPath("//div[@class='dropdown bootstrap-select form-control bs3']//button[@class='btn dropdown-toggle btn-default bs-placeholder']");
        protected readonly By _buttonInn = By.XPath("//button[@class='btn dropdown-toggle bs-placeholder btn-default']");//
        protected readonly By _labelUnit = By.XPath("//span[@class='text']");
        protected readonly By _loadPdf = By.Id("zipFile");
        protected readonly By _buttonCalculate = By.Id("btnCalc");
        protected readonly By _fieldInn = By.XPath("//input[@type='text']");
        protected readonly By _buttonSend = By.Id("btnSend");
        protected readonly By _fieldVatTotal=By.XPath("//input[@name='sumVatTotal']");
        protected readonly By _buttonsSelect = By.XPath("//button[@title='Выберите']");
        protected readonly By _fieldTotalPrice = By.XPath("//input[@name='cardTotal']");
        //Tasnif Page
        protected readonly By _switchSaliqLanguage =By.XPath("//span[@class='ant-dropdown-trigger Dropdown_linkStyle__2Ty3i']");
        protected readonly By _languageRu = By.XPath("//span[@class='ant-dropdown-menu-title-content']");
        protected readonly By _buttonEnter =By.XPath("//button[@type='button']");
        protected readonly By _labelEkpu = By.XPath("//a[@href='/activities']");
        protected readonly By _buttonSaveCategory = By.XPath("//span[text()='Сохранить категорию']");
    }
}
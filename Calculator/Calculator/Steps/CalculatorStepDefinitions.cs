using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Threading.Tasks;
using Microsoft.Playwright;
using TechTalk.SpecFlow.Assist;
using System.Linq;
using Calculator.Helper;

namespace Calculator.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;
        private IPage page;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"User navigates to register page")]
        public async Task GivenUserNavigatesToHomepage()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 100
            });
            page = await browser.NewPageAsync();
            await page.GotoAsync("https://parabank.parasoft.com/parabank/register.htm");
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });
        }

        [When(@"User logins with username (.*) and password (.*)")]
        public async Task WhenUserLoginsWithUsername_AndPassword_(string username, string password)
        {
            await page.FillAsync("[name='username']", username);
            await page.FillAsync("[name='password']", password);
        }

        [When(@"User clicks the log in button")]
        public async Task WhenUserClicksLoginButton()
        {
            await page.ClickAsync("[value = 'Log In']");
        }

        [When(@"User clicks the register button")]
        public async Task WhenUserClicksRegisterButton()
        {
            await page.ClickAsync("[value = 'Register']");
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });
        }

        [Then(@"the following field should display the coresponding error")]
        public async Task ThenFieldsShouldHaveError(Table table)
        {
            var dictionary = TableExtentions.ToDictionary(table);
            foreach (var value in dictionary)
            {
                string id = Enums.GetFieldErrorId(value.Key);
                var text = await page.TextContentAsync(id);
                Assert.AreEqual(text, value.Value);
            }
        }

        [When(@"fill out the following field with the coresponding text")]
        public async Task FillFieldsWithText(Table table)
        {
            var dictionary = TableExtentions.ToDictionary(table);
            foreach (var value in dictionary)
            {
                string id = Enums.GetInputFieldId(value.Key);
                var text = value.Value;
                if (id == "[id = 'customer.username']")
                {
                    text =  RandomStringGenerator.RandomString(5);
                }
                
                await page.FillAsync(id, text);
            }
        }

        [When(@"fill out the following field with the coresponding text with existing username")]
        public async Task FillFieldsWithTextExistingUsername(Table table)
        {
            var dictionary = TableExtentions.ToDictionary(table);
            foreach (var value in dictionary)
            {
                string id = Enums.GetInputFieldId(value.Key);
                var text = value.Value;
                await page.FillAsync(id, text);
            }
        }


        [Then(@"User has succefully logged in")]
        public async Task ThenUserHasSuccefullyLoggedIn()
        {
            Assert.AreEqual(await page.Locator("//div[@ng-if='showOverview']/h1[@class='title']").TextContentAsync(), "Accounts Overview");
        }

        [Then(@"User has succefully registered")]
        public async Task ThenUserHasSuccefullyRegistered()
        {
            Assert.AreEqual(await page.Locator("//div[@id='rightPanel']/p").TextContentAsync(), "Your account was created successfully. You are now logged in.");
        }


        //// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        //private readonly ScenarioContext _scenarioContext;

        //public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        //{
        //    _scenarioContext = scenarioContext;
        //}

        //[Given("the first number is (.*)")]
        //public void GivenTheFirstNumberIs(int number)
        //{
        //    //TODO: implement arrange (precondition) logic
        //    // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
        //    // To use the multiline text or the table argument of the scenario,
        //    // additional string/Table parameters can be defined on the step definition
        //    // method. 

        //}

        //[Given("the second number is (.*)")]
        //public void GivenTheSecondNumberIs(int number)
        //{
        //    //TODO: implement arrange (precondition) logic
        //    // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
        //    // To use the multiline text or the table argument of the scenario,
        //    // additional string/Table parameters can be defined on the step definition
        //    // method. 

        //}

        //[When("the two numbers are added")]
        //public void WhenTheTwoNumbersAreAdded()
        //{
        //    //TODO: implement act (action) logic

        //}

        //[Then("the result should be (.*)")]
        //public void ThenTheResultShouldBe(int result)
        //{
        //    Assert.AreEqual(1,1);
        //}
    }
}

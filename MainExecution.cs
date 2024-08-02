using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using ManagerPortal;


namespace ManagerPortal
{

    public class MainExecution : PageTest
    {
        Loginpage login = new Loginpage();
        Extentreport extent = new Extentreport();
        FeedbackTable Apply = new FeedbackTable(); 
       
        [SetUp]
        public void Setup()
        {
            extent.LogReport("ManagerPortal");
        }
        [TearDown]
        public void Teardown()
        {
            extent.flush();
        }
       
        public async Task Login()
        {
            await login.Login(Page);
           
        }

        [Test]
        public async Task FilterOut()
        {
            await Login();
            await Apply.Feedbackfilters(Page);
        }

    }
}








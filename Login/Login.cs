using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerPortal
{
    public class Loginpage
    {
        Basepage bp = new Basepage();
        Extentreport extent = new Extentreport();
        public async Task Login(IPage page)
        {
            Console.WriteLine("Login Page");
            extent.ParentLog("Login");
            extent.ChildLog("Goto Login Page");
            await bp.Goto(page, "https://staging-performance.progatix.com/auth/login");
            extent.ChildLog("Action Performed");
            await bp.Write(page, "#username", "adeel.shekhani@wiztech.pk", "Username Entered");
            await bp.Write(page, "#userPassword", "123456", "Passwrod Entered");
            await bp.Click(page, "//button[contains(@class,'bg-primary')]", "Click on Login Button");
            await bp.Wait(2000);

        }
    }
}

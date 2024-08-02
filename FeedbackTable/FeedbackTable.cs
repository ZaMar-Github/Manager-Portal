using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerPortal
{
     public class FeedbackTable
    {
        Basepage bp = new Basepage();
        Extentreport extent = new Extentreport();
        
        public async Task Feedbackfilters(IPage page)
        {
            // Wait for the element to be visible
            var element = await page.WaitForSelectorAsync("//span[text()='Filter by Employee']");

            // Get the text content of the element
            var textContent = await element.InnerTextAsync();

            // Print the text content
            System.Console.WriteLine(textContent);
           
            Console.WriteLine("Feedback Filters");
            //Filter By Employee 
            await bp.SelectFilter(page, "//span[text()='Filter by Employee']", "//input[contains(@class, 'p-dropdown-filter')]", "zam", "Filter By Employee");
            //Filter By Manager
            await bp.SelectFilter(page, "//span[text()='Filter by Manager']", "//span[text()='Filter by Manager']/../div//following-sibling::div//input", "Adee", "Filter By Manager");
            //Filter By Project
            await bp.SelectProject(page, "//div[text()='Select Project']", "//p-multiselect/div/div[4]/div[1]/div[2]/input","per", "//p-multiselect/div/div[4]/div[2]/ul/p-multiselectitem/li/div[1]/div", "Filter By Project");
            //Click on Filter By Date 
            await bp.Click(page, "//label[text()='Filter by Date ']//..//button", "Click on Date Field");
            //Click on Backward in Celender  
            await bp.Click(page, "//span/div/div/div/div[1]/button[1]", "Click on Backward Button");
            //Select From Date 
            await bp.Click(page, "//span/div/div/div/div[2]/table/tbody/tr[1]/td[7]/span", "Select From Date");
            //Click on Forward in Celender 
            await bp.Click(page, "//span/div/div/div/div[1]/button[2]", "Click on Farward Button");
            //Select To Date
            await bp.Click(page, "//span/div/div/div/div[2]/table/tbody/tr[3]/td[5]/span", "Select To Date");

            await bp.Wait(5000);

            //Click Outside To Close Date Calender
            await bp.Click(page, "//h1[text()='Feedback']", "Click outside");
       

        }
    } 
}

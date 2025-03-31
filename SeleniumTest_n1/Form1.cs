using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumTest_n1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);

            //Vào web 
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            //Tìm username và điền vào
            IWebElement ele = driver.FindElement(By.Name("user-name"));
            ele.SendKeys("standard_user");
            Thread.Sleep(200);

            //Tìm password
            ele = driver.FindElement(By.Name("password"));
            ele.SendKeys("secret_sauce");
            Thread.Sleep(200);

            //Click login
            ele = driver.FindElement(By.CssSelector("input[type='submit']"));
            ele.Click();
            Thread.Sleep(2000);

            //Thêm sp vào giỏ
            ele = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            ele.Click();
            Thread.Sleep(1000);

            //Click  vào giỏ hàng
            ele = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[3]/a"));
            ele.Click();
            Thread.Sleep(200);

            //Click thanh toán
            ele = driver.FindElement(By.ClassName("checkout_button"));
            ele.Click();
            Thread.Sleep(200);
            
            //Điền first name
            ele = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[1]/div[1]/input"));
            ele.SendKeys("Le");
            Thread.Sleep(200);
            
            //Điền first name
            ele = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[1]/div[2]/input"));
            ele.SendKeys("Hoang Phuc");
            Thread.Sleep(200);
            
            //Điền Postal code
            ele = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[1]/div[3]/input"));
            ele.SendKeys("123");
            Thread.Sleep(200);
            
            //Click end
            ele = driver.FindElement(By.Id("continue"));
            ele.Click();
            Thread.Sleep(1000);
            
            //Click end
            ele = driver.FindElement(By.Name("finish"));
            ele.Click();
            Thread.Sleep(200);
        }
    }
}

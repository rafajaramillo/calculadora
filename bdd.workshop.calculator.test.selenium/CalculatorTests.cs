using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace bdd.workshop.calculator.test.selenium
{
    public class CalculatorTests
    {
        
        [Fact]
        [Trait("TestType", "FT")]
        public void BasicAdd()
        {
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            string op = "+";
            string ig = "=";
            int a = 1;
            int b = 2;
            double result = 3;

            driver.Url = "http://localhost:4234/Calculator";
            driver.Url = "http://localhost:4234/Calculator";
            //driver.FindElement(By.XPath("//input[@id='A']")).SendKeys(a.ToString());
            //driver.FindElement(By.XPath("//input[@id='Command']")).SendKeys("+");
            //driver.FindElement(By.XPath("//input[@id='B']")).SendKeys(b.ToString());
            //driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            driver.FindElement(By.XPath("//input[@id='s5']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(a.ToString());
            driver.FindElement(By.XPath("//input[@id='s8']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(op);
            driver.FindElement(By.XPath("//input[@id='s6']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(b.ToString());            
            driver.FindElement(By.XPath("//input[@id='s4']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(ig);
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(result.ToString());
            driver.FindElement(By.XPath("//input[@id='s4']")).Click();
            //inputA.SendKeys(a.ToString());
            //inputCmd.SendKeys("+");
            //inputB.SendKeys(b.ToString());
            //button.Click();
            //Assert.True(Operator.Add(a, b) == result);
        }
        [Fact]
        [Trait("TestType", "FT")]
        public void BasicMultiply()
        {
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            string op = "x";
            string ig = "=";
            int a = 9;
            int b = 8;
            double result = 72;

            driver.Url = "http://localhost:4234/Calculator";          
          
            driver.FindElement(By.XPath("//input[@id='s15']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(a.ToString());
            driver.FindElement(By.XPath("//input[@id='s16']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(op);
            driver.FindElement(By.XPath("//input[@id='s14']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(b.ToString());
            driver.FindElement(By.XPath("//input[@id='s4']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(ig);
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(result.ToString());
            driver.FindElement(By.XPath("//input[@id='s4']")).Click();


            //Assert.True(Operator.Multiply(a, b) == result);
        }
        [Fact]
        [Trait("TestType", "FT")]
        public void BasicDivide()
        {
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            string op = "/";
            string ig = "=";
            int a = 20;
            int b = 4;
            double result = 5;

            driver.Url = "http://localhost:4234/Calculator";

            driver.FindElement(By.XPath("//input[@id='s6']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys("2");
            driver.FindElement(By.XPath("//input[@id='s1']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys("0");
            driver.FindElement(By.XPath("//input[@id='s2']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(op);
            driver.FindElement(By.XPath("//input[@id='s9']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(b.ToString());
            driver.FindElement(By.XPath("//input[@id='s4']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(ig);
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(result.ToString());
            driver.FindElement(By.XPath("//input[@id='s4']")).Click();
            //Assert.True(Operator.Divide(a, b) == result);
        }

        [Fact]
        [Trait("TestType", "FT")]
        public void BasicSubstract()
        {
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            string op = "-";
            string ig = "=";
            int a = 10;
            int b = 6;
            double result = 4;

            driver.Url = "http://localhost:4234/Calculator";

            driver.FindElement(By.XPath("//input[@id='s5']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys("1");
            driver.FindElement(By.XPath("//input[@id='s1']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys("0");
            driver.FindElement(By.XPath("//input[@id='s12']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(op);
            driver.FindElement(By.XPath("//input[@id='s11']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(b.ToString());
            driver.FindElement(By.XPath("//input[@id='s4']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(ig);
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(result.ToString());
            driver.FindElement(By.XPath("//input[@id='s4']")).Click();

            //Assert.True(Operator.Substract(a, b) == result);
        }
        [Fact]
        [Trait("TestType", "FT")]
        public void DividingNonIntegerResult()
        {
            using IWebDriver driver = new ChromeDriver("C:\\CommonExePath\\");
            string op = "√";
            string ig = "=";
            int a = 25;
            int b = 6;
            double result = 5;

            driver.Url = "http://localhost:4234/Calculator";

            driver.FindElement(By.XPath("//input[@id='s3']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(op);
            driver.FindElement(By.XPath("//input[@id='s6']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys("2");
            driver.FindElement(By.XPath("//input[@id='s11']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys("5");            
            driver.FindElement(By.XPath("//input[@id='s4']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(ig);
            driver.FindElement(By.XPath("//input[@id='txtNumber']")).SendKeys(result.ToString());
            driver.FindElement(By.XPath("//input[@id='s4']")).Click();

            //Assert.True(Operator.Divide(a, b) == result);
        }
    }
}

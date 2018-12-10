using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OpenGoogleTest {
    class Program {
        static IAlert alert;
        static void Main (string[] args) {
            string pathToDriver = "/Users/cliff/Desktop/selenium/assets/";

            Console.WriteLine ("We are starting");

            using (IWebDriver webDriver = new ChromeDriver (pathToDriver)) {
                // Find Element
                /*
                webDriver.Navigate ().GoToUrl ("http://testing.todorvachev.com/selectors/name/");
                IWebElement element = webDriver.FindElement (By.Name ("myName"));

                if (element.Displayed) {
                    GreenMessage ("I can see the element");
                } else {
                    RedMessage ("Error: Element missing.");
                }
                */
                // Find ID
                /*
                webDriver.Navigate ().GoToUrl ("http://testing.todorvachev.com/selectors/id/");
                IWebElement idElement = webDriver.FindElement (By.Id ("testImage"));

                if (idElement.Displayed) {
                    GreenMessage ("I can see the ID");
                } else {
                    RedMessage ("Error: ID missing.");
                }
                */
                // Find Class Name
                /* 
                webDriver.Navigate ().GoToUrl ("http://testing.todorvachev.com/selectors/class-name/");
                IWebElement classElement = webDriver.FindElement (By.ClassName ("testClass"));

                Console.WriteLine (classElement.Text); 
                */

                // CSS xPath and Path
                /*
                webDriver.Navigate ().GoToUrl ("http://testing.todorvachev.com/selectors/css-path/");
                IWebElement cssPathElement = webDriver.FindElement (By.CssSelector ("#post-108 > div > figure > img"));
                IWebElement xPathElement = webDriver.FindElement (By.XPath ("//*[@id=\"post-108\"]/div/figure/img"));
                if (cssPathElement.Displayed) {
                    GreenMessage ("cssPathElement is visible");
                } else {
                    RedMessage ("cssPathElement is not visible");
                }
                if (xPathElement.Displayed) {
                    GreenMessage ("xPathElement is visible");
                } else {
                    RedMessage ("xPathElement is not visible");
                }
                 */

                // Text Input Field
                /*
                webDriver.Navigate ().GoToUrl ("http://testing.todorvachev.com/special-elements/text-input-field/");
                IWebElement textbox = webDriver.FindElement (By.Name ("username"));
                textbox.SendKeys ("Test Test");
                Thread.Sleep (3000);
                Console.WriteLine (textbox.GetAttribute ("value"));
                Thread.Sleep (3000);
                */

                // CheckBox
                /* 
                webDriver.Navigate ().GoToUrl ("http://testing.todorvachev.com/special-elements/check-button-test-3/");
                IWebElement checkbox = webDriver.FindElement (By.CssSelector ("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(1)"));
                if (checkbox.GetAttribute ("checked") == "true") {
                    Console.WriteLine ("The box is checked.");
                } else {
                    Console.WriteLine ("The box is not checked.");

                }
                */

                // Alert box
                webDriver.Navigate ().GoToUrl ("http://testing.todorvachev.com/special-elements/alert-box/");
                alert = webDriver.SwitchTo ().Alert ();
                Thread.Sleep (3000);
                Console.WriteLine (alert.Text);
                alert.Accept ();
                Thread.Sleep (3000);
                webDriver.Quit ();
            }

        }

        private static void RedMessage (string message) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine (message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void GreenMessage (string message) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine (message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
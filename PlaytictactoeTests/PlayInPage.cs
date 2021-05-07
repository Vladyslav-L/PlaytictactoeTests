using OpenQA.Selenium;
using System;
using VisioForge.Shared.MediaFoundation.OPM;

namespace PlaytictactoeTests
{
    public class PlayInPage
    {
        private readonly IWebDriver _webDriver;

        private static By _squareTopLeftField = By.CssSelector("[class='square top left']");
        private static By _squareTopLeftAction = By.XPath("//div[contains(@class,'square top left')]/div");
        private static By _squareTopField = By.CssSelector("[class='square top']");
        private static By _squareTopAction = By.XPath("//div[@class='square top']/div");
        private static By _squareTopRightField = By.CssSelector("[class='square top right']");
        private static By _squareTopRightAction = By.XPath("//div[contains(@class,'square top right')]/div");
        private static By _squareLeftField = By.CssSelector("[class='square left']");
        private static By _squareLeftAction = By.XPath("//div[contains(@class,'square left')]/div");
        private static By _squareField = By.CssSelector("[class='square']");       
        private static By _squareAction = By.XPath("//div[@class='square']/div");
        private static By _squareRightField = By.CssSelector("[class='square right']");
        private static By _squareRightAction = By.XPath("//div[@class='square right']/div");
        private static By _squareBottomLeftField = By.CssSelector("[class='square bottom left']");
        private static By _squareBottomLeftAction = By.XPath("//div[@class='square bottom left']/div");
        private static By _squareBottomField = By.CssSelector("[class='square bottom']");
        private static By _squareBottomAction = By.XPath("//div[@class='square bottom']/div");
        private static By _squareBottomRightField = By.CssSelector("[class='square bottom right']");
        private static By _squareBottomRightAction = By.XPath("//div[@class='square bottom right']/div");
        private static By _scoreAppearField = By.CssSelector("[class='score appear']");
        private static By _scoreField = By.CssSelector("[class='score']");
        private static By _player2Field = By.CssSelector("[class^='player2']");
        private static By _player2 = By.XPath("//body/div[4]/p[3]");

        public PlayInPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public PlayInPage GoToPlayInPage()
        {
            _webDriver.Navigate().GoToUrl("https://playtictactoe.org/");
            return this;
        }

        public void ClickTopLeft() =>
           _webDriver.FindElement(_squareTopLeftField).Click();

        public string GetTopLeft() =>
           _webDriver.FindElement(_squareTopLeftAction).GetAttribute("class");

        public void ClickTopRight() =>
           _webDriver.FindElement(_squareTopRightField).Click();

         public string GetTopRight() =>
           _webDriver.FindElement(_squareTopRightAction).GetAttribute("class");

        public void ClickTop() =>
          _webDriver.FindElement(_squareTopField).Click();

         public string GetTop() =>
          _webDriver.FindElement(_squareTopAction).GetAttribute("class");

        public void ClickLeft() =>
          _webDriver.FindElement(_squareLeftField).Click();

        public string GetLeft() =>
          _webDriver.FindElement(_squareLeftAction).GetAttribute("class");

        public void ClickCenter() =>
          _webDriver.FindElement(_squareField).Click();

        public string GetCenter() =>
          _webDriver.FindElement(_squareAction).GetAttribute("class");

        public void ClickRight() =>
          _webDriver.FindElement(_squareRightField).Click();

         public string GetRight() =>
          _webDriver.FindElement(_squareRightAction).GetAttribute("class");

        public void ClickBottomLeft() =>
          _webDriver.FindElement(_squareBottomLeftField).Click();

         public string GetBottomLeft() =>
          _webDriver.FindElement(_squareBottomLeftAction).GetAttribute("class");

        public void ClickBottom() =>
          _webDriver.FindElement(_squareBottomField).Click();

        public string GetBottom() =>
          _webDriver.FindElement(_squareBottomField).GetAttribute("class");

        public void ClickBottomRight() =>
          _webDriver.FindElement(_squareBottomRightField).Click();

        public string GetBottomRight() =>
          _webDriver.FindElement(_squareBottomRightField).GetAttribute("class");

         public string GetScore() =>
          _webDriver.FindElement(_scoreField).Text;

        public string GetScoreAppear() =>
          _webDriver.FindElement(_scoreAppearField).Text;
        
        public string GetPlayer2Text() =>
          _webDriver.FindElement(_player2).Text;

        public void ClickPlayer2() =>
          _webDriver.FindElement(_player2Field).Click();
    }
}





using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using System.Globalization;
using OpenQA.Selenium.Support.UI;

namespace PlaytictactoeTests
{
    public class PlayTests
    {
        private IWebDriver _webDriver;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }

        [Test]
        public void CheckUpdateScore()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickPlayer2();
            playInPage.ClickRight();
            playInPage.ClickLeft();
            playInPage.ClickTopRight();
            playInPage.ClickBottomLeft();
            playInPage.ClickBottomRight();
            Thread.Sleep(3000);

            var actualResult = playInPage.GetScoreAppear();
            playInPage.GetCenter();

            Assert.AreEqual("1", actualResult);
        }

        [Test]
        public void CheckUpdateScoreForAppear()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickPlayer2();
            playInPage.ClickRight();
            playInPage.ClickLeft();
            playInPage.ClickTopRight();
            playInPage.ClickBottomLeft();
            playInPage.ClickCenter();
            playInPage.ClickTopLeft();
            Thread.Sleep(3000);

            var actualResult = playInPage.GetScoreAppear();

            Assert.AreEqual("1", actualResult);
        }

        [Test]
        public void CheckUpdateScoreForDraw()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickPlayer2();
            playInPage.ClickRight();
            playInPage.ClickBottomRight();
            playInPage.ClickTopRight();
            playInPage.ClickCenter();
            playInPage.ClickBottom();
            playInPage.ClickBottomLeft();
            playInPage.ClickTopLeft();
            playInPage.ClickTop();
            playInPage.ClickLeft();
            Thread.Sleep(3000);

            var actualResult = playInPage.GetScoreAppear();

            Assert.AreEqual("1", actualResult);
        }

        [Test]
        public void CheckRefreshGame()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickRight();
            playInPage.ClickPlayer2();
            Thread.Sleep(3000);

            Assert.IsTrue(
                playInPage.GetBottom() == "" && playInPage.GetBottomLeft() == "" && playInPage.GetBottomRight() == "" &&
                playInPage.GetCenter() == "" && playInPage.GetLeft() == "" && playInPage.GetRight() == "" && playInPage.GetTop() == "" &&
                playInPage.GetTopLeft() == "" && playInPage.GetTopRight() == "");
        }

        [Test]
        public void CheckAppearClick()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickRight();
            Thread.Sleep(2000);

            Assert.IsTrue(
                playInPage.GetBottom() == "o" || playInPage.GetBottomLeft() == "o" || playInPage.GetBottomRight() == "o" ||
                playInPage.GetCenter() == "o" || playInPage.GetLeft() == "o" || playInPage.GetRight() == "o" || playInPage.GetTop() == "o" ||
                playInPage.GetTopLeft() == "o" || playInPage.GetTopRight() == "o");
        }

        [Test]
        public void CheckUserClick()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickRight();
            Thread.Sleep(500);

            var actualResult = playInPage.GetRight();

            Assert.AreEqual("x", actualResult);
        }

        [Test]
        public void CheckSquareTopLeftFieldIsClickable()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickTopLeft();
            Thread.Sleep(500);

            var actualResult = playInPage.GetTopLeft();

            Assert.AreEqual("x", actualResult);
        }

        [Test]
        public void CheckSquareTopFieldIsClickable()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickTop();
            Thread.Sleep(500);

            var actualResult = playInPage.GetTop();

            Assert.AreEqual("x", actualResult);
        }

        [Test]
        public void CheckSquareTopRightFieldIsClickable()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickTopRight();
            Thread.Sleep(500);

            var actualResult = playInPage.GetTopRight();

            Assert.AreEqual("x", actualResult);
        }

        [Test]
        public void CheckSquareCenterFieldIsClickable()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickCenter();
            Thread.Sleep(500);

            var actualResult = playInPage.GetCenter();

            Assert.AreEqual("x", actualResult);
        }

        [Test]
        public void CheckSquareLeftFieldIsClickable()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickLeft();
            Thread.Sleep(500);

            var actualResult = playInPage.GetLeft();

            Assert.AreEqual("x", actualResult);
        }

        [Test]
        public void CheckSquareRightFieldIsClickable()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickRight();
            Thread.Sleep(500);

            var actualResult = playInPage.GetRight();

            Assert.AreEqual("x", actualResult);
        }

        [Test]
        public void CheckSquareBottomRightFieldIsClickable()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickBottomRight();
            Thread.Sleep(500);

            var actualResult = playInPage.GetBottomRight();

            Assert.AreEqual("x", actualResult);
        }

        [Test]
        public void CheckSquareBottomFieldIsClickable()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickBottom();
            Thread.Sleep(500);

            var actualResult = playInPage.GetBottom();

            Assert.AreEqual("x", actualResult);
        }

        [Test]
        public void CheckSquareBottomLeftFieldIsClickable()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickBottomLeft();
            Thread.Sleep(500);

            var actualResult = playInPage.GetBottomLeft();

            Assert.AreEqual("x", actualResult);
        }

        [Test]
        public void CheckUpdatePlayer2Name()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickPlayer2();
            Thread.Sleep(3000);

            var actualResult = playInPage.GetPlayer2Text();

            Assert.AreEqual("»√–Œ  2 ()\r\n0", actualResult);
        }

        [Test]
        public void CheckPlayer2Name()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            Thread.Sleep(2000);

            var actualResult = playInPage.GetPlayer2Text();

            Assert.AreEqual(" ŒÃœ‹ﬁ“≈– ()\r\n0", actualResult);
        }

        [Test]
        public void EasyWin()
        {
            var playInPage = new PlayInPage(_webDriver);
            playInPage.GoToPlayInPage();
            playInPage.ClickCenter();
            Thread.Sleep(2000);

            if (playInPage.GetRight() == "o" || playInPage.GetTop() == "o" || playInPage.GetBottom() == "o" || playInPage.GetLeft() == "o")
            {
                playInPage.ClickBottomRight();
                Thread.Sleep(1000);
            }
            else if (playInPage.GetBottomRight() == "o" || playInPage.GetTopRight() == "o" || playInPage.GetBottomLeft() == "o" || playInPage.GetTopLeft() == "o")
            {
                playInPage.ClickTopRight();
            }

            playInPage.ClickBottomLeft();
            Thread.Sleep(2000);

            if (playInPage.GetTopRight() != "o")
            {
                playInPage.ClickTopRight();
                Thread.Sleep(2000);
            }
            else if (playInPage.GetBottom() != "o")
            {
                playInPage.ClickBottom();
                Thread.Sleep(2000);
            }

            var actualResult = playInPage.GetScoreAppear();

            Assert.AreEqual("1", actualResult);
        }
    }
}
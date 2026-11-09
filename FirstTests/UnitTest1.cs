using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace FirstTests
{
    public class UnitTest1
    {
        [Test]
        public void TestOpenGoogle()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                // Mở Google
                driver.Navigate().GoToUrl("https://www.google.com");

                // Lấy tiêu đề trang
                string title = driver.Title;

                // In tiêu đề
                TestContext.WriteLine("Page Title: " + title);

                // Kiểm tra kết quả
                Assert.That(title, Does.Contain("Google"));

                // Giữ Chrome mở 5 giây để quan sát
                Thread.Sleep(100000);
            }
            finally
            {
                // Đóng trình duyệt
                driver.Quit();
            }
        }
    }
}
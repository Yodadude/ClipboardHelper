using System;
using System.Text;
using NUnit.Framework;
using System.IO;

namespace ClipboardHelper.Tests
{
    [TestFixture]
    public class ClipboardXmlRepositoryTests
    {
        [Test]
        public void SaveTest()
        {
            string[] items = {@"abc","123"};
            string filePath = Path.Combine(Directory.GetCurrentDirectory(),"test.xml");

            if (File.Exists(filePath))
                File.Delete(filePath);

            var repo = new ClipboardXmlRepository();
            repo.SetSource(filePath);
            repo.Save(items);

            Assert.IsTrue(File.Exists(filePath));
        }

        [Test]
        public void SaveMultilineStringsTest()
        {
            string[] items = { 
@"line 1
line 2
line 3", "123" };
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "test2.xml");

            if (File.Exists(filePath))
                File.Delete(filePath);

            var repo = new ClipboardXmlRepository();
            repo.SetSource(filePath);
            repo.Save(items);

            Assert.IsTrue(File.Exists(filePath));
        }

        [Test]
        public void ValidateSaveAndGetReturnSameNumberOfItems()
        {
            string[] items = {"abc", "123" };
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "test3.xml");

            if (File.Exists(filePath))
                File.Delete(filePath);

            var repo = new ClipboardXmlRepository();
            repo.SetSource(filePath);
            repo.Save(items);

            var saveditems = repo.Get();

            Console.WriteLine("items.length: {0}, saveitems.length:{1}", items.Length, saveditems.Length);

            Assert.IsTrue(items.Length == saveditems.Length);
        }

        [Test]
        public void ValidateSaveAndGetReturnItemsAreTheSame()
        {
            string[] items = { "abc", "123" };
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "test3.xml");

            if (File.Exists(filePath))
                File.Delete(filePath);

            var repo = new ClipboardXmlRepository();
            repo.SetSource(filePath);
            repo.Save(items);

            var saveditems = repo.Get();

            Console.WriteLine("items[0]= {0}, saveitems[0]={1}", items[0], saveditems[0]);
            Console.WriteLine("items[1]= {0}, saveitems[1]={1}", items[1], saveditems[1]);

            Assert.IsTrue(items.Length == saveditems.Length && items[0].Equals(saveditems[0]) && items[1].Equals(saveditems[1]), "Saved items do not match");
        }

    }
}

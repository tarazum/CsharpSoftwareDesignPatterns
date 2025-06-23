using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternLibrary.DesignPatterns.Singleton;
using System.Threading.Tasks;

namespace PatternLibrary.Tests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void Instance_ReturnsSameObject()
        {
            var instance1 = ThreadSafeSingleton.Instance;
            var instance2 = ThreadSafeSingleton.Instance;
            Assert.AreSame(instance1, instance2);
        }

        [TestMethod]
        public void Instance_IsThreadSafe()
        {
            var results = new ThreadSafeSingleton[10];
            Parallel.For(0, results.Length, i => { results[i] = ThreadSafeSingleton.Instance; });
            for (int i = 1; i < results.Length; i++)
            {
                Assert.AreSame(results[0], results[i]);
            }
        }
    }
}

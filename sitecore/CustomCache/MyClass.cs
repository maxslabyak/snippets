namespace Image0.Util
{
    public class MyClass
    {
        private const string _keyName = "SomeKey";
        private const string _testValue = "qwerty";
        public void DoSomething()
        {

            MyCustomCache.SetCache(_keyName,_testValue);
            var myKey = MyCustomCache.GetCache(_keyName);

            Assert.AreEqual(myKey,_testValue)


        }
    }
}
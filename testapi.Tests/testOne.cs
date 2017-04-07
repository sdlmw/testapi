using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testapi;
using System.IO;
using System.Reflection;

namespace testapi.Tests
{
    [TestClass]
    public class testOne
    {
        static StreamWriter sw = new StreamWriter(@"D:\Test.txt", false);
        //Models.Users result = null;
        //Controllers.testController controller = null;
        [ClassInitialize]
        public static void MyClassInitialize(TestContext testcontext)
        {
            if (!File.Exists(@"D:\Test.txt"))
            {
                File.Create(@"D:\Test.txt");
            }
            sw.WriteLine("这是ClassInitialize");
            sw.Flush();
        }
        [ClassCleanup]
        public static void MyClassCleanUp()
        {
            sw.WriteLine("这是ClassCleanUp1");
            sw.Flush();
        }
        [TestInitialize]
        public void test_test_con_Initialize()
        {
            //if (controller == null)
            //{
            //    controller = new Controllers.testController();
            //}
            sw.WriteLine("这是TestInitialize");
            sw.Flush();
        }
        [TestCleanup]
        public void test_test_con_cleanup()
        {
            //this.result = null;
            sw.WriteLine("这是TestCleanup");
            sw.Flush();
        } 
       
        [TestProperty(name: "name", value: "val")]
        public void testOther()
        {
            Type t = GetType();
            MethodInfo mi = t.GetMethod("MyTestMethod");
            Type MyType = typeof(TestPropertyAttribute);
            object[] attributes = mi.GetCustomAttributes(MyType, false);
            sw.WriteLine(t.Name);
            sw.Flush();
            for (int i = 0; i < attributes.Length; i++)
            {
                string name = ((TestPropertyAttribute)attributes[i]).Name;
                string val = ((TestPropertyAttribute)attributes[i]).Value;
                sw.WriteLine(string.Format("Property Name: {0}, Value: {1} type", name, val));
                sw.Flush();
            } 
        }
        [TestMethod]
        public void test_test_con()
        {
            //this.result = this.controller.apimethod();
            //Assert.IsNotNull(result);
            //Assert.AreEqual("test", result.username, "声明成功");
            //Assert.AreNotEqual("women", result.sex);
            sw.WriteLine("这是TestMethod");
            sw.Flush();
        }
        [TestMethod]
        public void test2()
        {
            sw.WriteLine("这是TestMethod2");
            sw.Flush();
        }
    }
}

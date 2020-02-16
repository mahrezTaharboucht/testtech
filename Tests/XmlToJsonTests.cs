
namespace Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Services;

    [TestClass]
    public class XmlToJsonTests
    {

        private const string SIMPLEWELLFORMEDXML = "<foo>bar</foo>";
        private const string SIMPLEWELLFORMEDXMLJSONRESULT = "{\"foo\":\"bar\"}";

        private const string SIMPLEBADXMLFORMAT = "<foo>hello</bar>";
        private const string SIMPLEBADXMLFORMATRESULT = "Bad Xml format";

        private const string WELLFORMEDXML = "<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>";
        private const string WELLFORMEDXMLJSONRESULT = "{\"TRANS\":{\"HPAY\":{\"ID\":\"103\",\"STATUS\":\"3\",\"EXTRA\":{\"IS3DS\":\"0\",\"AUTH\":\"031183\"},\"MLABEL\":\"501767XXXXXX6700\",\"MTOKEN\":\"project01\"}}}";


        [TestMethod]
        public void SimpleWellFormedXml()
        {            
            Assert.AreEqual(SIMPLEWELLFORMEDXMLJSONRESULT, XmlToJsonService.GetJson(SIMPLEWELLFORMEDXML));
        }

        [TestMethod]
        public void SimpleBadXmlFormat()
        {
            Assert.AreEqual(SIMPLEBADXMLFORMATRESULT, XmlToJsonService.GetJson(SIMPLEBADXMLFORMAT));
        }

        [TestMethod]
        public void WellFormedXml()
        {
            Assert.AreEqual(WELLFORMEDXMLJSONRESULT.Replace(" ", ""), XmlToJsonService.GetJson(WELLFORMEDXML).Replace(" ", ""));
        }
    }
}

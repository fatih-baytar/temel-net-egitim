namespace BirimTestleri.Test
{
    [TestClass]
    public class DortIslemSinifiTesti
    {
        [TestMethod]
        public void Topla_Metodu_Iki_Sayiyi_Toplar()
        {
            DortIslem dortIslem = new DortIslem();
            var sonuc = dortIslem.Topla(3, 5);
            var olmasiGereken = 8;
            Assert.AreEqual(olmasiGereken, sonuc);
        }
    }
}
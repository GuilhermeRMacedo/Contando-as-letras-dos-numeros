using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Contando_as_letras_dos_números
{
    [TestClass]
    public class contandoAsLetrasDosNúmeros
    {

        [TestMethod]
        public void fazendo1da2()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(1,1);
            //D
            Assert.AreEqual(2, resposta);
        }

        [TestMethod]
        public void fazendo2da4()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(2,2);
            //D
            Assert.AreEqual(4, resposta);
        }

        [TestMethod]
        public void fazendo4da6()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(4,4);
            //D
            Assert.AreEqual(6, resposta);
        }

        [TestMethod]
        public void fazendo5da5()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(5,5);
            //D
            Assert.AreEqual(5, resposta);
        }

        [TestMethod]
        public void fazendo9da4()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(9, 9);
            //D
            Assert.AreEqual(4, resposta);
        }

        [TestMethod]
        public void fazendoDe1a2da6()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(1,2);
            //D
            Assert.AreEqual(6, resposta);
        }

        [TestMethod]
        public void fazendoDe1a5da21()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(1, 5);
            //D
            Assert.AreEqual(21, resposta);
        }

        [TestMethod]
        public void fazendoDe1a9da37()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(1, 9);
            //D
            Assert.AreEqual(37, resposta);
        }


        [TestMethod]
        public void fazendoDe9a10da7()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(9, 10);
            //D
            Assert.AreEqual(7, resposta);
        }

        [TestMethod]
        public void fazendoDe1a11da44()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(1, 11);
            //D
            Assert.AreEqual(44, resposta);
        }

        [TestMethod]
        public void fazendoDe19a20da13()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(19, 20);
            //D
            Assert.AreEqual(13, resposta);
        }

        [TestMethod]
        public void fazendoDe20a21da13()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(20, 21);
            //D
            Assert.AreEqual(13, resposta);
        }

        [TestMethod]
        public void fazendo20da5()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(20, 20);
            //D
            Assert.AreEqual(5, resposta);
        }

        [TestMethod]
        public void fazendo98a99da24()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(98, 99);
            //D
            Assert.AreEqual(24, resposta);
        }

        [TestMethod]
        public void fazendo1a99damuito()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(1, 99);
            //D
            Assert.AreEqual(1036, resposta);
        }

        [TestMethod]
        public void fazendo100da3()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(100, 100);
            //D
            Assert.AreEqual(3, resposta);
        }

        [TestMethod]
        public void fazendo101da8()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(101, 101);
            //D
            Assert.AreEqual(8, resposta);
        }

        [TestMethod]
        public void fazendo102da10()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(102, 102);
            //D
            Assert.AreEqual(10, resposta);
        }

        [TestMethod]
        public void fazendo101a102da18()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(101, 102);
            //D
            Assert.AreEqual(18, resposta);
        }

        [TestMethod]
        public void fazendo110da9()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(110, 110);
            //D
            Assert.AreEqual(9, resposta);
        }

        [TestMethod]
        public void fazendo111da10()   
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(111, 111);
            //D
            Assert.AreEqual(10, resposta);
        }

        [TestMethod]
        public void fazendo200da8()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(200, 200);
            //D
            Assert.AreEqual(8, resposta);
        }

        [TestMethod]
        public void fazendo121da14()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(121, 121);
            //D
            Assert.AreEqual(14, resposta);
        }

        [TestMethod]
        public void fazendo120da11()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(120, 120);
            //D
            Assert.AreEqual(11, resposta);
        }

        [TestMethod]
        public void fazendo210da12()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(210, 210);
            //D
            Assert.AreEqual(12, resposta);
        }

        [TestMethod]
        public void fazendo100a102da21()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(100, 102);
            //D
            Assert.AreEqual(21, resposta);
        }

        [TestMethod]
        public void fazendo998a1000da49()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(998, 1000);
            //D
            Assert.AreEqual(49, resposta);
        }

        [TestMethod]
        public void fazendo1a1000daMuitoMesmo19652()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(1, 1000);
            //D
            Assert.AreEqual(19652, resposta);
        }

        [TestMethod]
        public void fazendo1a999daUmBucado1919649()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(1, 999);
            //D
            Assert.AreEqual(19649, resposta);
        }

        [TestMethod]
        public void fazendo0da4()
        {
            //T
            Cont contador = new Cont();
            //D
            int resposta = contador.contar(0, 0);
            //D
            Assert.AreEqual(4, resposta);
        }

    }
}

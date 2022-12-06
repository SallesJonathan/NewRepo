using AppModelo.Model.Infra.Repositories;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificarRepositorioNaturalidade()
        {
            var repositorio = new NaturalidadeRepository();
            var repo = repositorio.Inserir("nome",true);

            Assert.IsTrue(repo);
        }
    }
}
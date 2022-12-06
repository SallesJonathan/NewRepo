using AppModelo.Controller.Cadastros;

namespace AppModeloTestes
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var _controller = new FuncionarioController();
            var controls = _controller.Cadastrar();

            Assert.True(controls);
        }
    }
}
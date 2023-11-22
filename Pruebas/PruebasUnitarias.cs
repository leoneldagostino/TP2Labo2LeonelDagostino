using Entidades.Excepciones;
using Entidades.Modelos;
using Entidades.Repositorio;

namespace Pruebas
{
    [TestClass]
    public class PruebasUnitarias
    {
        [TestMethod]
        public void BuscarPorDniHuesped_SeEncuentra_DevuelveHuespedEncontrado()
        {
            //ARRANGE
            int dni = 123455;
            HuespedRepostory repoHuesped = new HuespedRepostory();

            //ACT
            Huesped huespedEncontrado = repoHuesped.BuscarPorDniHuesped(dni);

            //ASSERT
            Assert.AreEqual(dni, huespedEncontrado.Dni);
        }
        [TestMethod]
        [ExpectedException(typeof(ElementoNoEncontradoException))]
        [DataRow (1)]
        public void BuscarPorDniHuesped_NoSeEncuentra_DevuelveExcepcion(int dniIngresado)
        {
            //ARRANGE
            int dni; 
            HuespedRepostory repoHuesped = new HuespedRepostory();

            //ACT
            
            Huesped huespedNoEncontrado = repoHuesped.BuscarPorDniHuesped(dniIngresado);

            //ASSERT
     
        }

        [TestMethod]
        [DataRow ("7libertadores", "123456")]
        public void ValidarUsuarioContraseña_Existoso_IngresaAlSistema(string usuarioIngresado,string contraseñaIngresada)
        {
            //ARRANGE
            EmpleadoRepository empleadoRepo = new EmpleadoRepository();

            //ACT
            bool ingreso = empleadoRepo.validarUsuarioContraseña(usuarioIngresado, contraseñaIngresada);

            //ASSERT
            Assert.IsTrue(ingreso);

        }
    }
}
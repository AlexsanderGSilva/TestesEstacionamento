using Etec.Estacionamento.Modelos;

namespace Etec.Estacionamento.Teste
{
    public class VeiculoTeste
    {
        [Fact(DisplayName = "Valida Faturamento do Estacionamento")]
        [Trait("Funcionalidade", "Acelerar")]
        public void AcelerarTeste()
        {
            //Arrange
            Veiculo veiculo = new Veiculo();

            //Act
            veiculo.Acelerar(10);

            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact(Skip = "Teste ainda não implementado!")]
        public void FreiarTeste() 
        {
            Veiculo veiculo = new Veiculo();

            veiculo.Frear(5);

            Assert.Equal(-75, veiculo.VelocidadeAtual);
        }


    }
}
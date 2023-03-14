using bytebank.Modelos.ADM.Funcionarios;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using ByteBank_GeradorChavePix;
using Microsoft.VisualBasic;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
new ByteBankAtendimento().AtendimentoCliente(); 

Console.WriteLine(GeradorPix.GetChavePix());

var listaDeChavesPix = GeradorPix.GetChavePix(10);
foreach(var chaves in listaDeChavesPix)
{
    Console.WriteLine(chaves);
}

//public class Estagiario : Funcionario
//{
//    public Estagiario(double salario, string cpf) : base(salario, cpf)
//    {
//    }

//    public override void AumentarSalario()
//    {
//        // implementação;
//    }

//    protected override double getBonificacao()
//    {
//        // implementação;
//        return 0;
//    }
//}

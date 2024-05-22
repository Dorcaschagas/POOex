 
using System;
namespace aulaex{
    public class Program{
       public static void Main()
        {
            // Criando uma lista de funcionários
            List<Funcionario> funcionarios = new List<Funcionario>();

            // Adicionando funcionários à lista
            funcionarios.Add(new Funcionario("Dorcas", "123 456 789 10", "30/10/95", true, "MAT12345"));
            funcionarios.Add(new Funcionario("João", "987 654 321 00", "15/05/90", false, "MAT54321"));
            funcionarios.Add(new Funcionario("Maria", "111 222 333 44", "22/08/88", true, "MAT67890"));

            // Iterando sobre a lista de funcionários e imprimindo os detalhes
            foreach (var funcionario in funcionarios)
            {
                funcionario.Informacoes();
            }
        }
    }
}  
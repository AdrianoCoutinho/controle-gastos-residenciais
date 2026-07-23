namespace ControleGastosResidenciais.Models;

public class Pessoa
{
    //sets privados para não permitir alteração direta dos valores
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public int Idade { get; private set; }
    public Pessoa(string nome, int idade)
    {
        Id = Guid.NewGuid(); //criacao de ID unico pelo Guid para não haver duplicidade
        Nome = nome;
        Idade = idade;
    }


    //Create fora de constutor para criar pessoas com ID ja existentes e fazer listagem de pessoas que ja existem.
    public static Pessoa Create(Guid id, string nome, int idade)
    {
        return new Pessoa(nome, idade) { Id = id };
    }

    public bool EhMenorDeIdade() => Idade < 18;
    //metodo de verificar idade aqui, para que nao seja preciso ficar repetindo condicao em todo o codigo.
    //alteracoes futuras de idade podem ser feitas aqui, sem precisar alterar em todos os lugares que a idade é verificada.
}

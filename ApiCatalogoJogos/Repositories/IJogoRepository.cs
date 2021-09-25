using ApiCatalogoJogos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Repositories
{
    public interface IJogoRepository : IDisposable
    {
        // repositório lida com entidades
        Task<List<Jogo>> Obter(int pagina, int quantidade); // aqui terá paginação para não precisar requisitar todos os jogos de uma vez, caso contenham muitos na base de dados
        Task<Jogo> Obter(Guid id);
        Task<List<Jogo>> Obter(string nome, string produtora);
        Task Inserir(Jogo jogo);
        Task Atualizar(Jogo jogo);
        Task Remover(Guid id);
    }
}

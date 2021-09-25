using ApiCatalogoJogos.InputModel;
using ApiCatalogoJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Services
{
    // as services servem para determinar o que será utilizado
    public interface IJogoService : IDisposable // herdando de IDisposable, temos a capacidade de controlar a destruição do objeto, podendo assim fechar as conexões de repositório após a destruição
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade); // aqui terá paginação para não precisar requisitar todos os jogos de uma vez, caso contenham muitos na base de dados
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}

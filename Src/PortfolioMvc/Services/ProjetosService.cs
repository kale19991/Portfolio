using PortfolioMvc.Models;

namespace PortfolioMvc.Services;

public class ProjetosService : IProjetosService
{
    public List<Projeto> GetProjetos()
    {
        return new List<Projeto>() {
                new Projeto
                {
                    Titulo = "KalleCOD",
                    Descricao = "Blog de artigos criado em ASP.NET Core desde 2002 com mais de 5000 artigos",
                    Link = "https://dev.azure.com/kalleartes/KalleCOD",
                    ImagemURL = "https://www.gravatar.com/userimage/213976415/ff686318b8545b09eac6275b9d4ef901?size=120"
                }
            };
    }
}


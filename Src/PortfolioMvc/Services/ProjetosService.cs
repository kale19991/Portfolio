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
                    ImagemURL = "https://2.gravatar.com/userimage/213976415/910135545213da19d387572d6022dc6b?size=600"
                }
            };
    }
}


using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Orthomaster.Web.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CeinturesLombairesController : ControllerBase
    {
        private readonly ILogger<CeinturesLombairesController> _logger;

        public CeinturesLombairesController(ILogger<CeinturesLombairesController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<JsonResult> Search([FromBody] CeintureLombaireQueryDTO ceintureLombaireQueryDTO)
        {
            _logger.LogInformation($"Received : {ceintureLombaireQueryDTO}");
            var result = GetScenario(ceintureLombaireQueryDTO.Compteur);
            return new JsonResult(result);
        }

        private object[] GetScenario(int compteur)
        {
            if (compteur > 1)
            {
                return Scenario2();
            }
            return Scenario1();
        }

        private static object[] Scenario2()
        {
            int cpt = 0;
            return new[] {
                new {
                    Numero = cpt + 1,
                    ImgURL = "https://images-na.ssl-images-amazon.com/images/I/41X4S6E%2BAqL._AC_SX355_.jpg",
                    Nom = "Babystrap",
                    NomFabricant = "Donjoy",
                    Reference = "82-0245",
                    Couleur = "BLANC/VERT"
                },
                new {
                    Numero = cpt + 1,
                    ImgURL = "https://cdn.sport-orthese.com/img/prod/1159/4630/gibaud-lombogib-underwear.jpg?scale.width=800&scale.height=800&canvas.width=800&canvas.height=800",
                    Nom = "Lombogib Maternity",
                    NomFabricant = "Gibaud",
                    Reference = "3322541033482",
                    Couleur = "BLEU / GRIS"
                },
                new {
                    Numero = cpt + 1,
                    ImgURL = "https://www.pharma-gdd.com/images/catalog/pictures/thumbnails/600/thuasne-lombamun.jpg",
                    Nom = "Lombamum",
                    NomFabricant = "Thuasne",
                    Reference = "340109727241",
                    Couleur = "GRIS"
                }
            };
        }
        private static object[] Scenario1()
        {
            int cpt = 0;
            return new[]{
                new {
                    Numero = cpt + 1,
                    ImgURL = "https://images.prismic.io/gibaud/09be86fb4b90dfbdbc4d455df25a7e6cf9a9f92c_lombogib_underware_femme.png?auto=compress,format",
                    Nom = "Lombogib double action",
                    NomFabricant = "Gibaud",
                    Reference = "3322541038043",
                    Couleur = "BLEU"
                    },
                    new {
                    Numero = cpt + 1,
                    ImgURL = "https://images-na.ssl-images-amazon.com/images/I/711BYbBtCML._AC_SX569_.jpg",
                    Nom = "Immostrap",
                    NomFabricant = "Donjoy",
                    Reference = "82-0232-1",
                    Couleur = "NOIR"
                    },
                    new {
                    Numero = cpt + 1,
                    ImgURL = "https://images-na.ssl-images-amazon.com/images/I/81wx2GcXn3L._AC_SX425_.jpg",
                    Nom = "Porostrap",
                    NomFabricant = "Donjoy",
                    Reference = "82-0227-1",
                    Couleur = "NOIR"
                    },
                    new {
                    Numero = cpt + 1,
                    ImgURL = "https://sodimmed-dz.com/wp-content/uploads/2020/11/CEINTURE_LOMBOGIB_EVOLUTION_GIBAUD1-02-01.png",
                    Nom = "Lombogib évolution",
                    NomFabricant = "Gibaud",
                    Reference = "3322541035486",
                    Couleur = "NOIR / BLEU"
                    }
            };
        }
    }
}

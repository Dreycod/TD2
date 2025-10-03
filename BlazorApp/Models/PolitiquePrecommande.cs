namespace BlazorApp.Models
{
    public class PolitiquePrecommande: IPolitiqueDisponibilite
    {
        public DisponibiliteResult CalculerDisponibilite(Produit produit)
        {
            if (produit.StockReel < produit.StockMin)
                return DisponibiliteResult.Precommandable;
            else // if (produit.StockReel > produit.StockMax)
                return DisponibiliteResult.Disponible;
        }
    }
}

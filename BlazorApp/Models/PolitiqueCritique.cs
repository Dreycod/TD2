namespace BlazorApp.Models
{
    public class PolitiqueCritique: IPolitiqueDisponibilite
    {
        public DisponibiliteResult CalculerDisponibilite(Produit produit)
        {
            if (produit.StockReel.HasValue && produit.StockReel.Value < produit.StockMin)
            {
                return DisponibiliteResult.Indisponible;
            }
            else if (produit.StockReel.HasValue && produit.StockReel.Value > produit.StockMax)
            {
                return DisponibiliteResult.Bloque;
            }
            else
            {
                return DisponibiliteResult.Disponible;
            }
        }
    }
}

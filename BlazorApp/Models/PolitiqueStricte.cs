namespace BlazorApp.Models;

public class PolitiqueStricte: IPolitiqueDisponibilite
{
    public DisponibiliteResult CalculerDisponibilite(Produit produit)
    {
        if (produit.StockReel.HasValue && produit.StockReel.Value < produit.StockMax && produit.StockReel.Value > produit.StockMin)
        {
            return DisponibiliteResult.Disponible;
        }
        else
        {
            return DisponibiliteResult.Indisponible;
        }
    }
}

namespace BlazorApp.Models;

public interface IPolitiqueDisponibilite
{
    DisponibiliteResult CalculerDisponibilite(Produit produit);
}

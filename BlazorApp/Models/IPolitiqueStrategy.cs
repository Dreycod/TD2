namespace BlazorApp.Models;

public interface IPolitiqueStrategy
{
    DisponibiliteResult CalculerDisponibilite(Produit produit);
}

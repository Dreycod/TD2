namespace BlazorApp.Models;

public class PolitiqueContext
{
    private IPolitiqueStrategy _strategy;

    public PolitiqueContext()
    { }

    // Usually, the Context accepts a strategy through the constructor, but
    // also provides a setter to change it at runtime.
    public PolitiqueContext(IPolitiqueStrategy strategy)
    {
        this._strategy = strategy;
    }

    // Usually, the Context allows replacing a Strategy object at runtime.
    public void SetStrategy(IPolitiqueStrategy strategy)
    {
        this._strategy = strategy;
    }

    // The Context delegates some work to the Strategy object instead of
    // implementing multiple versions of the algorithm on its own.
    public void Execute(Produit _produit)
    {
        if (this._strategy == null)
        {
            throw new InvalidOperationException("Strategy not set");
        }
        this._strategy.CalculerDisponibilite(_produit);
    }
}

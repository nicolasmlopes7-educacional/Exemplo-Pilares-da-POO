namespace Heranca
{
    public class PagamentoPix : IPagamento
    {
        public void Pagar(decimal valor)
        {
            Console.WriteLine($"Pagamento via Pix: {valor:C}.");
        }
    }
}
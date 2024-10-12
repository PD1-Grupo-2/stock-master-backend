namespace StockMaster.Domain.Enums;

public enum MovementReason
{
    Sale,       // Venda de produtos
    Loss,       // Perda de estoque (danificado, expirado, etc.)
    Restock,    // Reposi��o de estoque
    Adjustment  // Ajuste manual (erros, corre��es, etc.)
}

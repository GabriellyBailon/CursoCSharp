namespace Exemplo001_Enum.Entidades.Enums
{
    //Pasta dos Enums
    //Enum: OrderStatus
    //O tipo é enum e seus itens são do tipo int
    enum OrderStatus : int
    {
        //Aqui, associamos cada tipo de pedido a um valor
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}

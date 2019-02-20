namespace A122_Exercicio_Enum_Associacao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public double SubTotal()
        {
            return Quantity * Price;
        }

       public override string ToString()
        {
            return Product.Name + ", "
                + Price + ", Quantity: " + Quantity 
                + ", Subtotal: " + SubTotal().ToString();
        }
    }
}

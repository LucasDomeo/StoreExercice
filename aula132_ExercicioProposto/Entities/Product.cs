namespace aula132_ExercicioProposto.Entities
{
    class Product
    {
        //Variables
        public string PName { get; set; }
        public double PPrice { get; set; }

        //Constructors
        public Product()
        {
        }
        public Product(string pName, double pPrice)
        {
            PName = pName;
            PPrice = pPrice;
        }
    }
}

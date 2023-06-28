using System.Text;

namespace aula132_ExercicioProposto.Entities
{
    class Client
    {
        //Variables
        public string Identify { get; set; }
        public string Name { get; set; }

        //Constructors
        public Client() 
        {
        }
        public Client(string identify, string name) 
        {
            Identify = identify;
            Name = name;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Identify: ");
            stringBuilder.Append(Identify);
            stringBuilder.Append("  ");
            stringBuilder.Append("Name: ");
            stringBuilder.Append(Name);
            return stringBuilder.ToString();
        }
    }
}

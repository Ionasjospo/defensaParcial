namespace Ucu.Poo.Defense
{
    public class Material
    {
        public string Name { get; set; }

        public MaterialType Type { get; set; }

        
        private bool isDangerous()
        {
            if (this.Type.IsDangerous)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsDangerous { get {return this.isDangerous();}  } 

        public Material(string name, MaterialType type)
        {
            this.Name = name;
            this.Type = type;
        }

        
    }
}
using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Publication : PublicationItem
    {
        public DateTime EndDate { get; set; }
        public string mostrarTexto;
        

        public IReadOnlyCollection<PublicationItem> Items
        {
            get
            {
                return new ReadOnlyCollection<PublicationItem>(this.items);
            }
        }

        private IList<PublicationItem> items = new List<PublicationItem>();

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(PublicationItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(PublicationItem item)
        {
            this.items.Remove(item);
        }

        public string AsText()
        {
            foreach (PublicationItem item in items)
            {
                string mostrarTexto = $"Fecha: {this.EndDate}\n{this.Quantity} de {Material.Name} a {this.Price}\n";
            }
            

            return mostrarTexto;
        }
     }
}
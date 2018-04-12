using System.Collections.Generic;

namespace Vega.Models
{
    public class Make
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Model> Models { get; set; }
    }
}
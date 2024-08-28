using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PatikaWeek7PratikPatikaflix
{
    public class Comedy
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public string Director { get; set; }

        public Comedy(string title, string type, string director)
        {
            Title = title;
            Type = type;
            Director = director;
        }

        public override string ToString()
        {
            return $"Dizi Adı: {Title}, Dizi Türü: {Type}, Yönetmen : {Director}";
        }
    }
}

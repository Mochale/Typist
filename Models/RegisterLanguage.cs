using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typist.App.Models
{
    public class RegisterLanguage
    {
        public List<Language> Languages { get; set;}
    }

    public class Language
    {
        public string Name { get; set; }
        public string Directory { get; set; }
    }
}

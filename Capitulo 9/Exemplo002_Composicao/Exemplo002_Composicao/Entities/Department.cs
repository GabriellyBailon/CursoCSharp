using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo002_Composicao.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department()
        {

        }

        public Department(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}

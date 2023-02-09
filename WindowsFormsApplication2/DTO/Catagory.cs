using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.DTO
{
    public class Catagory
    {
        public Catagory(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.DTO
{
    public class Food
    {
        //public Food(int id, string name, int idCatagory, float price)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //    this.IdCatagory = idCatagory;
        //    this.Price = price;
        //}
        public Food(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IdCatagory = (int)row["idCategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());

        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private int idCatagory;

        public int IdCatagory
        {
            get { return idCatagory; }
            set { idCatagory = value; }
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

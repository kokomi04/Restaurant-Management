using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2.DTO
{
    public class Table
    {
        //public Table (int id, string name, string statustable)
        //{
        //    this.ID = id;
        //    this.Name = name;
        //    this.StatusTable = statustable;
        //}

        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.StatusTable = row["StatusFood"].ToString();
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string statusTable;

        public string StatusTable
        {
            get { return statusTable; }
            set { statusTable = value; }
        }
    }
}

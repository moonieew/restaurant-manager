using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyQuanAn
{
    public class Material
    {
        public Material(int id, string name, double soluong)
        {
            this.ID = id;
            this.Name = name;
            this.Soluong = soluong;
        }
        public Material(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Soluong = (double)row["soluong"];
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private double soluong;
        public double Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
    }
}

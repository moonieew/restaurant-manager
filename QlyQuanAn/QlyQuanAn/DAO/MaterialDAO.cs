using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyQuanAn
{
    public class MaterialDAO
    {
        private static MaterialDAO instance;

        public static MaterialDAO Instance
        {
            get { if (instance == null) instance = new MaterialDAO(); return MaterialDAO.instance; }
            private set { MaterialDAO.instance = value; }
        }

        private MaterialDAO() { }
        public List<Material> GetListMaterial()
        {
            List<Material> list = new List<Material>();

            string query = "select * from Material";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Material material = new Material(item);
                list.Add(material);
            }

            return list;
        }
        public bool InsertMaterial(string name, double soluong)
        {
            string query = string.Format("INSERT dbo.Material ( name, soluong )VALUES  ( N'{0}', {1})", name, soluong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateMaterial(int idMaterial, string name, double soluong)
        {
            string query = string.Format("UPDATE dbo.Material SET name = N'{0}', soluong = {1} WHERE id = {3}", name, soluong, idMaterial);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteMaterial(int idMaterial)
        {

            string query = string.Format("Delete Material where id = {0}", idMaterial);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}

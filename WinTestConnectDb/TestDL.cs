using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTestConnectDb
{
    class TestDL : DataWorker 
    {
        public List<TestBE> LoadData()
        {
            try
            {
                List<TestBE> res = new List<TestBE>();

                using (DbConnection connection = database.CreateOpenConnection())
                {
                    using (DbCommand command = database.CreateCommand("SELECT * FROM test", connection))
                    {
                        using (IDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Console.WriteLine(reader["DES_PERFIL"]);
                                TestBE pcBe = new TestBE();
                                pcBe.IdTabla = Convert.ToInt32(reader["idTabla"]);
                                pcBe.NomArticulo = Convert.ToString(reader["nomArticulo"]);
                                res.Add(pcBe);
                            }
                        }
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            
        }
    }
}

using DAL_Manegement;
using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Manegement
{
    public class BUS_Producer
    {
        private static DAL_Producer producer = new DAL_Producer();
        public DataTable getAllData()
        {
            return producer.getAll();
        }
        public bool AddProducer(DTO_Producer p)
        {
            return producer.addProducer(p);
        }
        public bool updateProducer(DTO_Producer p)
        {
            return producer.updateProducer(p);
        }
        public bool deleteProducer(int id)
        {
            return producer.deleteProducerById(id);
        }
        public bool CheckDuplicateProducer(string code, string name)
        {
            return producer.checkDuplicateProducer(code, name);
        }
        public DataTable FindByNameProducer(string name)
        {
            return producer.findByNameProducer(name);
        }
        public DataTable FindByCodeProducer(string code)
        {
            return producer.findByCodeProducer(code);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Manegement
{
    public class DTO_Producer
    {
        private int id;
        private string code;
        private string nameProducer;

        public DTO_Producer(int id, string code, string nameProducer)
        {
            this.id = id;
            this.code = code;
            this.nameProducer = nameProducer;
        }
        public DTO_Producer() { }
        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getCode()
        {
            return code;
        }

        public void getCode(String code)
        {
            this.code = code;
        }

        public String getNameProducer()
        {
            return nameProducer;
        }

        public void setNameProducer(String nameProducer)
        {
            this.nameProducer = nameProducer;
        }

    }
}

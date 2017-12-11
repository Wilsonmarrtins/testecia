using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteSeusConhecimentos.Entities
{
    public class Enterprise
    {
        public virtual int IdEnterprice { get; set; }
        public virtual string StreetAdress { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string ZipCode { get; set; }
        public virtual string CorporateActivity { get; set; }

        public Enterprise()
        {
    
        }

        public Enterprise(int IdEnterprice, string StreetAdress, string City, string State, string ZipCode, string CorporateActivity)
        {
            this.IdEnterprice = IdEnterprice;
            this.StreetAdress = StreetAdress;
            this.City = City;
            this.State = State;
            this.State = ZipCode;
            this.State = CorporateActivity;
        }

        public virtual bool IsNew()
        {
            return this.IdEnterprice == 0;
        }

    }
}

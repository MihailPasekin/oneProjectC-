using ScExpertDbLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScExpertDbLib
{
    public class ScExpertDbWorker
    {
        public string UpdateOrderStatus(int docEntry)
        {
            string result = string.Empty;

            using (ScexpertContext db = new ScexpertContext())
            {
                var order = db.Outboundorheaders.Where(p => p.Referenceord == docEntry.ToString()).FirstOrDefault();

                if (order != null)
                {
                    if (order.Status != "CANCELED")
                    {
                        order.Status = "CANCELED";
                        db.SaveChanges();
                    }
                }
            }

            return result;
        }
    }
}

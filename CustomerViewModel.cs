using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
 

namespace WindowsFormsApp1
{
    public  class CustomerViewModel : IDisposable
    {
        private QRSHEntities db;
        public CustomerViewModel() => db = new QRSHEntities();

        // using a binding Source control to interact data between a View and a modle 

        public BindingSource  CustomerBindingSource { get; set; }

        public void load()
        {

            db.customers.Load();
            CustomerBindingSource.DataSource = db.customers.Local.ToBindingList();
          }
        public void Delete() => CustomerBindingSource.RemoveCurrent();
        public void New() => CustomerBindingSource.AddNew();
        
        public void Save()
        {
            CustomerBindingSource.EndEdit();
            db.SaveChanges();
        }
        public void  Dispose()
        {
            db.Dispose();
        }
    } 
}
 
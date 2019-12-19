using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tolotu_Desktop.Controllers
{
    class addEventController
    {
        public void addEvent(int idEvento, int IdUsu)
        {
            Models.Servicios.DBServicio DB = new Models.Servicios.DBServicio();
            if (DB.regAct(IdUsu, idEvento))
            {
                MessageBox.Show("Has añadido una nueva actividad");
            }
            else
            {
                MessageBox.Show("no se ha podido realizar el registro");
            }
        }
    }
}

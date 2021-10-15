using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt
{
    class Utils
    {
        //Abre un formulario en el Panel "panelFormularioHijo" del Form "frmPrincipal"
        public void setFormToPanelFormularioHijo(Form form)
        {
            try
            {
                Form objFrmPrincipal = Application.OpenForms["frmPrincipal"];

                if (objFrmPrincipal != null)
                {
                    Label objlblFormOpen = (Label)objFrmPrincipal.Controls.Find("lblFormOpen", true).SingleOrDefault();
                    Form frmOpen = Application.OpenForms[objlblFormOpen.Text];

                    if (frmOpen != null)
                    {
                        frmOpen.Close();
                    }

                    Panel objPanelFormularioHijo = (Panel)objFrmPrincipal.Controls.Find("panelFormularioHijo", true).SingleOrDefault();
                    Form formularioHijo = form;
                    formularioHijo.TopLevel = false;
                    formularioHijo.FormBorderStyle = FormBorderStyle.None;
                    formularioHijo.Dock = DockStyle.Fill;
                    objPanelFormularioHijo.Controls.Add(formularioHijo);
                    objPanelFormularioHijo.Tag = formularioHijo;
                    formularioHijo.BringToFront();
                    formularioHijo.Show();
                }
            }
            catch (Exception)
            {
            }
        }

        //Cierra el formulario que posee como nombre el valor de "nombreForm", si este se encuentra abierto
        public void closeOpenFormPanelFormularioHijo(string nombreForm)
        {
            try
            {
                Form formOpen = Application.OpenForms[nombreForm];
                if (formOpen != null)
                {
                    formOpen.Close();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

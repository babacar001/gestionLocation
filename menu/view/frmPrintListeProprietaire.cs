using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Notice.Warning.Types;
using menu.Model;
using gestion_location.Model;
using CrystalDecisions.Windows.Forms;
using menu.Report;

namespace menu.view
{
    public partial class frmPrintListeProprietaire : Form
    {
        public frmPrintListeProprietaire()
        {
            InitializeComponent();
        }
        BdAppartementContext db = new BdAppartementContext();

        private void frmPrintListeProprietaire_Load(object sender, EventArgs e)
        {
            rptListeProprietaire objRept = new rptListeProprietaire();
            objRept.SetDataSource(GetTableProprietaire());
            crystalReportViewer1.ReportSource = objRept;
            crystalReportViewer1.Refresh();

        }

        public DataTable GetTableProprietaire()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Ninea", typeof(string));
            table.Columns.Add("Rccm", typeof(string));
            table.Columns.Add("NomPrenom", typeof(string));
            table.Columns.Add("Telephone", typeof(string));
            table.Columns.Add("Email", typeof(string));
            var App = db.proprietaires.ToList();
            foreach (var i in App)
            {
                table.Rows.Add(i.Ninea, i.Rccm, i.NomPrenom, i.Email);            
            }

            return table;
        }

        private void frmPrintListeProprietaire_FormClosed(object sender, EventArgs e)
        {
           frmProprietaire f = new frmProprietaire();
           f.Activer();

        }


    }
}



      
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Main.fillCombo(cmb_Importer, "ImporterDetails", "ImporterName", "ImporterID", "ImporterActive = 1");
            Main.fillCombo(cmb_VehicleType, "VehicleDetails", "VehicleName", "VehicleID", "VehicleActive = 1");
            Main.fillCombo(cmb_CarMaker, "CarMakerDetails", "CarMakerName", "CarMakerID", "CarMakerACtive = 1");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert data into sql
            SQL.NonScalarQuery("Insert Into Details (ImporterID                        ,VehicleID                            ,ChassisNo                   ,CarMakerID               ,Specification,EngineNumber      ,Model                             ,Color                  ,CountryOfExport                   ,InspectionDate                                      ,YearOfManufacture                            ,MonthOfManufacture ) " +
                "                             values(" + cmb_Importer.SelectedValue + "," + cmb_VehicleType.SelectedValue + ",'" + txt_ChassisNo.Text + "'," + cmb_CarMaker.Text + ",'" + txt_Specification.Text + "'," + int.Parse(txt_Model.Text) + ",'" + cmb_Color.Text + "','" + txt_CountryOfExport.Text + "'," + dtp_InspectionDate.Value.ToShortDateString() + "," + int.Parse(cmb_YearOfManufacture.Text) + ",'" + cmb_MonthOfManufacture.Text + "')");
        }
    }
}

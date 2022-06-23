using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAutomationSystem
{
    public partial class FrmAnaModulEmployees : Form
    {
        public FrmAnaModulEmployees()
        {
            InitializeComponent();
        }

        // Formları açmak için bir method yapmayı deniyorum Şimdilik geçtim daha sonra dönücem .

        //private void OpenForm2(Form form)
        //{
        //    Form OpenForm = new Form();
        //    OpenForm = ((Form)Activator.CreateInstance(form)).MdiParent = this;
        //    OpenForm.Show();
        //}

        // bunda birtane açıyor bidaha açmıyor formu 
        //void OpenForm(Form form)
        //{
        //    try
        //    {
        //        form.MdiParent = this;
        //        form.Show();
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        // Burda istediğim oldu Formları bu methodu çağırarak açıcam 
        void OpenForm(Form form)
        {
            try
            {
                //form = new Form();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception)
            {

            }
        }
        //private FrmCustomers customers = new FrmCustomers();

        //private FrmStocks stocks = new FrmStocks();

        //private FrmEmployees employees = new FrmEmployees();

        //private FrmWareHouses wareHouses = new FrmWareHouses();

        //private FrmSuppliers suppliers = new FrmSuppliers();

        //private FrmShippers shippers = new FrmShippers();

        //private FrmInvoices invoices = new FrmInvoices();

        //private FrmOrders orders = new FrmOrders();

        //private FrmHomePage homePage = new FrmHomePage();

        //private FrmSafe frmSafe = new FrmSafe();


        private void FrmAnaModulEmployees_Load(object sender, EventArgs e)
        {
            //homePage = new FrmHomePage();
            //homePage.MdiParent = this;
            //homePage.Show();

            OpenForm(new FrmHomePage());
        }

        private FrmEmployeeUserUpdate employeeUserUpdate = new FrmEmployeeUserUpdate();


        // çıkış butonuydu iptal ettim belki ekleyebilirim .
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult Onay = MessageBox.Show("Çıkış Yapmak İstediğinize Emin misiniz?", "Bilgi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Onay == DialogResult.Yes)
            {
                Application.Exit();
            }
        }





        private void FrmAnaModulEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_HomePage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (homePage != null)
            //{
                //homePage = new FrmHomePage();
                //homePage.MdiParent = this;
                //homePage.Show();

                OpenForm(new FrmHomePage());

            //}
        }

        private void btn_Customers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (customers != null)
            //{
                //customers = new FrmCustomers();
                //customers.MdiParent = this;
                //customers.Show();

                OpenForm(new FrmCustomers());

            //}
        }

        private void btn_Products_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //if (stocks != null)
            //{
                //stocks = new FrmStocks();
                //stocks.MdiParent = this;
                //stocks.Show();

                OpenForm(new FrmStocks());
            //}
        }

        private void btn_Employees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (employees != null)
            //{
                //employees = new FrmEmployees();
                //employees.MdiParent = this;
                //employees.Show();

                OpenForm(new FrmEmployees());
           // }

        }

        private void btn_Safe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (frmSafe != null)
            //{
                //frmSafe = new FrmSafe();
                //frmSafe.MdiParent = this;
                //frmSafe.Show();


                OpenForm(new FrmSafe());

            //}
        }

        private void btnOrders_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (orders != null)
            //{
                //orders = new FrmOrders();
                //orders.MdiParent = this;
                //orders.Show();

                OpenForm(new FrmOrders());
            //}
        }

        private void btnSupplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //suppliers = new FrmSuppliers();
            //suppliers.MdiParent = this;
            //suppliers.Show();

            OpenForm(new FrmSuppliers());
        }

        private void btnWareHouse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //if (wareHouses != null)
            //{
                //wareHouses = new FrmWareHouses();
                //wareHouses.MdiParent = this;
                //wareHouses.Show();

                OpenForm(new FrmWareHouses());
            //}
        }

        private void btnShipper_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (shippers != null)
            //{
                //shippers = new FrmShippers();
                //shippers.MdiParent = this;
                //shippers.Show();

                OpenForm(new FrmShippers());
            //}
        }

        private void btn_Invoices_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (invoices != null)
            //{
                //invoices = new FrmInvoices();
                //invoices.MdiParent = this;
                //invoices.Show();

                OpenForm(new FrmInvoices());
            //}
        }

        private void btn_Settings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (employeeUserUpdate != null)
            {
                employeeUserUpdate = new FrmEmployeeUserUpdate();
                employeeUserUpdate.Show();
            }
        }
    }
}

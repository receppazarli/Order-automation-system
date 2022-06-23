using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderAutomationSystem.Entities;

namespace OrderAutomationSystem
{
    public partial class FrmSuppliers : Form
    {
        public FrmSuppliers()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txtTedarikçiAdı.Text = "";
            txtAdres.Text = "";
            txtBanka.Text = "";
            txtIban.Text = "";
            txtTelefon.Text = "";
            lkupİl.EditValue = null;
            lkupİlçe.EditValue = null;
        }

        private SupplierDal _supplierDal = new SupplierDal();
        private void FrmSuppliers_Load(object sender, EventArgs e)
        {
            LoadCity();
            LoadSuppliers2();
            Clear();
        }

        private void LoadSuppliers()
        {
            grcTedarikçiFirmalar.DataSource = _supplierDal.GetAll();
        }

        void LoadSuppliers2()
        {
            using (OrderAutomationSystemContext context=new OrderAutomationSystemContext())
            {
                var entity = from s in context.Suppliers select new
                {
                    TedarikçiId=s.SupplierId,
                    Tedarikçi=s.SupplierName,
                    Banka = s.BankName,
                    Iban = s.Iban,
                    Telefon = s.Phone,
                    İl = s.City,
                    İlçe = s.Country,
                    Adres = s.Address
                };
                grcTedarikçiFirmalar.DataSource = entity.ToList();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _supplierDal.Add(new Supplier
                {
                    SupplierName = txtTedarikçiAdı.Text,
                    BankName = txtBanka.Text,
                    Iban = txtIban.Text,
                    Phone = txtTelefon.Text,
                    City = lkupİl.Text,
                    Country = lkupİlçe.Text,
                    Address = txtAdres.Text
                });
                LoadSuppliers2();
                MessageBox.Show("Tedarikçi sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }


        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _supplierDal.Update(new Supplier
                {
                    SupplierId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TedarikçiId")),
                    SupplierName = txtTedarikçiAdı.Text,
                    BankName = txtBanka.Text,
                    Iban = txtIban.Text,
                    Phone = txtTelefon.Text,
                    City = lkupİl.Text,
                    Country = lkupİlçe.Text,
                    Address = txtAdres.Text
                });
                LoadSuppliers2();
                MessageBox.Show("Tedarikçi bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }




        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                _supplierDal.Delete(new Supplier
                {
                    SupplierId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TedarikçiId"))
                });
                LoadSuppliers2();
                MessageBox.Show("Tedarikçi sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem Hatası Eksik yada Hatalı Giriş", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtTedarikçiAdı.Text = gridView1.GetFocusedRowCellValue("Tedarikçi").ToString();
            txtBanka.Text = gridView1.GetFocusedRowCellValue("Banka").ToString();
            txtIban.Text = gridView1.GetFocusedRowCellValue("Iban").ToString();
            txtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            lkupİl.Text = gridView1.GetFocusedRowCellValue("İl").ToString();
            lkupİlçe.Text = gridView1.GetFocusedRowCellValue("İlçe").ToString();
            txtAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();

        }

        private CityDal _cityDal = new CityDal();
        void LoadCity()
        {
            lkupİl.Properties.DataSource = _cityDal.GetAll();
            lkupİl.Properties.DisplayMember = "CityName";
            lkupİl.Properties.ValueMember = "Id";
        }
        private CountryDal _countryDal = new CountryDal();
        void LoadCountry()
        {
            lkupİlçe.Properties.DataSource = _countryDal.GetAllCountry(Convert.ToInt32(lkupİl.EditValue)).ToList();
            lkupİlçe.Properties.DisplayMember = "CountryName";
            lkupİlçe.Properties.ValueMember = "Id";
        }
        private void lkupİl_EditValueChanged(object sender, EventArgs e)
        {
            LoadCountry();
        }
    }
}

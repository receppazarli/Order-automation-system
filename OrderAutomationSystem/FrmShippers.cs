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
    public partial class FrmShippers : Form
    {
        public FrmShippers()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txtKargoAdı.Text = "";
            txtAdres.Text = "";
            txtBanka.Text = "";
            txtIban.Text = "";
            txtTelefon.Text = "";
            lkupİl.EditValue = null;
            lkupİlçe.EditValue = null;
        }
        private ShipperDal _shipperDal = new ShipperDal();
        private void FrmShippers_Load(object sender, EventArgs e)
        {
            LoadCity();
            LoadShippers2();
            Clear();
        }

        private void LoadShippers()
        {
            grcKargolar.DataSource = _shipperDal.GetAll();
        }

        void LoadShippers2()
        {
            using (OrderAutomationSystemContext context=new OrderAutomationSystemContext())
            {
                var entity = from s in context.Shippers select new
                {
                    KargoId=s.ShipperId,
                    Kargocu=s.ShipperName,
                    Banka = s.BankName,
                    Iban = s.Iban,
                    Telefon = s.Phone,
                    İl = s.City,
                    İlçe = s.Country,
                    Adres = s.Address
                };
                grcKargolar.DataSource = entity.ToList();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _shipperDal.Add(new Shipper
                {
                    ShipperName = txtKargoAdı.Text,
                    BankName = txtBanka.Text,
                    Iban = txtIban.Text,
                    Phone = txtTelefon.Text,
                    City = lkupİl.Text,
                    Country = lkupİlçe.Text,
                    Address = txtAdres.Text
                });
                LoadShippers2();
                MessageBox.Show("Kargo Firması sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _shipperDal.Update(new Shipper
                {
                    ShipperId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KargoId")),
                    ShipperName = txtKargoAdı.Text,
                    BankName = txtBanka.Text,
                    Iban = txtIban.Text,
                    Phone = txtTelefon.Text,
                    City = lkupİl.Text,
                    Country = lkupİlçe.Text,
                    Address = txtAdres.Text
                });
                LoadShippers2();
                MessageBox.Show("Kargo Firması bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _shipperDal.Delete(new Shipper
                {
                    ShipperId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KargoId"))
                });
                LoadShippers2();
                MessageBox.Show("Kargo Firması bilgileri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            txtKargoAdı.Text = gridView1.GetFocusedRowCellValue("Kargocu").ToString();
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

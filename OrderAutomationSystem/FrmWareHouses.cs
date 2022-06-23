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
    public partial class FrmWareHouses : Form
    {
        public FrmWareHouses()
        {
            InitializeComponent();
        }

        private WareHouseDal _wareHouseDal = new WareHouseDal();
        private void FrmWareHouses_Load(object sender, EventArgs e)
        {
            LoadCity();
            LoadWareHouses2();
            Clear();
        }

        private void LoadWareHouses()
        {
            grcDepolar.DataSource = _wareHouseDal.GetAll();
        }

        void LoadWareHouses2()
        {
            using (OrderAutomationSystemContext context=new OrderAutomationSystemContext())
            {
                var entity = from w in context.WareHouses select new
                {
                    DepoId=w.WarehouseId,
                    DepoAdı=w.WarehouseName,
                    Banka=w.BankName,
                    Iban=w.Iban,
                    Telefon=w.Phone,
                    İl=w.City,
                    İlçe=w.Country,
                    Adres=w.Address
                };
                grcDepolar.DataSource = entity.ToList();
            }
        }

        void Clear()
        {
            txtDepoAdı.Text = "";
            txtAdres.Text = "";
            txtBanka.Text = "";
            txtIban.Text = "";
            txtTelefon.Text = "";
            lkupİl.EditValue = null;
            lkupİlçe.EditValue = null;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _wareHouseDal.Add(new WareHouse
                {
                    WarehouseName = txtDepoAdı.Text,
                    BankName = txtBanka.Text,
                    Iban = txtIban.Text,
                    Phone = txtTelefon.Text,
                    City = lkupİl.Text,
                    Country = lkupİlçe.Text,
                    Address = txtAdres.Text
                });
                LoadWareHouses2();
                MessageBox.Show("Depo sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _wareHouseDal.Update(new WareHouse
                {
                    WarehouseId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DepoId")),
                    WarehouseName = txtDepoAdı.Text,
                    BankName = txtBanka.Text,
                    Iban = txtIban.Text,
                    Phone = txtTelefon.Text,
                    City = lkupİl.Text,
                    Country = lkupİlçe.Text,
                    Address = txtAdres.Text
                });
                LoadWareHouses2();
                MessageBox.Show("Depo bilgileri güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _wareHouseDal.Delete(new WareHouse
                {
                    WarehouseId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DepoId"))

                });
                LoadWareHouses2();
                MessageBox.Show("Depo bilgileri silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            txtDepoAdı.Text = gridView1.GetFocusedRowCellValue("DepoAdı").ToString();
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

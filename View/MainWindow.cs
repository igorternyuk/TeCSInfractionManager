using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using model;

namespace View
{
    public partial class MainWindow : Form
    {
        private DataBrand dataBrand;
        private DataVehicleModel dataVehicleModel;
        private DataInfraction dataInfractions;
        private int selectedIdBrand;
        private int selectedIdVehicleModel;
        private int selectedIdInfraction;

        public MainWindow()
        {
            InitializeComponent();
            dataBrand = new DataBrand();
            dataVehicleModel = new DataVehicleModel();
            dataInfractions = new DataInfraction();
            ReloadBrands();
            loadBrandsCombo();
            ReloadVehicleModels();
            ReloadInfractions();
        }

        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            tableInfractions.DataSource = dataInfractions.ReadAll();
        }

        //======================Brands==============================

        private void btnInsertBrand_Click(object sender, EventArgs e)
        {
            Brand b = new Brand(txtBrandName.Text);
            if (dataBrand.Create(b))
            {
                ReloadBrands();
                MessageBox.Show(null, "Brand " + b.Name + " was successfully inserted to the database",
                               "Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, dataBrand.getLastError(),
                               "Failure", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnUpdateBrand_Click(object sender, EventArgs e)
        {
            //selectedIdBrand
            Brand b = new Brand(selectedIdBrand, txtBrandName.Text);
            if (dataBrand.Update(b))
            {
                ReloadBrands();
                MessageBox.Show(null, "Brand with id " + b.Id + " was successfully updated",
                               "Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, dataBrand.getLastError(),
                               "Failure", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnRemoveBrand_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to delete selected brand?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (dataBrand.Delete(selectedIdBrand))
                {
                    ReloadBrands();
                    MessageBox.Show(null, "Brand with id " + selectedIdBrand + " was successfully removed",
                                   "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(null, dataBrand.getLastError(),
                                   "Failure", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }            
        }

        private void btnReloadAllBrands_Click(object sender, EventArgs e)
        {
            ReloadBrands();
        }

        private void btnSearchBrand_Click(object sender, EventArgs e)
        {
            if (txtSearchBrand.Text == "") return;
            var list = dataBrand.Search(txtSearchBrand.Text);
            tableBrands.DataSource = list;
            int count = list.Count;
            switch (count)
            {
                case 0:
                    lblSearchResults.ForeColor = Color.Red;
                    lblSearchResults.Text = "No brands found";
                    break;
                case 1:
                    lblSearchResults.ForeColor = Color.Green;
                    lblSearchResults.Text = "One brand was found";
                    break;
                default:
                    lblSearchResults.ForeColor = Color.Green;
                    lblSearchResults.Text = String.Format("{0} brands were found", count);
                    break;
            }
        }

        private void tableBrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedIdBrand = Convert.ToInt32(tableBrands.CurrentRow.Cells["id"].Value.ToString());
                Brand b = dataBrand.ReadById(selectedIdBrand);
                if (b != null)
                {
                    txtBrandName.Text = b.Name;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //====================Vehicle models=============================

        private void btnInsertModel_Click(object sender, EventArgs e)
        {
            if (checkVehicleFormFilling())
            {
                VehicleModel vm = new VehicleModel();
                vm.Name = txtModelName.Text;
                vm.IdBrand = Convert.ToInt32(cmbModelBrand.SelectedValue);
                if (dataVehicleModel.Create(vm))
                {
                    ReloadVehicleModels();
                    MessageBox.Show(null, "Vehicle model " + vm.Name + " was successfully inserted to the database",
                                   "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(null, dataVehicleModel.getLastError(),
                                   "Failure", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateVehicleModel_Click(object sender, EventArgs e)
        {
            VehicleModel vm = new VehicleModel(selectedIdVehicleModel,
                                               txtModelName.Text,
                                               Convert.ToInt32(cmbModelBrand.SelectedValue));
            if (dataVehicleModel.Update(vm))
            {
                ReloadVehicleModels();
                MessageBox.Show(null, "Vehicle model with id " + vm.Id + " was successfully updated",
                               "Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, dataBrand.getLastError(),
                               "Failure", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnRemoveVehicleModel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to delete selected model?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (dataVehicleModel.Delete(selectedIdVehicleModel))
                {
                    ReloadVehicleModels();
                    clearVehicleModelForm();
                    MessageBox.Show(null, "Vehicle model with id " +
                                    selectedIdVehicleModel +
                                    " was successfully removed",
                                    "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(null, dataVehicleModel.getLastError(),
                                   "Failure", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            } 
        }

        private void btnSearchModel_Click(object sender, EventArgs e)
        {
            if (txtSearchVehicleModel.Text == "") return;
            DataTable dt = dataVehicleModel.SearchByNameFormatted(txtSearchVehicleModel.Text);
            tableVehicleModels.DataSource = dt.DefaultView;
            int count = dt.Rows.Count;
            switch (count)
            {
                case 0:
                    lblVehicleModelSearchResults.ForeColor = Color.Red;
                    lblVehicleModelSearchResults.Text = "No models found";
                    break;
                case 1:
                    lblVehicleModelSearchResults.ForeColor = Color.Green;
                    lblVehicleModelSearchResults.Text = "One model was found";
                    break;
                default:
                    lblVehicleModelSearchResults.ForeColor = Color.Green;
                    lblVehicleModelSearchResults.Text = String.Format("{0} models were found", count);
                    break;
            }
        }

        private void btnLoadVehicleModelFullList_Click(object sender, EventArgs e)
        {
            ReloadVehicleModels();
        }

        private void tableVehicleModels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableVehicleModels.CurrentRow.Index == tableVehicleModels.Rows.Count) return;
            try
            {
                selectedIdVehicleModel = Convert.ToInt32(tableVehicleModels
                    .CurrentRow.Cells["id"].Value.ToString());
                VehicleModel vm = dataVehicleModel.ReadById(selectedIdVehicleModel);
                if (vm != null)
                {
                    txtModelName.Text = vm.Name;
                    cmbModelBrand.SelectedValue = vm.IdBrand;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //======================Infractions=====================================

        private void btnInsertInfraction_Click(object sender, EventArgs e)
        {
            if (checkInfractionFormFilling())
            {
                Infraction i = ReadInfractionFromUI();
                if (dataInfractions.Create(i))
                {
                    ReloadInfractions();
                    MessageBox.Show(null, "Infraction was successfully inserted to the database",
                                   "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(null, dataInfractions.getLastError(),
                                   "Failure", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateInfraction_Click(object sender, EventArgs e)
        {
            if (checkInfractionFormFilling())
            {
                Infraction i = ReadInfractionFromUI();
                i.Id = selectedIdInfraction;
                if (dataInfractions.Update(i))
                {
                    ReloadInfractions();
                    MessageBox.Show(null, "Infraction was successfully updated",
                                   "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(null, dataInfractions.getLastError(),
                                   "Failure", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemoveInfraction_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to delete selected infraction?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (dataInfractions.Delete(selectedIdInfraction))
                {
                    ReloadInfractions();
                    clearInfractionForm();
                    MessageBox.Show(null, "Infraction with id " +
                                    selectedIdInfraction +
                                    " was successfully removed",
                                    "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(null, dataInfractions.getLastError(),
                                   "Failure", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            } 
        }

        private void btnLoadFullList_Click(object sender, EventArgs e)
        {
            ReloadInfractions();
        }

        private void btnInfractionSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchInfraction.Text == "") return;
            DataTable dt = dataInfractions.SearchTotal(txtSearchInfraction.Text);
            tableInfractions.DataSource = dt.DefaultView;
            int count = dt.Rows.Count;
            switch (count)
            {
                case 0:
                    lblInfraxtionSearchResults.ForeColor = Color.Red;
                    lblInfraxtionSearchResults.Text = "No infractions found";
                    break;
                case 1:
                    lblInfraxtionSearchResults.ForeColor = Color.Green;
                    lblInfraxtionSearchResults.Text = "One infraciton was found";
                    break;
                default:
                    lblInfraxtionSearchResults.ForeColor = Color.Green;
                    lblInfraxtionSearchResults.Text = String.Format("{0} infractions were found", count);
                    break;
            }
        }

        private void tableInfractions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableInfractions.CurrentRow.Index == tableInfractions.Rows.Count - 1) return;
            try
            {
                selectedIdInfraction = Convert.ToInt32(tableInfractions
                    .CurrentRow.Cells["id"].Value.ToString());
                Infraction i = dataInfractions.ReadById(selectedIdInfraction);
                fillInfraction(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private bool isVehicleModelFormFilled()
        {
            return txtModelName.Text != "";
        }

        private bool isInfractionFormFilled()
        {
            return txtPatent.Text != "" && txtInfractionDetails.Text != "";
        }

        private bool checkVehicleFormFilling()
        {
            if (!isVehicleModelFormFilled())
            {
                MessageBox.Show(null, "Fill form", "Not all fields are filled",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool checkInfractionFormFilling()
        {
            if (!isInfractionFormFilled())
            {
                MessageBox.Show(null, "Fill form", "Not all fields are filled",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void loadBrandsCombo()
        {
            DataTable dt = dataBrand.GetDataForCombo();
            if (dt != null)
            {
                cmbModelBrand.DisplayMember = "name";
                cmbModelBrand.ValueMember = "id";
                cmbModelBrand.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Combo error occured!");
            }              
        }

        private void loadModelsCombo()
        {
            DataTable dt = dataVehicleModel.GetDataForCombo();
            if (dt != null)
            {
                cmbVehicleModel.DisplayMember = "name";
                cmbVehicleModel.ValueMember = "id";
                cmbVehicleModel.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Combo error occured!");
            }  
        }

        private void ReloadBrands()
        {
            tableBrands.DataSource = dataBrand.ReadAll();
            loadBrandsCombo();
            lblSearchResults.Text = "...";
            lblSearchResults.ForeColor = Color.Black;
        }

        private void ReloadVehicleModels()
        {
            tableVehicleModels.DataSource = 
                dataVehicleModel.ReadAllFormatted();
            loadModelsCombo();
            lblVehicleModelSearchResults.ForeColor = Color.Black;
            lblVehicleModelSearchResults.Text = "...";
        }

        private void ReloadInfractions()
        {
            tableInfractions.DataSource = dataInfractions.getCompleteInfractionData();
            lblInfraxtionSearchResults.ForeColor = Color.Black;
            lblInfraxtionSearchResults.Text = "...";
        }

        private void clearVehicleModelForm()
        {
            txtModelName.Text = "";
            if(cmbModelBrand.Items.Count > 0)
                cmbModelBrand.SelectedIndex = 0;
        }

        private void clearInfractionForm()
        {
            txtPatent.Text = "";
            if (cmbVehicleModel.Items.Count > 0)
                cmbVehicleModel.SelectedIndex = 0;
            txtDate.Value = DateTime.Now;
            txtInfractionDetails.Text = "";
            spinnerFine.Value = 0;
        }

        private Infraction ReadInfractionFromUI()
        {
            Infraction i = new Infraction();
            i.Patent = txtPatent.Text;
            i.IdModel = Convert.ToInt32(cmbVehicleModel.SelectedValue);
            i.Details = txtInfractionDetails.Text;
            i.Fecha = txtDate.Value;
            i.Fine = Convert.ToInt32(spinnerFine.Value);
            return i;
        }

        private void fillInfraction(Infraction i)
        {
            if (i != null)
            {
                txtPatent.Text = i.Patent;
                cmbVehicleModel.SelectedValue = i.IdModel;
                txtDate.Value = i.Fecha;
                txtInfractionDetails.Text = i.Details;
                spinnerFine.Value = i.Fine;
            }
        }
    }
}

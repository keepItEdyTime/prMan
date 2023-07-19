namespace PrGer.Views
{
    partial class ProductPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_logo = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlProduct = new System.Windows.Forms.TabControl();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXLS = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabPageProductForm = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSTK = new System.Windows.Forms.TextBox();
            this.cbBoxInacitve = new System.Windows.Forms.ComboBox();
            this.lbId = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxVat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.textBoxDescriptionEn = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxIdentifier = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbIdRemote = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlProduct.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageProductForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestão de produtos";
            // 
            // lb_logo
            // 
            this.lb_logo.AutoSize = true;
            this.lb_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_logo.ForeColor = System.Drawing.Color.Brown;
            this.lb_logo.Location = new System.Drawing.Point(15, 9);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(62, 35);
            this.lb_logo.TabIndex = 0;
            this.lb_logo.Text = "GP";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(11, 16);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(224, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControlProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 462);
            this.panel2.TabIndex = 1;
            // 
            // tabControlProduct
            // 
            this.tabControlProduct.Controls.Add(this.tabPageProducts);
            this.tabControlProduct.Controls.Add(this.tabPageProductForm);
            this.tabControlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProduct.Location = new System.Drawing.Point(0, 0);
            this.tabControlProduct.Name = "tabControlProduct";
            this.tabControlProduct.SelectedIndex = 0;
            this.tabControlProduct.Size = new System.Drawing.Size(979, 462);
            this.tabControlProduct.TabIndex = 0;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.AllowDrop = true;
            this.tabPageProducts.Controls.Add(this.btnCSV);
            this.tabPageProducts.Controls.Add(this.btnPDF);
            this.tabPageProducts.Controls.Add(this.dataGridView1);
            this.tabPageProducts.Controls.Add(this.btnXLS);
            this.tabPageProducts.Controls.Add(this.btnEdit);
            this.tabPageProducts.Controls.Add(this.btnRemove);
            this.tabPageProducts.Controls.Add(this.btnAdd);
            this.tabPageProducts.Controls.Add(this.btnSearch);
            this.tabPageProducts.Controls.Add(this.textBoxSearch);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 22);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(971, 436);
            this.tabPageProducts.TabIndex = 0;
            this.tabPageProducts.Text = "Produtos";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // btnCSV
            // 
            this.btnCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCSV.Location = new System.Drawing.Point(788, 6);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(75, 23);
            this.btnCSV.TabIndex = 2;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDF.Location = new System.Drawing.Point(707, 6);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(75, 23);
            this.btnPDF.TabIndex = 4;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(874, 353);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnXLS
            // 
            this.btnXLS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXLS.Location = new System.Drawing.Point(626, 6);
            this.btnXLS.Name = "btnXLS";
            this.btnXLS.Size = new System.Drawing.Size(75, 23);
            this.btnXLS.TabIndex = 3;
            this.btnXLS.Text = "XLS";
            this.btnXLS.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(888, 71);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(888, 100);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(888, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(241, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tabPageProductForm
            // 
            this.tabPageProductForm.AllowDrop = true;
            this.tabPageProductForm.Controls.Add(this.lbIdRemote);
            this.tabPageProductForm.Controls.Add(this.label9);
            this.tabPageProductForm.Controls.Add(this.label8);
            this.tabPageProductForm.Controls.Add(this.textBoxSTK);
            this.tabPageProductForm.Controls.Add(this.cbBoxInacitve);
            this.tabPageProductForm.Controls.Add(this.lbId);
            this.tabPageProductForm.Controls.Add(this.labelId);
            this.tabPageProductForm.Controls.Add(this.label7);
            this.tabPageProductForm.Controls.Add(this.textBoxVat);
            this.tabPageProductForm.Controls.Add(this.label6);
            this.tabPageProductForm.Controls.Add(this.label5);
            this.tabPageProductForm.Controls.Add(this.label4);
            this.tabPageProductForm.Controls.Add(this.label3);
            this.tabPageProductForm.Controls.Add(this.label2);
            this.tabPageProductForm.Controls.Add(this.btnSave);
            this.tabPageProductForm.Controls.Add(this.btnCancel);
            this.tabPageProductForm.Controls.Add(this.textBoxPrice);
            this.tabPageProductForm.Controls.Add(this.textBoxUnit);
            this.tabPageProductForm.Controls.Add(this.textBoxDescriptionEn);
            this.tabPageProductForm.Controls.Add(this.textBoxDescription);
            this.tabPageProductForm.Controls.Add(this.textBoxIdentifier);
            this.tabPageProductForm.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductForm.Name = "tabPageProductForm";
            this.tabPageProductForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductForm.Size = new System.Drawing.Size(971, 436);
            this.tabPageProductForm.TabIndex = 1;
            this.tabPageProductForm.Text = "Adicionar";
            this.tabPageProductForm.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "activo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "STK disponível";
            // 
            // textBoxSTK
            // 
            this.textBoxSTK.Location = new System.Drawing.Point(457, 123);
            this.textBoxSTK.Name = "textBoxSTK";
            this.textBoxSTK.Size = new System.Drawing.Size(168, 20);
            this.textBoxSTK.TabIndex = 16;
            this.textBoxSTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSTK_KeyPress);
            // 
            // cbBoxInacitve
            // 
            this.cbBoxInacitve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxInacitve.FormattingEnabled = true;
            this.cbBoxInacitve.Items.AddRange(new object[] {
            "sim",
            "nao"});
            this.cbBoxInacitve.Location = new System.Drawing.Point(457, 162);
            this.cbBoxInacitve.Name = "cbBoxInacitve";
            this.cbBoxInacitve.Size = new System.Drawing.Size(168, 21);
            this.cbBoxInacitve.TabIndex = 15;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(842, 18);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 13);
            this.lbId.TabIndex = 14;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(931, 18);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(0, 13);
            this.labelId.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "vat";
            // 
            // textBoxVat
            // 
            this.textBoxVat.Location = new System.Drawing.Point(457, 39);
            this.textBoxVat.Name = "textBoxVat";
            this.textBoxVat.Size = new System.Drawing.Size(168, 20);
            this.textBoxVat.TabIndex = 11;
            this.textBoxVat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVat_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "descrição EN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "identificador";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(539, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(450, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(457, 84);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(168, 20);
            this.textBoxPrice.TabIndex = 4;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(177, 167);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(168, 20);
            this.textBoxUnit.TabIndex = 3;
            // 
            // textBoxDescriptionEn
            // 
            this.textBoxDescriptionEn.Location = new System.Drawing.Point(177, 123);
            this.textBoxDescriptionEn.Name = "textBoxDescriptionEn";
            this.textBoxDescriptionEn.Size = new System.Drawing.Size(168, 20);
            this.textBoxDescriptionEn.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(177, 79);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(168, 20);
            this.textBoxDescription.TabIndex = 1;
            // 
            // textBoxIdentifier
            // 
            this.textBoxIdentifier.Location = new System.Drawing.Point(177, 35);
            this.textBoxIdentifier.Name = "textBoxIdentifier";
            this.textBoxIdentifier.Size = new System.Drawing.Size(168, 20);
            this.textBoxIdentifier.TabIndex = 0;
            // 
            // lbIdRemote
            // 
            this.lbIdRemote.AutoSize = true;
            this.lbIdRemote.Location = new System.Drawing.Point(874, 18);
            this.lbIdRemote.Name = "lbIdRemote";
            this.lbIdRemote.Size = new System.Drawing.Size(0, 13);
            this.lbIdRemote.TabIndex = 19;
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductPage";
            this.Text = "MainPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControlProduct.ResumeLayout(false);
            this.tabPageProducts.ResumeLayout(false);
            this.tabPageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageProductForm.ResumeLayout(false);
            this.tabPageProductForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TabControl tabControlProduct;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.TabPage tabPageProductForm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.TextBox textBoxDescriptionEn;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxIdentifier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxVat;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSTK;
        private System.Windows.Forms.ComboBox cbBoxInacitve;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnXLS;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Label lbIdRemote;
    }
}
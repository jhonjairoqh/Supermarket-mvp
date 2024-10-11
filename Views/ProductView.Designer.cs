namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            BtnClose = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnNew = new Button();
            dgvProducts = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageProductDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCategoryId = new TextBox();
            TxtStock = new TextBox();
            TxtPrice = new TextBox();
            TxtProductName = new TextBox();
            TxtProductId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            tabPageProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 532);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Location = new Point(3, 102);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(897, 430);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(BtnClose);
            tabPageProductList.Controls.Add(BtnEdit);
            tabPageProductList.Controls.Add(BtnDelete);
            tabPageProductList.Controls.Add(BtnNew);
            tabPageProductList.Controls.Add(dgvProducts);
            tabPageProductList.Controls.Add(BtnSearch);
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Location = new Point(4, 29);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(889, 397);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(753, 299);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 68);
            BtnClose.TabIndex = 11;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(753, 122);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 70);
            BtnEdit.TabIndex = 10;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(753, 211);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 70);
            BtnDelete.TabIndex = 9;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(753, 37);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(94, 64);
            BtnNew.TabIndex = 8;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(21, 80);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(625, 310);
            dgvProducts.TabIndex = 6;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(602, 26);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(44, 48);
            BtnSearch.TabIndex = 5;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(21, 37);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Enter product name";
            TxtSearch.Size = new Size(575, 27);
            TxtSearch.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 14);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 3;
            label2.Text = "Search Product";
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(BtnCancel);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Controls.Add(TxtCategoryId);
            tabPageProductDetail.Controls.Add(TxtStock);
            tabPageProductDetail.Controls.Add(TxtPrice);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(label7);
            tabPageProductDetail.Controls.Add(label6);
            tabPageProductDetail.Controls.Add(label5);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Location = new Point(4, 29);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(889, 397);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(657, 167);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(111, 73);
            BtnCancel.TabIndex = 11;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(486, 167);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(111, 73);
            BtnSave.TabIndex = 10;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Location = new Point(60, 339);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.Size = new Size(295, 27);
            TxtCategoryId.TabIndex = 9;
            // 
            // TxtStock
            // 
            TxtStock.Location = new Point(60, 268);
            TxtStock.Name = "TxtStock";
            TxtStock.Size = new Size(295, 27);
            TxtStock.TabIndex = 8;
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(60, 196);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(295, 27);
            TxtPrice.TabIndex = 7;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(64, 132);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(291, 27);
            TxtProductName.TabIndex = 6;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(60, 53);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(295, 27);
            TxtProductId.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 308);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 4;
            label7.Text = "Category ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 101);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 3;
            label6.Text = "Product Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 167);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 2;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 235);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 1;
            label4.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 30);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 0;
            label3.Text = "Product ID";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(28, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 30);
            label1.Name = "label1";
            label1.Size = new Size(340, 35);
            label1.TabIndex = 0;
            label1.Text = "Product Management";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 533);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dgvProducts;
        private Button BtnClose;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnNew;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtStock;
        private TextBox TxtPrice;
        private TextBox TxtProductName;
        private TextBox TxtProductId;
        private TextBox TxtCategoryId;
        private Button BtnCancel;
        private Button BtnSave;
    }
}
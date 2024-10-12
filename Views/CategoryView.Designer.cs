namespace Supermarket_mvp.Views
{
    partial class CategoryView
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCategoryList = new TabPage();
            tabPageCategoryDetail = new TabPage();
            BtnClose = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnNew = new Button();
            DgvCategories = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCategoryDescription = new TextBox();
            TxtCategoryName = new TextBox();
            TxtCategoryId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoryList.SuspendLayout();
            tabPageCategoryDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCategories).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 568);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.categorias;
            pictureBox1.Location = new Point(48, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 35);
            label1.Name = "label1";
            label1.Size = new Size(181, 35);
            label1.TabIndex = 3;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoryList);
            tabControl1.Controls.Add(tabPageCategoryDetail);
            tabControl1.Location = new Point(0, 106);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(857, 462);
            tabControl1.TabIndex = 4;
            // 
            // tabPageCategoryList
            // 
            tabPageCategoryList.Controls.Add(BtnClose);
            tabPageCategoryList.Controls.Add(BtnEdit);
            tabPageCategoryList.Controls.Add(BtnDelete);
            tabPageCategoryList.Controls.Add(BtnNew);
            tabPageCategoryList.Controls.Add(DgvCategories);
            tabPageCategoryList.Controls.Add(BtnSearch);
            tabPageCategoryList.Controls.Add(TxtSearch);
            tabPageCategoryList.Controls.Add(label2);
            tabPageCategoryList.Location = new Point(4, 29);
            tabPageCategoryList.Name = "tabPageCategoryList";
            tabPageCategoryList.Padding = new Padding(3);
            tabPageCategoryList.Size = new Size(849, 429);
            tabPageCategoryList.TabIndex = 0;
            tabPageCategoryList.Text = "Category List";
            tabPageCategoryList.UseVisualStyleBackColor = true;
            // 
            // tabPageCategoryDetail
            // 
            tabPageCategoryDetail.Controls.Add(BtnCancel);
            tabPageCategoryDetail.Controls.Add(BtnSave);
            tabPageCategoryDetail.Controls.Add(TxtCategoryDescription);
            tabPageCategoryDetail.Controls.Add(TxtCategoryName);
            tabPageCategoryDetail.Controls.Add(TxtCategoryId);
            tabPageCategoryDetail.Controls.Add(label6);
            tabPageCategoryDetail.Controls.Add(label5);
            tabPageCategoryDetail.Controls.Add(label4);
            tabPageCategoryDetail.Location = new Point(4, 29);
            tabPageCategoryDetail.Name = "tabPageCategoryDetail";
            tabPageCategoryDetail.Padding = new Padding(3);
            tabPageCategoryDetail.Size = new Size(849, 429);
            tabPageCategoryDetail.TabIndex = 1;
            tabPageCategoryDetail.Text = "Category Detail";
            tabPageCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(743, 311);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 68);
            BtnClose.TabIndex = 19;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(743, 134);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 70);
            BtnEdit.TabIndex = 18;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(743, 223);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 70);
            BtnDelete.TabIndex = 17;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(743, 49);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(94, 64);
            BtnNew.TabIndex = 16;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgvCategories
            // 
            DgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCategories.Location = new Point(11, 92);
            DgvCategories.Name = "DgvCategories";
            DgvCategories.RowHeadersWidth = 51;
            DgvCategories.Size = new Size(625, 310);
            DgvCategories.TabIndex = 15;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(592, 38);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(44, 48);
            BtnSearch.TabIndex = 14;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(11, 49);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Enter Categorie name";
            TxtSearch.Size = new Size(575, 27);
            TxtSearch.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 26);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 12;
            label2.Text = "Search Categorie";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(667, 183);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(111, 73);
            BtnCancel.TabIndex = 19;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(496, 183);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(111, 73);
            BtnSave.TabIndex = 18;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCategoryDescription
            // 
            TxtCategoryDescription.Location = new Point(70, 284);
            TxtCategoryDescription.Name = "TxtCategoryDescription";
            TxtCategoryDescription.Size = new Size(295, 27);
            TxtCategoryDescription.TabIndex = 17;
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.Location = new Point(70, 212);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.Size = new Size(295, 27);
            TxtCategoryName.TabIndex = 16;
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Enabled = false;
            TxtCategoryId.Location = new Point(74, 148);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.Size = new Size(291, 27);
            TxtCategoryId.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 117);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 14;
            label6.Text = "Category Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 183);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 13;
            label5.Text = "Category Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 251);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 12;
            label4.Text = "Description";
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 570);
            Controls.Add(panel1);
            Name = "CategoryView";
            Text = "CategoryView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategoryList.ResumeLayout(false);
            tabPageCategoryList.PerformLayout();
            tabPageCategoryDetail.ResumeLayout(false);
            tabPageCategoryDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageCategoryList;
        private TabPage tabPageCategoryDetail;
        private Label label1;
        private Button BtnClose;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnNew;
        private DataGridView DgvCategories;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtCategoryDescription;
        private TextBox TxtCategoryName;
        private TextBox TxtCategoryId;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
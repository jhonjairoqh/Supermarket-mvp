namespace Supermarket_mvp.Views
{
    partial class ProviderView
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPageProviderList = new TabPage();
            tabPageProviderDetail = new TabPage();
            DgvProviders = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            BtnClose = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnNew = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtProviderId = new TextBox();
            TxtProviderName = new TextBox();
            TxtProviderContact = new TextBox();
            TxtProviderAddress = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProviderList.SuspendLayout();
            tabPageProviderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProviders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 574);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 51);
            label1.Name = "label1";
            label1.Size = new Size(173, 35);
            label1.TabIndex = 1;
            label1.Text = "Providers";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(31, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProviderList);
            tabControl1.Controls.Add(tabPageProviderDetail);
            tabControl1.Location = new Point(3, 121);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(934, 450);
            tabControl1.TabIndex = 3;
            // 
            // tabPageProviderList
            // 
            tabPageProviderList.Controls.Add(BtnClose);
            tabPageProviderList.Controls.Add(BtnEdit);
            tabPageProviderList.Controls.Add(BtnDelete);
            tabPageProviderList.Controls.Add(BtnNew);
            tabPageProviderList.Controls.Add(BtnSearch);
            tabPageProviderList.Controls.Add(TxtSearch);
            tabPageProviderList.Controls.Add(label2);
            tabPageProviderList.Controls.Add(DgvProviders);
            tabPageProviderList.Location = new Point(4, 29);
            tabPageProviderList.Name = "tabPageProviderList";
            tabPageProviderList.Padding = new Padding(3);
            tabPageProviderList.Size = new Size(926, 417);
            tabPageProviderList.TabIndex = 0;
            tabPageProviderList.Text = "Provider List";
            tabPageProviderList.UseVisualStyleBackColor = true;
            // 
            // tabPageProviderDetail
            // 
            tabPageProviderDetail.Controls.Add(BtnCancel);
            tabPageProviderDetail.Controls.Add(BtnSave);
            tabPageProviderDetail.Controls.Add(TxtProviderAddress);
            tabPageProviderDetail.Controls.Add(TxtProviderContact);
            tabPageProviderDetail.Controls.Add(TxtProviderName);
            tabPageProviderDetail.Controls.Add(TxtProviderId);
            tabPageProviderDetail.Controls.Add(label6);
            tabPageProviderDetail.Controls.Add(label5);
            tabPageProviderDetail.Controls.Add(label4);
            tabPageProviderDetail.Controls.Add(label3);
            tabPageProviderDetail.Location = new Point(4, 29);
            tabPageProviderDetail.Name = "tabPageProviderDetail";
            tabPageProviderDetail.Padding = new Padding(3);
            tabPageProviderDetail.Size = new Size(926, 417);
            tabPageProviderDetail.TabIndex = 1;
            tabPageProviderDetail.Text = "Provider Detail";
            tabPageProviderDetail.UseVisualStyleBackColor = true;
            // 
            // DgvProviders
            // 
            DgvProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProviders.Location = new Point(24, 100);
            DgvProviders.Name = "DgvProviders";
            DgvProviders.RowHeadersWidth = 51;
            DgvProviders.Size = new Size(625, 310);
            DgvProviders.TabIndex = 7;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(605, 35);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(44, 48);
            BtnSearch.TabIndex = 10;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(24, 46);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Enter Provider name";
            TxtSearch.Size = new Size(575, 27);
            TxtSearch.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 23);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 8;
            label2.Text = "Search Provider";
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(763, 308);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 68);
            BtnClose.TabIndex = 15;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(763, 131);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 70);
            BtnEdit.TabIndex = 14;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(763, 220);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 70);
            BtnDelete.TabIndex = 13;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(763, 46);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(94, 64);
            BtnNew.TabIndex = 12;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 34);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 1;
            label3.Text = "Provider Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 131);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 219);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 3;
            label5.Text = "Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 297);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 4;
            label6.Text = "Address";
            // 
            // TxtProviderId
            // 
            TxtProviderId.Location = new Point(51, 66);
            TxtProviderId.Name = "TxtProviderId";
            TxtProviderId.Size = new Size(291, 27);
            TxtProviderId.TabIndex = 7;
            // 
            // TxtProviderName
            // 
            TxtProviderName.Location = new Point(51, 154);
            TxtProviderName.Name = "TxtProviderName";
            TxtProviderName.Size = new Size(291, 27);
            TxtProviderName.TabIndex = 8;
            // 
            // TxtProviderContact
            // 
            TxtProviderContact.Location = new Point(51, 242);
            TxtProviderContact.Name = "TxtProviderContact";
            TxtProviderContact.Size = new Size(291, 27);
            TxtProviderContact.TabIndex = 9;
            // 
            // TxtProviderAddress
            // 
            TxtProviderAddress.Location = new Point(51, 329);
            TxtProviderAddress.Name = "TxtProviderAddress";
            TxtProviderAddress.Size = new Size(291, 27);
            TxtProviderAddress.TabIndex = 10;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(704, 166);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(111, 73);
            BtnCancel.TabIndex = 13;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(533, 166);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(111, 73);
            BtnSave.TabIndex = 12;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // ProviderView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 573);
            Controls.Add(panel1);
            Name = "ProviderView";
            Text = "ProviderView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProviderList.ResumeLayout(false);
            tabPageProviderList.PerformLayout();
            tabPageProviderDetail.ResumeLayout(false);
            tabPageProviderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProviders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageProviderList;
        private TabPage tabPageProviderDetail;
        private DataGridView DgvProviders;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnNew;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtProviderId;
        private TextBox TxtProviderAddress;
        private TextBox TxtProviderContact;
        private TextBox TxtProviderName;
        private Button BtnCancel;
        private Button BtnSave;
    }
}
﻿namespace Supermarket_mvp.Views
{
    partial class MainView
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
            BtnProvider = new Button();
            BtnProducts = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            BtnCategory = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCategory);
            panel1.Controls.Add(BtnProvider);
            panel1.Controls.Add(BtnProducts);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 556);
            panel1.TabIndex = 0;
            // 
            // BtnProvider
            // 
            BtnProvider.BackgroundImage = Properties.Resources.providers;
            BtnProvider.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProvider.Location = new Point(37, 285);
            BtnProvider.Name = "BtnProvider";
            BtnProvider.Size = new Size(124, 65);
            BtnProvider.TabIndex = 4;
            BtnProvider.UseVisualStyleBackColor = true;
            // 
            // BtnProducts
            // 
            BtnProducts.BackgroundImage = Properties.Resources.products1;
            BtnProducts.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProducts.Location = new Point(37, 201);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(124, 67);
            BtnProducts.TabIndex = 3;
            BtnProducts.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.salida;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Location = new Point(28, 450);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(146, 82);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(37, 103);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(124, 75);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnCategory
            // 
            BtnCategory.BackgroundImage = Properties.Resources.categorias;
            BtnCategory.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategory.Location = new Point(37, 367);
            BtnCategory.Name = "BtnCategory";
            BtnCategory.Size = new Size(124, 65);
            BtnCategory.TabIndex = 5;
            BtnCategory.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 556);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            Load += MainView_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BtnPayMode;
        private Button BtnExit;
        private Button BtnProducts;
        private Button BtnProvider;
        private Button BtnCategory;
    }
}
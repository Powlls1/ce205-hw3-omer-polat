namespace ce205_hw3_gui
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Status = new System.Windows.Forms.Label();
            this.randomBtn = new System.Windows.Forms.Button();
            this.InOrder = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.randomBtnRB = new System.Windows.Forms.Button();
            this.FindRB = new System.Windows.Forms.Button();
            this.deleteBtnRB = new System.Windows.Forms.Button();
            this.InsertBtnRB = new System.Windows.Forms.Button();
            this.valueBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1347, 652);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Status);
            this.tabPage1.Controls.Add(this.randomBtn);
            this.tabPage1.Controls.Add(this.InOrder);
            this.tabPage1.Controls.Add(this.Find);
            this.tabPage1.Controls.Add(this.deleteBtn);
            this.tabPage1.Controls.Add(this.InsertBtn);
            this.tabPage1.Controls.Add(this.valueBox);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1339, 626);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AVL Tree";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(696, 604);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 7;
            this.Status.Text = "Status";
            this.Status.TextChanged += new System.EventHandler(this.Status_TextChanged);
            // 
            // randomBtn
            // 
            this.randomBtn.Location = new System.Drawing.Point(9, 320);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(142, 42);
            this.randomBtn.TabIndex = 6;
            this.randomBtn.Text = "Random Words";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // InOrder
            // 
            this.InOrder.Location = new System.Drawing.Point(9, 256);
            this.InOrder.Name = "InOrder";
            this.InOrder.Size = new System.Drawing.Size(142, 41);
            this.InOrder.TabIndex = 5;
            this.InOrder.Text = "Inorder";
            this.InOrder.UseVisualStyleBackColor = true;
            this.InOrder.Click += new System.EventHandler(this.InOrder_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(9, 195);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(142, 41);
            this.Find.TabIndex = 4;
            this.Find.Text = "Search";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(9, 132);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(142, 41);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(9, 72);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(142, 40);
            this.InsertBtn.TabIndex = 2;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(9, 21);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(142, 20);
            this.valueBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(176, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1163, 626);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.randomBtnRB);
            this.tabPage2.Controls.Add(this.FindRB);
            this.tabPage2.Controls.Add(this.deleteBtnRB);
            this.tabPage2.Controls.Add(this.InsertBtnRB);
            this.tabPage2.Controls.Add(this.valueBox1);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1339, 626);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Red Black Tree";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // randomBtnRB
            // 
            this.randomBtnRB.Location = new System.Drawing.Point(9, 199);
            this.randomBtnRB.Name = "randomBtnRB";
            this.randomBtnRB.Size = new System.Drawing.Size(128, 38);
            this.randomBtnRB.TabIndex = 5;
            this.randomBtnRB.Text = "Random Words";
            this.randomBtnRB.UseVisualStyleBackColor = true;
            this.randomBtnRB.Click += new System.EventHandler(this.randomBtnRB_Click);
            // 
            // FindRB
            // 
            this.FindRB.Location = new System.Drawing.Point(8, 155);
            this.FindRB.Name = "FindRB";
            this.FindRB.Size = new System.Drawing.Size(128, 38);
            this.FindRB.TabIndex = 4;
            this.FindRB.Text = "Search";
            this.FindRB.UseVisualStyleBackColor = true;
            this.FindRB.Click += new System.EventHandler(this.FindRB_Click);
            // 
            // deleteBtnRB
            // 
            this.deleteBtnRB.Location = new System.Drawing.Point(9, 111);
            this.deleteBtnRB.Name = "deleteBtnRB";
            this.deleteBtnRB.Size = new System.Drawing.Size(128, 38);
            this.deleteBtnRB.TabIndex = 3;
            this.deleteBtnRB.Text = "Delete";
            this.deleteBtnRB.UseVisualStyleBackColor = true;
            this.deleteBtnRB.Click += new System.EventHandler(this.deleteBtnRB_Click);
            // 
            // InsertBtnRB
            // 
            this.InsertBtnRB.Location = new System.Drawing.Point(9, 67);
            this.InsertBtnRB.Name = "InsertBtnRB";
            this.InsertBtnRB.Size = new System.Drawing.Size(128, 38);
            this.InsertBtnRB.TabIndex = 2;
            this.InsertBtnRB.Text = "Insert";
            this.InsertBtnRB.UseVisualStyleBackColor = true;
            this.InsertBtnRB.Click += new System.EventHandler(this.InsertBtnRB_Click);
            // 
            // valueBox1
            // 
            this.valueBox1.Location = new System.Drawing.Point(9, 25);
            this.valueBox1.Name = "valueBox1";
            this.valueBox1.Size = new System.Drawing.Size(128, 20);
            this.valueBox1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(143, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1200, 626);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 651);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button randomBtn;
        public System.Windows.Forms.Button InOrder;
        public System.Windows.Forms.Button Find;
        public System.Windows.Forms.Button deleteBtn;
        public System.Windows.Forms.Button InsertBtn;
        public System.Windows.Forms.TextBox valueBox;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label Status;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button randomBtnRB;
        public System.Windows.Forms.Button FindRB;
        public System.Windows.Forms.Button deleteBtnRB;
        public System.Windows.Forms.Button InsertBtnRB;
        public System.Windows.Forms.TextBox valueBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
    }
}


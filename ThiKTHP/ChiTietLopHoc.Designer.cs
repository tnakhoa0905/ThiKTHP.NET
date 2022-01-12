namespace GUI
{
    partial class ChiTietLopHoc
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
            this.txtidLop = new System.Windows.Forms.TextBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHS = new System.Windows.Forms.DataGridView();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.dtime = new System.Windows.Forms.DateTimePicker();
            this.idHS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtidLop
            // 
            this.txtidLop.Location = new System.Drawing.Point(50, 39);
            this.txtidLop.Name = "txtidLop";
            this.txtidLop.Size = new System.Drawing.Size(100, 20);
            this.txtidLop.TabIndex = 0;
            this.txtidLop.Visible = false;
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Location = new System.Drawing.Point(485, 21);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(50, 39);
            this.lbLop.TabIndex = 1;
            this.lbLop.Text = "...";
            this.lbLop.Click += new System.EventHandler(this.lbLop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lớp:";
            // 
            // dataGridViewHS
            // 
            this.dataGridViewHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHS.Location = new System.Drawing.Point(346, 168);
            this.dataGridViewHS.Name = "dataGridViewHS";
            this.dataGridViewHS.Size = new System.Drawing.Size(626, 421);
            this.dataGridViewHS.TabIndex = 3;
            this.dataGridViewHS.Click += new System.EventHandler(this.dataGridViewHS_Click);
            this.dataGridViewHS.DoubleClick += new System.EventHandler(this.dataGridViewHS_DoubleClick);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(110, 32);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(200, 20);
            this.txtHoten.TabIndex = 4;
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(110, 81);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(200, 20);
            this.txtGT.TabIndex = 5;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(110, 219);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(200, 20);
            this.txtAdd.TabIndex = 6;
            // 
            // dtime
            // 
            this.dtime.Location = new System.Drawing.Point(110, 160);
            this.dtime.Name = "dtime";
            this.dtime.Size = new System.Drawing.Size(200, 20);
            this.dtime.TabIndex = 7;
            // 
            // idHS
            // 
            this.idHS.Location = new System.Drawing.Point(50, 82);
            this.idHS.Name = "idHS";
            this.idHS.Size = new System.Drawing.Size(100, 20);
            this.idHS.TabIndex = 8;
            this.idHS.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quê quán";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtHoten);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtime);
            this.panel1.Controls.Add(this.txtAdd);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 421);
            this.panel1.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(897, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Xem Chi Tiết";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ChiTietLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.idHS);
            this.Controls.Add(this.dataGridViewHS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLop);
            this.Controls.Add(this.txtidLop);
            this.Name = "ChiTietLopHoc";
            this.Text = "ChiTietLopHoc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidLop;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHS;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.DateTimePicker dtime;
        private System.Windows.Forms.TextBox idHS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
    }
}
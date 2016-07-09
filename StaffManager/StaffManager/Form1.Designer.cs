namespace StaffManager
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.txtSrch = new System.Windows.Forms.TextBox();
            this.comSrch = new System.Windows.Forms.ComboBox();
            this.srchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comGen = new System.Windows.Forms.ComboBox();
            this.comDepa = new System.Windows.Forms.ComboBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.depBtn = new System.Windows.Forms.Button();
            this.refBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUser.Location = new System.Drawing.Point(13, 71);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowTemplate.Height = 23;
            this.dgvUser.Size = new System.Drawing.Size(427, 352);
            this.dgvUser.TabIndex = 0;
            // 
            // txtSrch
            // 
            this.txtSrch.Location = new System.Drawing.Point(34, 33);
            this.txtSrch.Name = "txtSrch";
            this.txtSrch.Size = new System.Drawing.Size(100, 21);
            this.txtSrch.TabIndex = 1;
            // 
            // comSrch
            // 
            this.comSrch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comSrch.FormattingEnabled = true;
            this.comSrch.Items.AddRange(new object[] {
            "Name",
            "Department"});
            this.comSrch.Location = new System.Drawing.Point(153, 33);
            this.comSrch.Name = "comSrch";
            this.comSrch.Size = new System.Drawing.Size(70, 20);
            this.comSrch.TabIndex = 2;
            // 
            // srchBtn
            // 
            this.srchBtn.Location = new System.Drawing.Point(247, 30);
            this.srchBtn.Name = "srchBtn";
            this.srchBtn.Size = new System.Drawing.Size(75, 23);
            this.srchBtn.TabIndex = 3;
            this.srchBtn.Text = "Search";
            this.srchBtn.UseVisualStyleBackColor = true;
            this.srchBtn.Click += new System.EventHandler(this.srchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birthday";
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(654, 296);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(142, 21);
            this.birthDate.TabIndex = 9;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(472, 374);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(563, 374);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 11;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(654, 374);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 12;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(654, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 13;
            // 
            // comGen
            // 
            this.comGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comGen.FormattingEnabled = true;
            this.comGen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comGen.Location = new System.Drawing.Point(654, 146);
            this.comGen.Name = "comGen";
            this.comGen.Size = new System.Drawing.Size(100, 20);
            this.comGen.TabIndex = 14;
            // 
            // comDepa
            // 
            this.comDepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comDepa.FormattingEnabled = true;
            this.comDepa.Items.AddRange(new object[] {
            "Technology",
            "Design",
            "Sale",
            "Marketing",
            "Service"});
            this.comDepa.Location = new System.Drawing.Point(654, 246);
            this.comDepa.Name = "comDepa";
            this.comDepa.Size = new System.Drawing.Size(121, 20);
            this.comDepa.TabIndex = 15;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(654, 195);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 21);
            this.txtClass.TabIndex = 16;
            // 
            // depBtn
            // 
            this.depBtn.Location = new System.Drawing.Point(356, 30);
            this.depBtn.Name = "depBtn";
            this.depBtn.Size = new System.Drawing.Size(75, 23);
            this.depBtn.TabIndex = 17;
            this.depBtn.Text = "Department";
            this.depBtn.UseVisualStyleBackColor = true;
            this.depBtn.Click += new System.EventHandler(this.depBtn_Click);
            // 
            // refBtn
            // 
            this.refBtn.Location = new System.Drawing.Point(747, 374);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(75, 23);
            this.refBtn.TabIndex = 18;
            this.refBtn.Text = "Refresh";
            this.refBtn.UseVisualStyleBackColor = true;
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 454);
            this.Controls.Add(this.refBtn);
            this.Controls.Add(this.depBtn);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.comDepa);
            this.Controls.Add(this.comGen);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srchBtn);
            this.Controls.Add(this.comSrch);
            this.Controls.Add(this.txtSrch);
            this.Controls.Add(this.dgvUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TextBox txtSrch;
        private System.Windows.Forms.ComboBox comSrch;
        private System.Windows.Forms.Button srchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comGen;
        private System.Windows.Forms.ComboBox comDepa;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button depBtn;
        private System.Windows.Forms.Button refBtn;
    }
}


namespace Do_an_winform
{
    partial class Nhanvien
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
            System.Windows.Forms.Label holotLabel;
            System.Windows.Forms.Label manvLabel;
            System.Windows.Forms.Label ngaysinhLabel;
            System.Windows.Forms.Label ngayvaolamLabel;
            System.Windows.Forms.Label tennvLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhanvien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.holotTextBox = new System.Windows.Forms.TextBox();
            this.manvTextBox = new System.Windows.Forms.TextBox();
            this.ngaysinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ngayvaolamDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tennvTextBox = new System.Windows.Forms.TextBox();
            this.nhanvienBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nhanvienBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nhanvienDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            holotLabel = new System.Windows.Forms.Label();
            manvLabel = new System.Windows.Forms.Label();
            ngaysinhLabel = new System.Windows.Forms.Label();
            ngayvaolamLabel = new System.Windows.Forms.Label();
            tennvLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingNavigator)).BeginInit();
            this.nhanvienBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // holotLabel
            // 
            holotLabel.AutoSize = true;
            holotLabel.Location = new System.Drawing.Point(54, 53);
            holotLabel.Name = "holotLabel";
            holotLabel.Size = new System.Drawing.Size(74, 13);
            holotLabel.TabIndex = 0;
            holotLabel.Text = "Họ nhân viên:";
            // 
            // manvLabel
            // 
            manvLabel.AutoSize = true;
            manvLabel.Location = new System.Drawing.Point(54, 29);
            manvLabel.Name = "manvLabel";
            manvLabel.Size = new System.Drawing.Size(75, 13);
            manvLabel.TabIndex = 2;
            manvLabel.Text = "Mã nhân viên:";
            // 
            // ngaysinhLabel
            // 
            ngaysinhLabel.AutoSize = true;
            ngaysinhLabel.Location = new System.Drawing.Point(54, 109);
            ngaysinhLabel.Name = "ngaysinhLabel";
            ngaysinhLabel.Size = new System.Drawing.Size(57, 13);
            ngaysinhLabel.TabIndex = 4;
            ngaysinhLabel.Text = "Ngày sinh:";
            // 
            // ngayvaolamLabel
            // 
            ngayvaolamLabel.AutoSize = true;
            ngayvaolamLabel.Location = new System.Drawing.Point(54, 135);
            ngayvaolamLabel.Name = "ngayvaolamLabel";
            ngayvaolamLabel.Size = new System.Drawing.Size(75, 13);
            ngayvaolamLabel.TabIndex = 6;
            ngayvaolamLabel.Text = "Ngày vào làm:";
            // 
            // tennvLabel
            // 
            tennvLabel.AutoSize = true;
            tennvLabel.Location = new System.Drawing.Point(54, 81);
            tennvLabel.Name = "tennvLabel";
            tennvLabel.Size = new System.Drawing.Size(79, 13);
            tennvLabel.TabIndex = 8;
            tennvLabel.Text = "Tên nhân viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(holotLabel);
            this.groupBox1.Controls.Add(this.holotTextBox);
            this.groupBox1.Controls.Add(manvLabel);
            this.groupBox1.Controls.Add(this.manvTextBox);
            this.groupBox1.Controls.Add(ngaysinhLabel);
            this.groupBox1.Controls.Add(this.ngaysinhDateTimePicker);
            this.groupBox1.Controls.Add(ngayvaolamLabel);
            this.groupBox1.Controls.Add(this.ngayvaolamDateTimePicker);
            this.groupBox1.Controls.Add(tennvLabel);
            this.groupBox1.Controls.Add(this.tennvTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // holotTextBox
            // 
            this.holotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanvienBindingSource, "Holot", true));
            this.holotTextBox.Location = new System.Drawing.Point(139, 50);
            this.holotTextBox.Name = "holotTextBox";
            this.holotTextBox.Size = new System.Drawing.Size(200, 20);
            this.holotTextBox.TabIndex = 1;
            // 
            // manvTextBox
            // 
            this.manvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanvienBindingSource, "Manv", true));
            this.manvTextBox.Location = new System.Drawing.Point(139, 26);
            this.manvTextBox.Name = "manvTextBox";
            this.manvTextBox.Size = new System.Drawing.Size(200, 20);
            this.manvTextBox.TabIndex = 3;
            // 
            // ngaysinhDateTimePicker
            // 
            this.ngaysinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanvienBindingSource, "Ngaysinh", true));
            this.ngaysinhDateTimePicker.Location = new System.Drawing.Point(139, 105);
            this.ngaysinhDateTimePicker.Name = "ngaysinhDateTimePicker";
            this.ngaysinhDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngaysinhDateTimePicker.TabIndex = 5;
            // 
            // ngayvaolamDateTimePicker
            // 
            this.ngayvaolamDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanvienBindingSource, "Ngayvaolam", true));
            this.ngayvaolamDateTimePicker.Location = new System.Drawing.Point(139, 131);
            this.ngayvaolamDateTimePicker.Name = "ngayvaolamDateTimePicker";
            this.ngayvaolamDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngayvaolamDateTimePicker.TabIndex = 7;
            // 
            // tennvTextBox
            // 
            this.tennvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanvienBindingSource, "Tennv", true));
            this.tennvTextBox.Location = new System.Drawing.Point(139, 78);
            this.tennvTextBox.Name = "tennvTextBox";
            this.tennvTextBox.Size = new System.Drawing.Size(200, 20);
            this.tennvTextBox.TabIndex = 9;
            // 
            // nhanvienBindingNavigator
            // 
            this.nhanvienBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nhanvienBindingNavigator.BindingSource = this.nhanvienBindingSource;
            this.nhanvienBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nhanvienBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nhanvienBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.nhanvienBindingNavigatorSaveItem});
            this.nhanvienBindingNavigator.Location = new System.Drawing.Point(0, 170);
            this.nhanvienBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nhanvienBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nhanvienBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nhanvienBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nhanvienBindingNavigator.Name = "nhanvienBindingNavigator";
            this.nhanvienBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nhanvienBindingNavigator.Size = new System.Drawing.Size(422, 25);
            this.nhanvienBindingNavigator.TabIndex = 1;
            this.nhanvienBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nhanvienBindingNavigatorSaveItem
            // 
            this.nhanvienBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nhanvienBindingNavigatorSaveItem.Enabled = false;
            this.nhanvienBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nhanvienBindingNavigatorSaveItem.Image")));
            this.nhanvienBindingNavigatorSaveItem.Name = "nhanvienBindingNavigatorSaveItem";
            this.nhanvienBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nhanvienBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // nhanvienDataGridView
            // 
            this.nhanvienDataGridView.AutoGenerateColumns = false;
            this.nhanvienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanvienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.nhanvienDataGridView.DataSource = this.nhanvienBindingSource;
            this.nhanvienDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanvienDataGridView.Location = new System.Drawing.Point(0, 195);
            this.nhanvienDataGridView.Name = "nhanvienDataGridView";
            this.nhanvienDataGridView.Size = new System.Drawing.Size(422, 266);
            this.nhanvienDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Manv";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Holot";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ nhân viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tennv";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên nhân viên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ngaysinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ngayvaolam";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày vào làm";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataSource = typeof(Do_an_winform.Class.Nhanvien);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 461);
            this.Controls.Add(this.nhanvienDataGridView);
            this.Controls.Add(this.nhanvienBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Danh sách nhân viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingNavigator)).EndInit();
            this.nhanvienBindingNavigator.ResumeLayout(false);
            this.nhanvienBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox holotTextBox;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private System.Windows.Forms.TextBox manvTextBox;
        private System.Windows.Forms.DateTimePicker ngaysinhDateTimePicker;
        private System.Windows.Forms.DateTimePicker ngayvaolamDateTimePicker;
        private System.Windows.Forms.TextBox tennvTextBox;
        private System.Windows.Forms.BindingNavigator nhanvienBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nhanvienBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nhanvienDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
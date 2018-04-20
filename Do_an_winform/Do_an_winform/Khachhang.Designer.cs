namespace Do_an_winform
{
    partial class Khachhang
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
            System.Windows.Forms.Label hokhLabel;
            System.Windows.Forms.Label makhLabel;
            System.Windows.Forms.Label ngaysinhLabel;
            System.Windows.Forms.Label tenkhLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khachhang));
            System.Windows.Forms.Label gioitinhLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hokhTextBox = new System.Windows.Forms.TextBox();
            this.makhTextBox = new System.Windows.Forms.TextBox();
            this.ngaysinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tenkhTextBox = new System.Windows.Forms.TextBox();
            this.khachhangBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.khachhangBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gioitinhTextBox = new System.Windows.Forms.TextBox();
            this.khachhangDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hokhLabel = new System.Windows.Forms.Label();
            makhLabel = new System.Windows.Forms.Label();
            ngaysinhLabel = new System.Windows.Forms.Label();
            tenkhLabel = new System.Windows.Forms.Label();
            gioitinhLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingNavigator)).BeginInit();
            this.khachhangBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hokhLabel
            // 
            hokhLabel.AutoSize = true;
            hokhLabel.Location = new System.Drawing.Point(13, 61);
            hokhLabel.Name = "hokhLabel";
            hokhLabel.Size = new System.Drawing.Size(84, 13);
            hokhLabel.TabIndex = 0;
            hokhLabel.Text = "Họ khách hàng:";
            // 
            // makhLabel
            // 
            makhLabel.AutoSize = true;
            makhLabel.Location = new System.Drawing.Point(12, 34);
            makhLabel.Name = "makhLabel";
            makhLabel.Size = new System.Drawing.Size(85, 13);
            makhLabel.TabIndex = 2;
            makhLabel.Text = "Mã khách hàng:";
            // 
            // ngaysinhLabel
            // 
            ngaysinhLabel.AutoSize = true;
            ngaysinhLabel.Location = new System.Drawing.Point(13, 143);
            ngaysinhLabel.Name = "ngaysinhLabel";
            ngaysinhLabel.Size = new System.Drawing.Size(57, 13);
            ngaysinhLabel.TabIndex = 4;
            ngaysinhLabel.Text = "Ngày sinh:";
            // 
            // tenkhLabel
            // 
            tenkhLabel.AutoSize = true;
            tenkhLabel.Location = new System.Drawing.Point(13, 87);
            tenkhLabel.Name = "tenkhLabel";
            tenkhLabel.Size = new System.Drawing.Size(89, 13);
            tenkhLabel.TabIndex = 6;
            tenkhLabel.Text = "Tên khách hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(gioitinhLabel);
            this.groupBox1.Controls.Add(this.gioitinhTextBox);
            this.groupBox1.Controls.Add(hokhLabel);
            this.groupBox1.Controls.Add(this.hokhTextBox);
            this.groupBox1.Controls.Add(makhLabel);
            this.groupBox1.Controls.Add(this.makhTextBox);
            this.groupBox1.Controls.Add(ngaysinhLabel);
            this.groupBox1.Controls.Add(this.ngaysinhDateTimePicker);
            this.groupBox1.Controls.Add(tenkhLabel);
            this.groupBox1.Controls.Add(this.tenkhTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // hokhTextBox
            // 
            this.hokhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachhangBindingSource, "Hokh", true));
            this.hokhTextBox.Location = new System.Drawing.Point(108, 58);
            this.hokhTextBox.Name = "hokhTextBox";
            this.hokhTextBox.Size = new System.Drawing.Size(200, 20);
            this.hokhTextBox.TabIndex = 1;
            // 
            // makhTextBox
            // 
            this.makhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachhangBindingSource, "Makh", true));
            this.makhTextBox.Location = new System.Drawing.Point(107, 31);
            this.makhTextBox.Name = "makhTextBox";
            this.makhTextBox.Size = new System.Drawing.Size(200, 20);
            this.makhTextBox.TabIndex = 3;
            // 
            // ngaysinhDateTimePicker
            // 
            this.ngaysinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.khachhangBindingSource, "Ngaysinh", true));
            this.ngaysinhDateTimePicker.Location = new System.Drawing.Point(108, 139);
            this.ngaysinhDateTimePicker.Name = "ngaysinhDateTimePicker";
            this.ngaysinhDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngaysinhDateTimePicker.TabIndex = 5;
            // 
            // tenkhTextBox
            // 
            this.tenkhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachhangBindingSource, "Tenkh", true));
            this.tenkhTextBox.Location = new System.Drawing.Point(108, 84);
            this.tenkhTextBox.Name = "tenkhTextBox";
            this.tenkhTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenkhTextBox.TabIndex = 7;
            // 
            // khachhangBindingNavigator
            // 
            this.khachhangBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.khachhangBindingNavigator.BindingSource = this.khachhangBindingSource;
            this.khachhangBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.khachhangBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.khachhangBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.khachhangBindingNavigatorSaveItem});
            this.khachhangBindingNavigator.Location = new System.Drawing.Point(0, 181);
            this.khachhangBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.khachhangBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.khachhangBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.khachhangBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.khachhangBindingNavigator.Name = "khachhangBindingNavigator";
            this.khachhangBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.khachhangBindingNavigator.Size = new System.Drawing.Size(548, 25);
            this.khachhangBindingNavigator.TabIndex = 1;
            this.khachhangBindingNavigator.Text = "bindingNavigator1";
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
            // khachhangBindingNavigatorSaveItem
            // 
            this.khachhangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.khachhangBindingNavigatorSaveItem.Enabled = false;
            this.khachhangBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("khachhangBindingNavigatorSaveItem.Image")));
            this.khachhangBindingNavigatorSaveItem.Name = "khachhangBindingNavigatorSaveItem";
            this.khachhangBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.khachhangBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataSource = typeof(Do_an_winform.Class.Khachhang);
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.Location = new System.Drawing.Point(13, 113);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(50, 13);
            gioitinhLabel.TabIndex = 8;
            gioitinhLabel.Text = "Giới tính:";
            // 
            // gioitinhTextBox
            // 
            this.gioitinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachhangBindingSource, "Gioitinh", true));
            this.gioitinhTextBox.Location = new System.Drawing.Point(108, 110);
            this.gioitinhTextBox.Name = "gioitinhTextBox";
            this.gioitinhTextBox.Size = new System.Drawing.Size(100, 20);
            this.gioitinhTextBox.TabIndex = 9;
            // 
            // khachhangDataGridView
            // 
            this.khachhangDataGridView.AutoGenerateColumns = false;
            this.khachhangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khachhangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.khachhangDataGridView.DataSource = this.khachhangBindingSource;
            this.khachhangDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khachhangDataGridView.Location = new System.Drawing.Point(0, 206);
            this.khachhangDataGridView.Name = "khachhangDataGridView";
            this.khachhangDataGridView.Size = new System.Drawing.Size(548, 266);
            this.khachhangDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Makh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã khách hàng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Hokh";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ khách hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tenkh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gioitinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ngaysinh";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 472);
            this.Controls.Add(this.khachhangDataGridView);
            this.Controls.Add(this.khachhangBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "Khachhang";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingNavigator)).EndInit();
            this.khachhangBindingNavigator.ResumeLayout(false);
            this.khachhangBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private System.Windows.Forms.BindingNavigator khachhangBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton khachhangBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox hokhTextBox;
        private System.Windows.Forms.TextBox makhTextBox;
        private System.Windows.Forms.DateTimePicker ngaysinhDateTimePicker;
        private System.Windows.Forms.TextBox tenkhTextBox;
        private System.Windows.Forms.TextBox gioitinhTextBox;
        private System.Windows.Forms.DataGridView khachhangDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
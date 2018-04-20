namespace Do_an_winform
{
    partial class Hanghoa
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
            System.Windows.Forms.Label giabanLabel;
            System.Windows.Forms.Label mahhLabel;
            System.Windows.Forms.Label motaLabel;
            System.Windows.Forms.Label nhomLabel;
            System.Windows.Forms.Label tenhhLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hanghoa));
            System.Windows.Forms.Label tennhaccLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.giabanTextBox = new System.Windows.Forms.TextBox();
            this.mahhTextBox = new System.Windows.Forms.TextBox();
            this.motaTextBox = new System.Windows.Forms.TextBox();
            this.nhomTextBox = new System.Windows.Forms.TextBox();
            this.tenhhTextBox = new System.Windows.Forms.TextBox();
            this.sanphamBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sanphamBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sanphamDataGridView = new System.Windows.Forms.DataGridView();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanphamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tennhaccTextBox = new System.Windows.Forms.TextBox();
            giabanLabel = new System.Windows.Forms.Label();
            mahhLabel = new System.Windows.Forms.Label();
            motaLabel = new System.Windows.Forms.Label();
            nhomLabel = new System.Windows.Forms.Label();
            tenhhLabel = new System.Windows.Forms.Label();
            tennhaccLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingNavigator)).BeginInit();
            this.sanphamBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // giabanLabel
            // 
            giabanLabel.AutoSize = true;
            giabanLabel.Location = new System.Drawing.Point(258, 67);
            giabanLabel.Name = "giabanLabel";
            giabanLabel.Size = new System.Drawing.Size(47, 13);
            giabanLabel.TabIndex = 0;
            giabanLabel.Text = "Giá bán:";
            // 
            // mahhLabel
            // 
            mahhLabel.AutoSize = true;
            mahhLabel.Location = new System.Drawing.Point(28, 31);
            mahhLabel.Name = "mahhLabel";
            mahhLabel.Size = new System.Drawing.Size(73, 13);
            mahhLabel.TabIndex = 2;
            mahhLabel.Text = "Mã hàng hoá:";
            // 
            // motaLabel
            // 
            motaLabel.AutoSize = true;
            motaLabel.Location = new System.Drawing.Point(28, 110);
            motaLabel.Name = "motaLabel";
            motaLabel.Size = new System.Drawing.Size(37, 13);
            motaLabel.TabIndex = 4;
            motaLabel.Text = "Mô tả:";
            // 
            // nhomLabel
            // 
            nhomLabel.AutoSize = true;
            nhomLabel.Location = new System.Drawing.Point(28, 70);
            nhomLabel.Name = "nhomLabel";
            nhomLabel.Size = new System.Drawing.Size(86, 13);
            nhomLabel.TabIndex = 6;
            nhomLabel.Text = "Nhóm hàng hoá:";
            // 
            // tenhhLabel
            // 
            tenhhLabel.AutoSize = true;
            tenhhLabel.Location = new System.Drawing.Point(258, 28);
            tenhhLabel.Name = "tenhhLabel";
            tenhhLabel.Size = new System.Drawing.Size(77, 13);
            tenhhLabel.TabIndex = 8;
            tenhhLabel.Text = "Tên hàng hoá:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(tennhaccLabel);
            this.groupBox1.Controls.Add(this.tennhaccTextBox);
            this.groupBox1.Controls.Add(giabanLabel);
            this.groupBox1.Controls.Add(this.giabanTextBox);
            this.groupBox1.Controls.Add(mahhLabel);
            this.groupBox1.Controls.Add(this.mahhTextBox);
            this.groupBox1.Controls.Add(motaLabel);
            this.groupBox1.Controls.Add(this.motaTextBox);
            this.groupBox1.Controls.Add(nhomLabel);
            this.groupBox1.Controls.Add(this.nhomTextBox);
            this.groupBox1.Controls.Add(tenhhLabel);
            this.groupBox1.Controls.Add(this.tenhhTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // giabanTextBox
            // 
            this.giabanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanphamBindingSource, "Giaban", true));
            this.giabanTextBox.Location = new System.Drawing.Point(362, 63);
            this.giabanTextBox.Name = "giabanTextBox";
            this.giabanTextBox.Size = new System.Drawing.Size(100, 20);
            this.giabanTextBox.TabIndex = 1;
            // 
            // mahhTextBox
            // 
            this.mahhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanphamBindingSource, "Mahh", true));
            this.mahhTextBox.Location = new System.Drawing.Point(120, 28);
            this.mahhTextBox.Name = "mahhTextBox";
            this.mahhTextBox.Size = new System.Drawing.Size(100, 20);
            this.mahhTextBox.TabIndex = 3;
            // 
            // motaTextBox
            // 
            this.motaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanphamBindingSource, "Mota", true));
            this.motaTextBox.Location = new System.Drawing.Point(120, 107);
            this.motaTextBox.Multiline = true;
            this.motaTextBox.Name = "motaTextBox";
            this.motaTextBox.Size = new System.Drawing.Size(100, 44);
            this.motaTextBox.TabIndex = 5;
            // 
            // nhomTextBox
            // 
            this.nhomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanphamBindingSource, "Nhom", true));
            this.nhomTextBox.Location = new System.Drawing.Point(120, 67);
            this.nhomTextBox.Name = "nhomTextBox";
            this.nhomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nhomTextBox.TabIndex = 7;
            // 
            // tenhhTextBox
            // 
            this.tenhhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanphamBindingSource, "Tenhh", true));
            this.tenhhTextBox.Location = new System.Drawing.Point(362, 25);
            this.tenhhTextBox.Name = "tenhhTextBox";
            this.tenhhTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenhhTextBox.TabIndex = 9;
            // 
            // sanphamBindingNavigator
            // 
            this.sanphamBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sanphamBindingNavigator.BindingSource = this.sanphamBindingSource;
            this.sanphamBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sanphamBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sanphamBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sanphamBindingNavigatorSaveItem});
            this.sanphamBindingNavigator.Location = new System.Drawing.Point(0, 171);
            this.sanphamBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sanphamBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sanphamBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sanphamBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sanphamBindingNavigator.Name = "sanphamBindingNavigator";
            this.sanphamBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sanphamBindingNavigator.Size = new System.Drawing.Size(563, 25);
            this.sanphamBindingNavigator.TabIndex = 1;
            this.sanphamBindingNavigator.Text = "bindingNavigator1";
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
            // sanphamBindingNavigatorSaveItem
            // 
            this.sanphamBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sanphamBindingNavigatorSaveItem.Enabled = false;
            this.sanphamBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sanphamBindingNavigatorSaveItem.Image")));
            this.sanphamBindingNavigatorSaveItem.Name = "sanphamBindingNavigatorSaveItem";
            this.sanphamBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sanphamBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // sanphamDataGridView
            // 
            this.sanphamDataGridView.AutoGenerateColumns = false;
            this.sanphamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sanphamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.Giaban,
            this.dataGridViewTextBoxColumn5});
            this.sanphamDataGridView.DataSource = this.sanphamBindingSource;
            this.sanphamDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sanphamDataGridView.Location = new System.Drawing.Point(0, 196);
            this.sanphamDataGridView.Name = "sanphamDataGridView";
            this.sanphamDataGridView.Size = new System.Drawing.Size(563, 266);
            this.sanphamDataGridView.TabIndex = 2;
            // 
            // Giaban
            // 
            this.Giaban.DataPropertyName = "Giaban";
            this.Giaban.HeaderText = "Giá bán";
            this.Giaban.Name = "Giaban";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Mahh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã hàng hoá";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tenhh";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên hàng hoá";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nhom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nhóm hàng hoá";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mota";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mô tả";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // sanphamBindingSource
            // 
            this.sanphamBindingSource.DataSource = typeof(Do_an_winform.Class.Sanpham);
            // 
            // tennhaccLabel
            // 
            tennhaccLabel.AutoSize = true;
            tennhaccLabel.Location = new System.Drawing.Point(258, 110);
            tennhaccLabel.Name = "tennhaccLabel";
            tennhaccLabel.Size = new System.Drawing.Size(98, 13);
            tennhaccLabel.TabIndex = 10;
            tennhaccLabel.Text = "Tên nhà cung cấp:";
            // 
            // tennhaccTextBox
            // 
            this.tennhaccTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanphamBindingSource, "Tennhacc", true));
            this.tennhaccTextBox.Location = new System.Drawing.Point(362, 107);
            this.tennhaccTextBox.Name = "tennhaccTextBox";
            this.tennhaccTextBox.Size = new System.Drawing.Size(100, 20);
            this.tennhaccTextBox.TabIndex = 11;
            // 
            // Hanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 462);
            this.Controls.Add(this.sanphamDataGridView);
            this.Controls.Add(this.sanphamBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hanghoa";
            this.Text = "Danh sách hàng hoá";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingNavigator)).EndInit();
            this.sanphamBindingNavigator.ResumeLayout(false);
            this.sanphamBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource sanphamBindingSource;
        private System.Windows.Forms.BindingNavigator sanphamBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sanphamBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox giabanTextBox;
        private System.Windows.Forms.TextBox mahhTextBox;
        private System.Windows.Forms.TextBox motaTextBox;
        private System.Windows.Forms.TextBox nhomTextBox;
        private System.Windows.Forms.TextBox tenhhTextBox;
        private System.Windows.Forms.DataGridView sanphamDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox tennhaccTextBox;
    }
}
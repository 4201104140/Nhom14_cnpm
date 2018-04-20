namespace Do_an_winform
{
    partial class Nhacungcap
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
            System.Windows.Forms.Label dcnhaccLabel;
            System.Windows.Forms.Label manhaccLabel;
            System.Windows.Forms.Label mathangLabel;
            System.Windows.Forms.Label tennhaccLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhacungcap));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dcnhaccTextBox = new System.Windows.Forms.TextBox();
            this.nhacungcapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manhaccTextBox = new System.Windows.Forms.TextBox();
            this.mathangTextBox = new System.Windows.Forms.TextBox();
            this.tennhaccTextBox = new System.Windows.Forms.TextBox();
            this.nhacungcapBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nhacungcapBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nhacungcapDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dcnhaccLabel = new System.Windows.Forms.Label();
            manhaccLabel = new System.Windows.Forms.Label();
            mathangLabel = new System.Windows.Forms.Label();
            tennhaccLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapBindingNavigator)).BeginInit();
            this.nhacungcapBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dcnhaccLabel
            // 
            dcnhaccLabel.AutoSize = true;
            dcnhaccLabel.Location = new System.Drawing.Point(285, 79);
            dcnhaccLabel.Name = "dcnhaccLabel";
            dcnhaccLabel.Size = new System.Drawing.Size(112, 13);
            dcnhaccLabel.TabIndex = 0;
            dcnhaccLabel.Text = "Địa chỉ nhà cung cấp:";
            // 
            // manhaccLabel
            // 
            manhaccLabel.AutoSize = true;
            manhaccLabel.Location = new System.Drawing.Point(27, 39);
            manhaccLabel.Name = "manhaccLabel";
            manhaccLabel.Size = new System.Drawing.Size(94, 13);
            manhaccLabel.TabIndex = 2;
            manhaccLabel.Text = "Mã nhà cung cấp:";
            // 
            // mathangLabel
            // 
            mathangLabel.AutoSize = true;
            mathangLabel.Location = new System.Drawing.Point(285, 39);
            mathangLabel.Name = "mathangLabel";
            mathangLabel.Size = new System.Drawing.Size(55, 13);
            mathangLabel.TabIndex = 4;
            mathangLabel.Text = "Mặt hàng:";
            // 
            // tennhaccLabel
            // 
            tennhaccLabel.AutoSize = true;
            tennhaccLabel.Location = new System.Drawing.Point(27, 79);
            tennhaccLabel.Name = "tennhaccLabel";
            tennhaccLabel.Size = new System.Drawing.Size(98, 13);
            tennhaccLabel.TabIndex = 6;
            tennhaccLabel.Text = "Tên nhà cung cấp:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(dcnhaccLabel);
            this.groupBox1.Controls.Add(this.dcnhaccTextBox);
            this.groupBox1.Controls.Add(manhaccLabel);
            this.groupBox1.Controls.Add(this.manhaccTextBox);
            this.groupBox1.Controls.Add(mathangLabel);
            this.groupBox1.Controls.Add(this.mathangTextBox);
            this.groupBox1.Controls.Add(tennhaccLabel);
            this.groupBox1.Controls.Add(this.tennhaccTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(323, 153);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(185, 41);
            this.txttimkiem.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(514, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 11;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dcnhaccTextBox
            // 
            this.dcnhaccTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhacungcapBindingSource, "Dcnhacc", true));
            this.dcnhaccTextBox.Location = new System.Drawing.Point(403, 76);
            this.dcnhaccTextBox.Multiline = true;
            this.dcnhaccTextBox.Name = "dcnhaccTextBox";
            this.dcnhaccTextBox.Size = new System.Drawing.Size(185, 43);
            this.dcnhaccTextBox.TabIndex = 1;
            // 
            // nhacungcapBindingSource
            // 
            this.nhacungcapBindingSource.DataSource = typeof(Do_an_winform.Class.Nhacungcap);
            // 
            // manhaccTextBox
            // 
            this.manhaccTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhacungcapBindingSource, "Manhacc", true));
            this.manhaccTextBox.Location = new System.Drawing.Point(145, 36);
            this.manhaccTextBox.Name = "manhaccTextBox";
            this.manhaccTextBox.Size = new System.Drawing.Size(100, 20);
            this.manhaccTextBox.TabIndex = 3;
            // 
            // mathangTextBox
            // 
            this.mathangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhacungcapBindingSource, "Mathang", true));
            this.mathangTextBox.Location = new System.Drawing.Point(403, 36);
            this.mathangTextBox.Name = "mathangTextBox";
            this.mathangTextBox.Size = new System.Drawing.Size(185, 20);
            this.mathangTextBox.TabIndex = 5;
            // 
            // tennhaccTextBox
            // 
            this.tennhaccTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhacungcapBindingSource, "Tennhacc", true));
            this.tennhaccTextBox.Location = new System.Drawing.Point(145, 76);
            this.tennhaccTextBox.Name = "tennhaccTextBox";
            this.tennhaccTextBox.Size = new System.Drawing.Size(100, 20);
            this.tennhaccTextBox.TabIndex = 7;
            // 
            // nhacungcapBindingNavigator
            // 
            this.nhacungcapBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nhacungcapBindingNavigator.BindingSource = this.nhacungcapBindingSource;
            this.nhacungcapBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nhacungcapBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nhacungcapBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nhacungcapBindingNavigatorSaveItem});
            this.nhacungcapBindingNavigator.Location = new System.Drawing.Point(0, 214);
            this.nhacungcapBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nhacungcapBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nhacungcapBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nhacungcapBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nhacungcapBindingNavigator.Name = "nhacungcapBindingNavigator";
            this.nhacungcapBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nhacungcapBindingNavigator.Size = new System.Drawing.Size(612, 25);
            this.nhacungcapBindingNavigator.TabIndex = 1;
            this.nhacungcapBindingNavigator.Text = "bindingNavigator1";
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
            // nhacungcapBindingNavigatorSaveItem
            // 
            this.nhacungcapBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nhacungcapBindingNavigatorSaveItem.Enabled = false;
            this.nhacungcapBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nhacungcapBindingNavigatorSaveItem.Image")));
            this.nhacungcapBindingNavigatorSaveItem.Name = "nhacungcapBindingNavigatorSaveItem";
            this.nhacungcapBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nhacungcapBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // nhacungcapDataGridView
            // 
            this.nhacungcapDataGridView.AutoGenerateColumns = false;
            this.nhacungcapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhacungcapDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.nhacungcapDataGridView.DataSource = this.nhacungcapBindingSource;
            this.nhacungcapDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhacungcapDataGridView.Location = new System.Drawing.Point(0, 239);
            this.nhacungcapDataGridView.Name = "nhacungcapDataGridView";
            this.nhacungcapDataGridView.Size = new System.Drawing.Size(612, 207);
            this.nhacungcapDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Manhacc";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhà cung cấp";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tennhacc";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhà cung cấp";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Dcnhacc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Địa chỉ nhà cung cấp";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Mathang";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mặt hàng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Nhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 446);
            this.Controls.Add(this.nhacungcapDataGridView);
            this.Controls.Add(this.nhacungcapBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "Nhacungcap";
            this.Text = "Nhà cung cấp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapBindingNavigator)).EndInit();
            this.nhacungcapBindingNavigator.ResumeLayout(false);
            this.nhacungcapBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcapDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dcnhaccTextBox;
        private System.Windows.Forms.BindingSource nhacungcapBindingSource;
        private System.Windows.Forms.TextBox manhaccTextBox;
        private System.Windows.Forms.TextBox mathangTextBox;
        private System.Windows.Forms.TextBox tennhaccTextBox;
        private System.Windows.Forms.BindingNavigator nhacungcapBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nhacungcapBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nhacungcapDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}